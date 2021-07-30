using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BlazorStudioManager.Server.Data;
using BlazorStudioManager.Shared.IdentityModels;
using BlazorStudioManager.Shared.ReportModels.json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Xml;
using Telerik.Reporting;
using Telerik.Reporting.Services;
using Telerik.Reporting.XmlSerialization;
using BlazorStudioManager.Shared;
using Telerik.Blazor.Components;
using Telerik.DataSource;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorStudioManager.Server
{
    public class MyReportSourceResolver : IReportSourceResolver
    {
        //private readonly StudioManagerIdentityContext _contextIdentity;
        //private readonly StudioManagerContext _context;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IServiceProvider _serviceProvider;

        public string ReportSourceJson { get; set; }
        public string modelType { get; set; }
        public string userName { get; set; }
        public string userId { get; set; }
        public Report reportInstance { get; set; }
        public ReportTemplate foundTemplate { get; set; }
        public InstanceReportSource iRs { get; set; }
        private readonly DbContextOptions<StudioManagerIdentityContext> StudioManagerIdentityOptions;
        private readonly DbContextOptions<StudioManagerContext> StudioManagerOptions;
        public ReportSourceCatalog reportSourceCatalog { get; set; } = new ReportSourceCatalog();

        public MyReportSourceResolver(IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IServiceProvider serviceProvider)
        {
            _httpContextAccessor = httpContextAccessor;
            _serviceProvider = serviceProvider;

            var conStringUser = configuration.GetConnectionString("StudioManagerIdentityConnectionLocal");
            var optionsBuilderUser = new DbContextOptionsBuilder<StudioManagerIdentityContext>();
            optionsBuilderUser.UseSqlServer(conStringUser);
            this.StudioManagerIdentityOptions = optionsBuilderUser.Options;
            //var contextIdentity = new StudioManagerIdentityContext(optionsBuilderUser.Options);

            var conString = configuration.GetConnectionString("StudioManagerUserConnectionMaster");
            var optionsBuilder = new DbContextOptionsBuilder<StudioManagerContext>();
            optionsBuilder.UseSqlServer(conString);
            this.StudioManagerOptions = optionsBuilder.Options;
            //var context = new StudioManagerContext(optionsBuilder.Options);

            //_contextIdentity = contextIdentity;
            //_context = context;
        }
        public ReportSource Resolve(string reportName, OperationOrigin operationOrigin, IDictionary<string, object> currentParameterValues)
        {
            var _contextIdentity = new StudioManagerIdentityContext(this.StudioManagerIdentityOptions);
            if (reportName.Contains("{"))
            {
                // Converts the JSON data into a dynamic object and reads the reportName field
                ReportSourceCatalog reportSourceData = Newtonsoft.Json.JsonConvert.DeserializeObject<ReportSourceCatalog>(reportName);
                var thisreportName = reportSourceData.Name;

                // Retrieve the report definition bytes from the database.
                foundTemplate = _contextIdentity.ReportTemplates.FirstOrDefault(c => c.ReportTemplateName == thisreportName);
                if (foundTemplate == null)
                {
                    return null;
                }

                Report reportInstance = null;
                if (thisreportName.EndsWith(".trdx"))
                {
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.IgnoreWhitespace = true;
                    using (XmlReader xmlReader = XmlReader.Create(new MemoryStream(foundTemplate.Layout), settings))
                    {
                        ReportXmlSerializer xmlSerializer = new ReportXmlSerializer();

                        reportInstance = (Report)xmlSerializer.Deserialize(xmlReader);
                    }
                }
                else
                {
                    var reportPackager = new ReportPackager();
                    using (var sourceStream = new MemoryStream(foundTemplate.Layout))
                    {
                        reportInstance = (Report)reportPackager.UnpackageDocument(sourceStream);
                    }
                }

                var rpt = reportInstance.Report;

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(reportSourceData.Data);

                rpt.DataSource = new JsonDataSource
                {
                    Source = json
                };

                var iRs = new InstanceReportSource
                {
                    ReportDocument = reportInstance
                };

                return iRs;
            }
            else
            {
                userName = _httpContextAccessor.HttpContext.User.Identity.Name;
                userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

                var currentUserEmail = Telerik.Reporting.Processing.UserIdentity.Current.Name;

                using (var scope = _serviceProvider.CreateScope())
                {
                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<StudioManagerUser>>();
                    var user = userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result;
                    var filtText = CustomClaimTypes.ReportNameAndData.ToString();
                    var nameAndData = userManager.GetClaimsAsync(user).Result?.FirstOrDefault(x => x.Type == "ReportNameAndData")?.Value;
                    modelType = userManager.GetClaimsAsync(user).Result?.FirstOrDefault(x => x.Type == "ModelType")?.Value;

                    // Retrieve the report definition bytes from the database.
                    foundTemplate = _contextIdentity.ReportTemplates.Where(c => c.CreatedByUserId == user.Id).Where(c => c.ModelType == modelType).FirstOrDefault(c => c.ReportTemplateName == reportName);
                    if (foundTemplate == null)
                    {
                        return null;
                    }

                    return SetReportSourceJson(reportName);

                }
            }
        }

        public InstanceReportSource SetReportSourceJson(string reportName)
        {
            switch (modelType)
            {
                case "Catalogs":
                    return FillCatalogs(reportName);
                default:
                    return new InstanceReportSource();
            }
        }

        private InstanceReportSource FillCatalogs(string reportName)
        {
            var _contextIdentity = new StudioManagerIdentityContext(this.StudioManagerIdentityOptions);
            var _context = new StudioManagerContext(this.StudioManagerOptions);

            var GridData = _context.Catalogs.ToList();

            var gridSave = _contextIdentity.GridSaves.Where(c => c.StoreName == "ReportCatalog").Where(c => c.AspUserId == userId).FirstOrDefault();

            GridState<Catalog> gridState = new GridState<Catalog>();
            if (gridSave != null)
            {
                gridState = JsonSerializer.Deserialize<GridState<Catalog>>(gridSave.GridAllSettings);
                //gridState = Newtonsoft.Json.JsonConvert.DeserializeObject<GridState<Catalog>>(gridSave.GridAllSettings);
            }

            var reportSourceObject = new ReportSourceCatalog();
            reportSourceObject.Name = reportName;
            reportSourceObject.Data = GridData;

            var fdCollection = gridState.FilterDescriptors;

            // Translating the filter applied to the grid to JSON data
            foreach (FilterDescriptor fd in gridState.FilterDescriptors)
            //foreach (var fd in fdCollection)
            {
                if (fd.ConvertedValue != null)
                {
                    var filter = new ReportSourceFilter();
                    filter.Member = fd.Member;
                    filter.Value = fd.ConvertedValue;
                    filter.OperatorString = Enum.GetName(typeof(Telerik.DataSource.FilterOperator), fd.Operator);
                    if (reportSourceObject.Filters == null) reportSourceObject.Filters = new List<ReportSourceFilter>();
                    reportSourceObject.Filters.Add(filter);
                }
            }

            // Translating the sorting applied to the grid to JSON data
            if (gridState.SortDescriptors.Count != 0)
            {
                SortDescriptor sd = gridState.SortDescriptors.First();
                var sorting = new ReportSourceSorting();
                sorting.Direction = Enum.GetName(typeof(ListSortDirection), sd.SortDirection);
                sorting.Member = sd.Member;
                reportSourceObject.Sortings = sorting;
            }

            // If there is grouping applied, translate it to JSON
            if (gridState.GroupDescriptors.Count > 0)
            {
                reportSourceObject.Grouping = gridState.GroupDescriptors.First().Member;
            }

            if (reportName.EndsWith(".trdx"))
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;
                using (XmlReader xmlReader = XmlReader.Create(new MemoryStream(foundTemplate.Layout), settings))
                {
                    ReportXmlSerializer xmlSerializer = new ReportXmlSerializer();

                    reportInstance = (Report)xmlSerializer.Deserialize(xmlReader);
                }
            }
            else
            {
                var reportPackager = new ReportPackager();
                using (var sourceStream = new MemoryStream(foundTemplate.Layout))
                {
                    reportInstance = (Report)reportPackager.UnpackageDocument(sourceStream);
                }
            }

            var rpt = reportInstance.Report;

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(reportSourceObject.Data);

            rpt.DataSource = new JsonDataSource
            {
                Source = json
            };


            iRs = new InstanceReportSource
            {
                ReportDocument = reportInstance
            };

            return iRs;
        }
    }
}

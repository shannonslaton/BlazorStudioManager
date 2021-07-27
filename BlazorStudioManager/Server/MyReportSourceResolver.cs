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
using System.Threading.Tasks;
using System.Xml;
using Telerik.Reporting;
using Telerik.Reporting.Services;
using Telerik.Reporting.XmlSerialization;
using BlazorStudioManager.Shared;

namespace BlazorStudioManager.Server
{
    public class MyReportSourceResolver : IReportSourceResolver
    {
        private readonly StudioManagerIdentityContext _contextIdentiy;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IServiceProvider _serviceProvider;

        public MyReportSourceResolver(IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IServiceProvider serviceProvider)
        {
            //var currentUserEmail = Telerik.Reporting.Processing.UserIdentity.Current.Name;
            _httpContextAccessor = httpContextAccessor;
            _serviceProvider = serviceProvider;

            var conStringUser = configuration.GetConnectionString("StudioManagerIdentityConnectionLocal");
            var optionsBuilder = new DbContextOptionsBuilder<StudioManagerIdentityContext>();
            optionsBuilder.UseSqlServer(conStringUser);
            var contextIdentiy = new StudioManagerIdentityContext(optionsBuilder.Options);

            _contextIdentiy = contextIdentiy;
        }
        public ReportSource Resolve(string report, OperationOrigin operationOrigin, IDictionary<string, object> currentParameterValues)
        {
            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var currentUserEmail = Telerik.Reporting.Processing.UserIdentity.Current.Name;

            using (var scope = _serviceProvider.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<StudioManagerUser>>();
                var user = userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result;
                var filtText = CustomClaimTypes.ReportNameAndData.ToString();
                var nameAndData = userManager.GetClaimsAsync(user).Result?.FirstOrDefault(x => x.Type == "ReportNameAndData")?.Value;

                report = nameAndData.Replace("ReplaceName", report);

                // Converts the JSON data into a dynamic object and reads the reportName field
                ReportSourceModel reportSourceData = Newtonsoft.Json.JsonConvert.DeserializeObject<ReportSourceModel>(report);
                var mtype = reportSourceData.ModelType;
                var reportName = reportSourceData.Name;

                // Retrieve the report definition bytes from the database.
                var foundTemplate = _contextIdentiy.ReportTemplates.FirstOrDefault(c => c.ReportTemplateName == reportName);
                if (foundTemplate == null)
                {
                    return null;
                }

                Report reportInstance = null;
                if (report.EndsWith(".trdx"))
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

                var iRs = new InstanceReportSource
                {
                    ReportDocument = reportInstance
                };

                return iRs;
            }
        }
    }
}

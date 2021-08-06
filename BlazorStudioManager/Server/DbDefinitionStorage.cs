using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BlazorStudioManager.Server.Data;
using BlazorStudioManager.Shared.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.WebReportDesigner.Services;
using BlazorStudioManager.Shared;
using Telerik.Reporting.Processing;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorStudioManager.Server
{
    public class DbDefinitionStorage : IDefinitionStorage
    {
        public string BaseDir => throw new NotImplementedException();
        private readonly DbContextOptions<StudioManagerIdentityContext> StudioManagerIdentityOptions;
        private readonly DbContextOptions<StudioManagerUserContext> StudioManagerUserOptions;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IServiceProvider _serviceProvider;

        private int savedUserChangesCount { get; set; } = 0;
        private int savedIdentityChangesCount { get; set; } = 0;
        private StudioManagerUser CurrentUser { get; set; }
        private string GridStoreName { get; set; } = "CompanyMembers";
        private SharedProduction CurrentSharedProduction { get; set; }

        public string currentUserId { get; set; }

        public DbDefinitionStorage(
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor,
            IServiceProvider serviceProvider
            )
        {
            _httpContextAccessor = httpContextAccessor;
            _serviceProvider = serviceProvider;

            var conStringUser = configuration.GetConnectionString("StudioManagerUserConnectionMaster");
            var optionsBuilderUser = new DbContextOptionsBuilder<StudioManagerUserContext>();
            optionsBuilderUser.UseSqlServer(conStringUser);
            this.StudioManagerUserOptions = optionsBuilderUser.Options;

            var conStringIdentity = configuration.GetConnectionString("StudioManagerIdentityConnectionLocal");
            var optionsBuilderIdentity = new DbContextOptionsBuilder<StudioManagerIdentityContext>();
            optionsBuilderIdentity.UseSqlServer(conStringIdentity);
            this.StudioManagerIdentityOptions = optionsBuilderIdentity.Options;

            var contextUser = new StudioManagerUserContext(optionsBuilderUser.Options);
            var contextIdentity = new StudioManagerIdentityContext(optionsBuilderIdentity.Options);
        }

        public IEnumerable<string> ListDefinitions()
        {
            var _contextUser = new StudioManagerUserContext(this.StudioManagerUserOptions);
            var _contextIdentity = new StudioManagerIdentityContext(this.StudioManagerIdentityOptions);

            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var modelType = string.Empty;

            using (var scope = _serviceProvider.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<StudioManagerUser>>();
                var user = userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result;
                modelType = userManager.GetClaimsAsync(user).Result?.FirstOrDefault(x => x.Type == "ModelType")?.Value;

                var returnList = new List<string>();

                var foundList = _contextIdentity.ReportTemplates.Where(c => c.CreatedByUserId == user.Id).Where(c => c.Deleted == false).Where(c => c.Hidden == false).Where(c => c.ModelType == modelType);

                foreach (var item in foundList)
                {
                    returnList.Add(item.ReportTemplateName);
                }
                return returnList;
            }
        }

        public byte[] GetDefinition(string definitionId)
        {
            var _contextUser = new StudioManagerUserContext(this.StudioManagerUserOptions);
            var _contextIdentity = new StudioManagerIdentityContext(this.StudioManagerIdentityOptions);

            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var modelType = string.Empty;

            using (var scope = _serviceProvider.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<StudioManagerUser>>();
                var user = userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result;
                modelType = userManager.GetClaimsAsync(user).Result?.FirstOrDefault(x => x.Type == "ModelType")?.Value;

                var returnTemplate = new byte[7000];
                var foundTemplate = _contextIdentity.ReportTemplates.Where(c => c.CreatedByUserId == user.Id).Where(c => c.ModelType == modelType).Where(c => c.Deleted == false).Where(c => c.Hidden == false).FirstOrDefault(c => c.ReportTemplateName == definitionId);
                if (foundTemplate != null)
                {
                    return foundTemplate.Layout;
                }
                else
                {
                    return returnTemplate;
                }
            }
        }

        public void SaveDefinition(string definitionId, byte[] definition)
        {
            var _contextUser = new StudioManagerUserContext(this.StudioManagerUserOptions);
            var _contextIdentity = new StudioManagerIdentityContext(this.StudioManagerIdentityOptions);

            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var modelType = string.Empty;
            var globalLayoutString = string.Empty;
            var globalLayout = false;

            using (var scope = _serviceProvider.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<StudioManagerUser>>();
                var user = userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result;
                modelType = userManager.GetClaimsAsync(user).Result?.FirstOrDefault(x => x.Type == "ModelType")?.Value;
                globalLayoutString = userManager.GetClaimsAsync(user).Result?.FirstOrDefault(x => x.Type == "GlobalLayout")?.Value;

                if (globalLayoutString == "true")
                {
                    globalLayout = true;
                }

                var existing = _contextIdentity.ReportTemplates.Where(c => c.CreatedByUserId == user.Id).Where(c => c.ModelType == modelType).Where(c => c.Deleted == false).Where(c => c.Hidden == false).FirstOrDefault(c => c.ReportTemplateName == definitionId);

                if (existing != null)
                {
                    existing.Layout = definition;
                    existing.LastModifiedOnDt = DateTime.Now;
                }
                else
                {
                    var saveTemplate = new ReportTemplate()
                    {
                        Layout = definition,
                        ReportTemplateName = definitionId,
                        LastModifiedOnDt = DateTime.Now,
                        LastModifiedById = user.Id,
                        CreatedByUserId = user.Id,
                        CreatedOn = DateTime.Now,
                        ModelType = modelType,
                        GlobalLayout = globalLayout,
                        EditIndex = 0
                    };

                    _contextIdentity.Add(saveTemplate);
                }

                var savedChangesCount = _contextIdentity.SaveChanges();
            }
        }
        public void DeleteDefinition(string definitionId)
        {
            var _contextUser = new StudioManagerUserContext(this.StudioManagerUserOptions);
            var _contextIdentity = new StudioManagerIdentityContext(this.StudioManagerIdentityOptions);

            // Delete the report definition from the database.
        }
    }
}

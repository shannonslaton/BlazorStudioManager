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

namespace BlazorStudioManager.Server
{
    public class DbDefinitionStorage : IDefinitionStorage
    {
        public string BaseDir => throw new NotImplementedException();
        private readonly StudioManagerContext _contextUser;
        private readonly StudioManagerIdentityContext _contextIdentity;

        private int savedUserChangesCount { get; set; } = 0;
        private int savedIdentityChangesCount { get; set; } = 0;
        private StudioManagerUser CurrentUser { get; set; }
        //private Contact CurrentContact { get; set; }
        private string GridStoreName { get; set; } = "CompanyMembers";
        //private Production CurrentProduction { get; set; }
        //private CompanyMember CurrentCompanyMember { get; set; }
        private SharedProduction CurrentSharedProduction { get; set; }

        //public ClaimsPrincipal identity { get; set; }
        //public string UserId { get; set; }
        //private ReportTemplatesController cont { get; set; }
        public string currentUserId { get; set; }

        public DbDefinitionStorage(IConfiguration configuration)
        {
            var conStringUser = configuration.GetConnectionString("StudioManagerUserConnectionMaster");
            var optionsBuilder = new DbContextOptionsBuilder<StudioManagerContext>();
            optionsBuilder.UseSqlServer(conStringUser);
            var contextUser = new StudioManagerContext(optionsBuilder.Options);

            var conStringIdentity = configuration.GetConnectionString("StudioManagerIdentityConnectionLocal");
            var optionsBuilderIdentity = new DbContextOptionsBuilder<StudioManagerIdentityContext>();
            optionsBuilderIdentity.UseSqlServer(conStringIdentity);
            var contextIdentity = new StudioManagerIdentityContext(optionsBuilderIdentity.Options);

            _contextUser = contextUser;
            _contextIdentity = contextIdentity;

            //cont = new ReportTemplatesController(_contextUser, _contextIdentity);
            //currentUserId = cont.GetCurrentUser();


        }

        /// <summary>
        /// Lists all report definitions.
        /// </summary>
        /// <returns>A list of all report definitions present in the storage.</returns>
        public IEnumerable<string> ListDefinitions()
        {
            //var pubNew = new PublicClaims();
            //var pageName = pubNew.GetClaim<string>(PublicClaims.AuthenticatedClaimTypes.PageName);
            //var userId = pubNew.GetClaim<string>(PublicClaims.AuthenticatedClaimTypes.UserId);
            var returnList = new List<string>();

            //var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
            //var UserId = identity.FindFirst(ClaimTypes.NameIdentifier).Value;

            var foundList = _contextIdentity.ReportTemplates;
            //var ConnectionString = "Data Source=.\\SQLExpress;Initial Catalog=ShowBuilderBlazorUser0;Trusted_Connection=True;MultipleActiveResultSets=false";
            //SqlConnection connection = new SqlConnection(ConnectionString);

            //var command = new SqlCommand("GetReportTemplates", connection);
            //command.CommandType = System.Data.CommandType.StoredProcedure;
            //connection.Open();
            //SqlDataReader reader = command.ExecuteReader();

            //var templateName = "";

            //while (reader.Read())
            //{
            //    templateName = (string)reader["ReportTemplateName"];
            //    returnList.Add(templateName);
            //}

            foreach (var item in foundList)
            {
                returnList.Add(item.ReportTemplateName);
            }
            return returnList;
            // Retrieve all available reports in the database and return their unique identifiers.
        }

        /// <summary>
        /// Finds a report definition by its id.
        /// </summary>
        /// <param name="definitionId">The report definition identifier.</param>
        /// <returns>The bytes of the report definition.</returns>
        public byte[] GetDefinition(string definitionId)
        {
            var returnTemplate = new byte[7000];
            var foundTemplate = _contextIdentity.ReportTemplates.FirstOrDefault(c => c.ReportTemplateName == definitionId);
            if (foundTemplate != null)
            {
                return foundTemplate.Layout;
            }
            else
            {
                return returnTemplate;
            }

            
            // Retrieve the report definition bytes from the database.
        }

        /// <summary>
        /// Creates new or overwrites an existing report definition with the provided definition bytes.
        /// </summary>
        /// <param name="definitionId">The report definition identifier.</param>
        /// <param name="definition">The new bytes of the report definition.</param>
        public void SaveDefinition(string definitionId, byte[] definition)
        {
            var saveTemplate = new ReportTemplate()
            {
                Layout = definition,
                ReportTemplateName = definitionId,
                LastModifiedOnDt = DateTime.Now,
                OwnerContactRecId = 1
            };

            _contextIdentity.Add(saveTemplate);
            _contextIdentity.SaveChanges();
            // Save the report definiton bytes to the database.
        }

        /// <summary>
        /// Deletes an existing report definition.
        /// </summary>
        /// <param name="definitionId">The report definition identifier.</param>
        public void DeleteDefinition(string definitionId)
        {
            // Delete the report definition from the database.
        }
    }
}

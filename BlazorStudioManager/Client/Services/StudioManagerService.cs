using BlazorStudioManager.Shared;
using BlazorStudioManager.Shared.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Telerik.Blazor.Components;

namespace BlazorStudioManager.Client.Services
{
    public class StudioManagerService : IStudioManagerService
    {
        private readonly HttpClient client;

        public StudioManagerService(HttpClient httpClient)
        {
            client = httpClient;
        }

        #region Public Enums
        public async Task SetEnums(PassReportDefinition passReportDefinition)
        {
            await client.PostAsJsonAsync("api/PublicClaims/SetEnums", passReportDefinition);
        }
        #endregion

        public async Task<List<string>> GetReportTemplatesDdo()
        {
            return await client.GetFromJsonAsync<List<string>>("api/ReportTemplates/GetReportTemplatesDdo");
        }

        public async Task<GridState<Catalog>> GetGridSaveCatalogs(string GridSaveName)
        {
            return await client.GetFromJsonAsync<GridState<Catalog>>($"api/Catalogs/GetGridSave/{GridSaveName}");
        }
        public async Task<HttpResponseMessage> PostGridSaveCatalogs(PassGridState passState)
        {
            return await client.PostAsJsonAsync($"api/Catalogs/PostGridSave", passState);
        }

    }
}

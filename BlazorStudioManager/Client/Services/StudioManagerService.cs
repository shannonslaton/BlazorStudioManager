using BlazorStudioManager.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

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
    }
}

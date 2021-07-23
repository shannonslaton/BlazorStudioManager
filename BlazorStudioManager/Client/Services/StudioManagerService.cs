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
        public async Task<bool> SetEnums(string reportType)
        {
            return await client.GetFromJsonAsync<bool>($"api/PublicClaims/SetEnums/{reportType}");
        }
        #endregion
    }
}

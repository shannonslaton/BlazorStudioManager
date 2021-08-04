using BlazorStudioManager.Shared;
using BlazorStudioManager.Shared.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Telerik.Blazor.Components;

namespace BlazorStudioManager.Client.Services
{
    public interface IStudioManagerService
    {
        #region Public Enums
        Task SetEnums(PassReportDefinition passReportDefinition);
        #endregion

        Task<List<string>> GetReportTemplatesDdo();
        Task<GridState<Catalog>> GetGridSaveCatalogs(string GridSaveName);
        Task<HttpResponseMessage> PostGridSaveCatalogs(PassGridState passState);
    }
}

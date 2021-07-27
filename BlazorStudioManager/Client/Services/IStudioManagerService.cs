using BlazorStudioManager.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStudioManager.Client.Services
{
    public interface IStudioManagerService
    {
        #region Public Enums
        Task SetEnums(PassReportDefinition passReportDefinition);
        #endregion
    }
}

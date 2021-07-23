using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStudioManager.Client.Services
{
    public interface IStudioManagerService
    {
        #region Public Enums
        Task<bool> SetEnums(string pageName);
        #endregion
    }
}

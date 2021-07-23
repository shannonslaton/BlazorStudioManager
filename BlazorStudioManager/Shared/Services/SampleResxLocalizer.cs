using BlazorStudioManager.Shared.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Blazor.Services;

namespace BlazorStudioManager.Shared.Services
{
    public class SampleResxLocalizer : ITelerikStringLocalizer
    {
        public string this[string name]
        {
            get
            {
                return GetStringFromResource(name);
            }
        }

        public string GetStringFromResource(string key)
        {
            return Messages.ResourceManager.GetString(key, Messages.Culture);
        }
    }
}

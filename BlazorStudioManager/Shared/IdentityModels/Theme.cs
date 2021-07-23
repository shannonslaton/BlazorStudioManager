using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public partial class Theme : BaseEntityOwner
    {
        public string ThemeId { get; set; }
        public string ThemeName { get; set; }
        public string ThemeUrl { get; set; }
        public bool isDark { get; set; }
        public string ThemeShade { get; set; }
    }
}

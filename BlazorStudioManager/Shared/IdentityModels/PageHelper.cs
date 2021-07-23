using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public partial class PageHelper : BaseEntity
    {
        public string WidgetId { get; set; }
        public string PageTitle { get; set; }
        public string PageHelp { get; set; }
        public string VideoUrl { get; set; }
        public string VideoTitle { get; set; }
        public string PageType { get; set; }
        public int GridVersion { get; set; }
        public string LoadType { get; set; }
    }
}

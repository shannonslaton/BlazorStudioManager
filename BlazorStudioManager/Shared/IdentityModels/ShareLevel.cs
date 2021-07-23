using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public partial class ShareLevel : BaseEntity
    {

        public string ShareLevelName { get; set; }
        public string RoleId { get; set; }
        public long SizeAllotment { get; set; }
        public string SizeFriendlyName { get; set; }
    
    }
}

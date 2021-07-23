using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class VersionHistory : BaseEntity
    {
        public string Version { get; set; }
        public bool IsCurrent { get; set; }
    }
}

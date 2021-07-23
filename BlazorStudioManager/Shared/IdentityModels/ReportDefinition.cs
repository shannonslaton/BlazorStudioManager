using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class ReportDefinition : BaseEntity
    {
        public byte[] ReportTemplate { get; set; }
        public string StudioManagerUserId { get; set; }
        public string ReportType { get; set; }
        public string ReportName { get; set; }
        public string CreatedByName { get; set; }
    }
}

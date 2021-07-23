using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStudioManager.Client.Shared.Helpers
{
    public class DropDownOptionVM
    {
        public string RecId { get; set; }
        public string DdoType { get; set; }
        public string DdoTitle { get; set; }
        public string DdoAbrv { get; set; }
        public string DdoNote { get; set; }
        public string DdoUrl { get; set; }
        public string MeasurementType { get; set; }
        public int? Rank { get; set; }
        public bool? Locked { get; set; }
        public int? DefaultRecId { get; set; }
        public int? ProductionId { get; set; }
        public int? OwnerContactRecId { get; set; }
    }
}

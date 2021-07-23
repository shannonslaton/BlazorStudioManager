using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public partial class DefaultAppointmentType
    {
        public int RecId { get; set; }
        public string AppointmentTypeName { get; set; }
        public string ColorString { get; set; }
    }
}

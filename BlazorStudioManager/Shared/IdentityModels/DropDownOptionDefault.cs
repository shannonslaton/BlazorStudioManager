using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class DropDownOptionDefault
    {
        public int RecId { get; set; }
        public string DdoType { get; set; }
        public string DdoTitle { get; set; }
        public string DdoAbrv { get; set; }
        public int? DefaultDisciplineId { get; set; }
        public int? DefaultProductionDisciplineId { get; set; }
        public int? DefaultCompanyMemberDepartmentId { get; set; }
    }
}

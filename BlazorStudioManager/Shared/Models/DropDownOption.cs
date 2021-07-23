using BlazorStudioManager.Shared.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BlazorStudioManager.Shared.Models
{
    public partial class DropDownOption : BaseEntity
    {
        public DropDownOption()
        {

        }

        [Required]
        public string DdoType { get; set; }
        [Required]
        public string DdoTitle { get; set; }
        public string SubType { get; set; }
        public string DdoAbrv { get; set; }
        public string DdoNote { get; set; }
        public string DdoUrl { get; set; }
        public string MeasurementType { get; set; }
        public int? Rank { get; set; }
        public bool? Locked { get; set; }
        public int? DefaultRecId { get; set; }
        public int? ProductionId { get; set; }
        public int? OwnerContactRecId { get; set; }
        public int? DefaultDisciplineId { get; set; }
        public int? DefaultProductionDisciplineId { get; set; }
        public int? DefaultCompanyMemberDepartmentId { get; set; }
        public string ProductionOwnerUserId { get; set; }
        public string ProductionConnectionString { get; set; }
        public int ShareLevelId { get; set; }
        public int? DisciplineId { get; set; }
        public int IndexNumber { get; set; }
        public string Reason { get; set; }
        public int LinkId { get; set; }
        public string Abbreviation { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }

        public string CreatedByUserId { get; set; }
        public string FromUserId { get; set; }
        public int FromRecId { get; set; } = 0;
    }
}

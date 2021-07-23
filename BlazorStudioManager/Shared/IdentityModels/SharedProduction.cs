using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class SharedProduction
    {
        public SharedProduction()
        {
            ShareMessages = new HashSet<ShareMessage>();
        }

        public int RecId { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime? LastModifiedOnDt { get; set; }
        public bool? Updated { get; set; }

        public int ProductionId { get; set; }
        public string OwnerUserId { get; set; }
        public int OwnerContactId { get; set; }
        public string SharedWithUserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Archive { get; set; }
        public int ShareLevelId { get; set; }
        public bool IsProductionCreator { get; set; }
        public bool UserHasConnected { get; set; }
        public string SharedWithEmail { get; set; }
        public int ShareWithContactId { get; set; }
        public bool Enabled { get; set; }
        public int? CompanyMemberId { get; set; }
        public bool Deleted { get; set; }
        public bool Hidden { get; set; }
        public DateTime LastLoggedOn { get; set; } = DateTime.UtcNow.AddYears(-100);
        public DateTime LastMergedOn { get; set; } = DateTime.UtcNow.AddYears(-100);
        public bool AllowMerge { get; set; } = true;

        public virtual StudioManagerUser OwnerStudioManagerUser { get; set; }
        [JsonIgnore] [IgnoreDataMember] public virtual ICollection<ShareMessage> ShareMessages { get; set; }
    }
}

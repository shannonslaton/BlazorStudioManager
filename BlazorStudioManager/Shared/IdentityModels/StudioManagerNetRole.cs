using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class StudioManagerNetRole : IdentityRole
    {
        public StudioManagerNetRole()
        {
            StudioManagerUserRoles = new HashSet<StudioManagerUserRole>();
            ShareLevels = new HashSet<ShareLevel>();
        }

        public string ShowRoleId { get; set; }
        public string SubscriptionDescription { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal YearlyCost { get; set; }
        public bool ShowRole { get; set; }
        public bool PublicRole { get; set; }
        public string UpgradeDescription { get; set; }
        public string Feature1 { get; set; }
        public string Feature2 { get; set; }
        public string Feature3 { get; set; }
        public string Feature4 { get; set; }
        public string Feature5 { get; set; }
        public string Feature6 { get; set; }
        public string Feature7 { get; set; }

        [JsonIgnore] [IgnoreDataMember] public virtual ICollection<StudioManagerUserRole> StudioManagerUserRoles { get; set; }
        [JsonIgnore] [IgnoreDataMember] public virtual ICollection<ShareLevel> ShareLevels { get; set; }
    }
}

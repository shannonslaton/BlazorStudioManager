using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class StudioManagerUser : IdentityUser
    {
        public StudioManagerUser()
        {
            StudioManagerUserRoles = new HashSet<StudioManagerUserRole>();
            //SharedProductions = new HashSet<SharedProduction>();
            //DisciplineColors = new HashSet<DisciplineColor>();
            //NotificationMessages = new HashSet<NotificationMessage>();
            //ShareLinks = new HashSet<ShareLink>();
        }

        public int? DisciplineId { get; set; }
        public int? ProductionDisciplineId { get; set; }
        public int? ContactId { get; set; }
        public int? ThemeId { get; set; }
        public string FullName { get; set; }
        public int? ProductionId { get; set; }
        public int? SharedProductionId { get; set; }
        public string ProductionAspUserId { get; set; }
        public bool KeepInfoPrivate { get; set; }
        public bool ShowNewUser { get; set; }
        public bool ShowNewFeatures { get; set; }
        public string DatabaseNumber { get; set; }
        public int DiscountPoints { get; set; }
        public bool IsCustomerSupport { get; set; }
        public int CustomerSupportPoints { get; set; }
        public string Url { get; set; }
        public string P256dh { get; set; }
        public string Auth { get; set; }
        public bool FreeTrialEnded { get; set; }

        public virtual Discipline Discipline { get; set; }
        [JsonIgnore] [IgnoreDataMember] public virtual ICollection<StudioManagerUserRole> StudioManagerUserRoles { get; set; }
        //[JsonIgnore] [IgnoreDataMember] public virtual ICollection<SharedProduction> SharedProductions { get; set; }
        //[JsonIgnore] [IgnoreDataMember] public virtual ICollection<DisciplineColor> DisciplineColors { get; set; }
        //[JsonIgnore] [IgnoreDataMember] public virtual ICollection<NotificationMessage> NotificationMessages { get; set; }
        //[JsonIgnore] [IgnoreDataMember] public virtual ICollection<ShareLink> ShareLinks { get; set; }
    }
}

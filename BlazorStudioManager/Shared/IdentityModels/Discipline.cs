using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public partial class Discipline : BaseEntity
    {
        public Discipline()
        {
            StudioManagerUsers = new HashSet<StudioManagerUser>();
        }

        public string DisciplineName { get; set; }
        public string DisciplineNameShort { get; set; }

        [JsonIgnore] [IgnoreDataMember] public virtual ICollection<StudioManagerUser> StudioManagerUsers { get; set; }
    }
}

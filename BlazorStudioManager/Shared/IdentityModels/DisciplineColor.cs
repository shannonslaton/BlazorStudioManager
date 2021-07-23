using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class DisciplineColor
    {
        public virtual int RecId { get; set; }
        public virtual string LastModifiedById { get; set; }
        public virtual DateTime? LastModifiedOnDt { get; set; }
        public virtual bool? Updated { get; set; }
        public virtual string UserId { get; set; }
        public virtual int DisciplineId { get; set; }
        public string ColorString { get; set; }

        public virtual StudioManagerUser StudioManagerUser { get; set; }
    }
}

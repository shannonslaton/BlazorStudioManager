using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class ReportTemplate
    {
        public virtual int RecId { get; set; }
        public virtual int OwnerContactRecId { get; set; }
        public virtual string LastModifiedById { get; set; }
        public virtual DateTime LastModifiedOnDt { get; set; } = DateTime.UtcNow;
        public virtual bool Updated { get; set; } = true;
        public virtual bool Hidden { get; set; } = false;
        public virtual bool Deleted { get; set; } = false;
        public virtual DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public virtual int EditIndex { get; set; } = 0;
        public string ReportTemplateName { get; set; }
        public byte[] Layout { get; set; }
        public bool? Locked { get; set; }
        public string ModelType { get; set; }
        public bool? GlobalLayout { get; set; }
        public int? DisciplineId { get; set; }
        public string LastModifiedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public partial class GridSave
    {
        public virtual int RecId { get; set; }
        public virtual string LastModifiedById { get; set; }
        public virtual DateTime? LastModifiedOnDt { get; set; }
        public virtual bool? Updated { get; set; }
        public string AspUserId { get; set; }
        public string StoreName { get; set; }
        public string GridAllSettings { get; set; }
        //public byte[] GridState { get; set; }

    }
}

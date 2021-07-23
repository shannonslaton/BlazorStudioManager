using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class ShareMessageReply
    {
        public int RecId { get; set; }
        public int LinkId { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime? LastModifiedOnDt { get; set; }
        public bool? Updated { get; set; }

        public DateTime CreatedDate { get; set; }
        public string ReplyFromUserId { get; set; }
        public string ReplyToUserId { get; set; }
        public string ReplySubject { get; set; }
        public string ReplyText { get; set; }

        public virtual ShareMessage ShareMessage { get; set; }
    }
}

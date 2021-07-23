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
    public class ShareMessage
    {
        public ShareMessage()
        {
            ShareMessageReplies = new HashSet<ShareMessageReply>();
        }

        public int RecId { get; set; }
        public int LinkId { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime? LastModifiedOnDt { get; set; }
        public bool? Updated { get; set; }

        public string MessageFromUserId { get; set; }
        public int MessageTypeId { get; set; }
        public int MessageLinkId { get; set; }
        public bool HasBeenRead { get; set; }
        public bool Archived { get; set; }

        public virtual SharedProduction SharedProduction { get; set; }
        [JsonIgnore] [IgnoreDataMember] public virtual ICollection<ShareMessageReply> ShareMessageReplies { get; set; }
    }
}

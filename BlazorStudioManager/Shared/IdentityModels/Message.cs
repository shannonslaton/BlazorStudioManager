using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public partial class Message : BaseEntity
    {
        public Message()
        {

        }

        public int? DisciplineId { get; set; }

        public int? MessageTypeRecId { get; set; }
        public int FromContactRecId { get; set; } = 0;
        public int ToContactRecId { get; set; } = 0;
        public DateTime DateSent { get; set; }
        public bool HasBeenRead { get; set; }
        public bool FromArchive { get; set; }
        public bool FromFlag { get; set; }
        
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }

        public string MessagesImageUrl { get; set; }
        public string MessagesImageFriendlyName { get; set; }
        public string MessagesPdfUrl { get; set; }
        public string MessagesPdfFriendlyName { get; set; }

        public int? CreatedByContactRecId { get; set; }

        public DateTime DateFrom { get; set; }
        public string FromName { get; set; }
        public string ToName { get; set; }
        public string NoteTypeString { get; set; }
        public string Note { get; set; }
        public string RunningOrderWasIn { get; set; }
        public string CueToWasIn { get; set; }
        public string CueFromWasIn { get; set; }
        public string ShowSection { get; set; }
        public string ShowClock { get; set; }
        public string SectionElapsedTime { get; set; }
        public int ReplyId { get; set; } = 0;
        public bool ToArchive { get; set; }
        public bool ToFlag { get; set; }

        public string StudioManagerUserFromId { get; set; } //Note From
        public string StudioManagerUserToId { get; set; } //Note From
        public string ProductionName { get; set; }
        public string FromCompanyMemeberTitle { get; set; }
        public string ToCompanyMemeberTitle { get; set; }

        //public virtual DropDownOption MessageType { get; set; }
        //public virtual Production Production { get; set; }
        //public virtual Contact FromContacts { get; set; }
        //public virtual Contact ToContacts { get; set; }
    }
}

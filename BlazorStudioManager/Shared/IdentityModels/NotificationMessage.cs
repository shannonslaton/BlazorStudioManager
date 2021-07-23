using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class NotificationMessage : BaseEntity
    {
        public string UserId { get; set; }
        public string MessageType { get; set; }
        public string SendMessage { get; set; }
        public string NotificationUrl { get; set; }
        public string SendToEmail { get; set; }
        public bool HasBeenRead { get; set; }
        public bool Archive { get; set; }
        public int ReportId { get; set; }

        public virtual StudioManagerUser StudioManagerUser { get; set; }
    }
}

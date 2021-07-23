using BlazorStudioManager.Shared.IdentityModels;
using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class ShareLink : BaseEntity
    {
        public ShareLink()
        {
            ShareLinkFiles = new HashSet<ShareLinkFile>();
        }

        [Display(Name = "Share Name")]
        public string ShareName { get; set; }
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Status")]
        public bool Enabled { get; set; }
        [Display(Name = "Share Url (Anyone with this link can download these files)")]
        public string ShareLinkUrl { get; set; }
        public string FileTypes { get; set; }
        public string UrlId { get; set; }
        public int OwnerContactRecId { get; set; }
        public string NameOfProduction { get; set; }
        public string StudioManagerUserId { get; set; }
        public int ProductionId { get; set; }

        public virtual StudioManagerUser StudioManagerUser { get; set; }
        [JsonIgnore] [IgnoreDataMember] public virtual ICollection<ShareLinkFile> ShareLinkFiles { get; set; }
    }
}

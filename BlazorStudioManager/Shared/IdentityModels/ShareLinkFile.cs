using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class ShareLinkFile : BaseEntityLink
    {
        public int FileId { get; set; }

        public virtual ShareLink ShareLink { get; set; }
    }
}

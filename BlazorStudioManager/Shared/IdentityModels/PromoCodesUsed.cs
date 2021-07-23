using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public partial class PromoCodesUsed : BaseEntity
    {
        public string StudioManagerUserId { get; set; }
        public DateTime DateUsed { get; set; }
        public string PromoCode { get; set; }
    }
}

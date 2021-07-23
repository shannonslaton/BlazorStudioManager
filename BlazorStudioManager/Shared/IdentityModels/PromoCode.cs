using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public partial class PromoCode : BaseEntity
    {

        [Required]
        public string PromoCodeString { get; set; }
        public int CodeUses { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SubscriptionRoleId { get; set; }
        public int? PurchaseId { get; set; }
        public int PercentDiscount { get; set; }
        public int OwnerContactRecId { get; set; }

    }
}

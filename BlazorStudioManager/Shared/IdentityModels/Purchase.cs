using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public partial class Purchase : BaseEntityOwner
    {
        public DateTime? PurchaseDate { get; set; }
        public string PurchaserEmail { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PurchasePrice { get; set; }
        public string SubscriptionRoleId { get; set; }
        public string UpgradeRenewalGift { get; set; }
        public string PromoCode { get; set; }
        public string TransactionId { get; set; }
    }
}

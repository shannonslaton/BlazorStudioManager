using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class StudioManagerUserRole : IdentityUserRole<string>
    {
        public DateTime? PurchaseDate { get; set; }
        public DateTime? SubscriptionEndDate { get; set; }
        public int RecId { get; set; }
        public string SubscriptionRoleId { get; set; }

        public virtual StudioManagerNetRole Role { get; set; }
        public virtual StudioManagerUser User { get; set; }
    }
}

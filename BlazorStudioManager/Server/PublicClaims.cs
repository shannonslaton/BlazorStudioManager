using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorStudioManager.Server
{
    public class PublicClaims
    {
        public enum AuthenticatedClaimTypes
        {
            PageName = 0,
            UserId = 0
        }

        public void UpsertClaim(AuthenticatedClaimTypes type, string value)
        {
            var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
            var claimsIdentity = ((ClaimsIdentity)identity.Identity);

            var claim = claimsIdentity.Claims.SingleOrDefault(x => x.Type == type.ToString());

            if (!string.IsNullOrEmpty(claim?.Value))
                claimsIdentity.RemoveClaim(claim);

            claimsIdentity.AddClaim(new Claim(type.ToString(), value));
            Thread.CurrentPrincipal = identity;
        }

        public T GetClaim<T>(AuthenticatedClaimTypes type)
        {
            if (!(Thread.CurrentPrincipal?.Identity?.IsAuthenticated).GetValueOrDefault())
                return default(T);

            var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
            var result = identity.Claims.Where(x => x.Type == type.ToString()).Select(x => x.Value).SingleOrDefault();


            try
            {
                return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(result);
            }
            catch (InvalidCastException)
            {
                return default(T);
            }
        }
    }
}

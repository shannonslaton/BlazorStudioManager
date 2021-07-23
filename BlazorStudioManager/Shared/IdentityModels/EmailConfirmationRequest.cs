using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class EmailConfirmationRequest
    {
        public string Email { get; set; }
        public string Token { get; set; }
    }
}

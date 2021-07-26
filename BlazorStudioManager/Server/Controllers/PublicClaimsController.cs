using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorStudioManager.Server.Data;
using BlazorStudioManager.Shared.IdentityModels;
using BlazorStudioManager.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using BlazorStudioManager.Shared;

namespace BlazorStudioManager.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PublicClaimsController : ControllerBase
    {
        private readonly StudioManagerContext _contextUser;
        private readonly StudioManagerIdentityContext _contextIdentity;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<StudioManagerUser> _userManager;

        private bool saveIdentitySuccess;
        private bool saveUserSuccess;
        private int savedUserChangesCount { get; set; } = 0;
        private int savedIdentityChangesCount { get; set; } = 0;
        private StudioManagerUser CurrentUser { get; set; }
        private string GridStoreName { get; set; } = "DeviceAccessories";
        private SharedProduction CurrentSharedProduction { get; set; }

        public PublicClaimsController(StudioManagerContext contextUser, StudioManagerIdentityContext contextIdentity, IHttpContextAccessor httpContextAccessor, UserManager<StudioManagerUser> userManager)
        {
            _contextUser = contextUser;
            _contextIdentity = contextIdentity;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        #region Saves
        async Task GetUserAndProduction()
        {
            CurrentUser = await _contextIdentity.StudioManagerUser.FindAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }
        #endregion

        [HttpGet("{reportType}")]
        public async Task<ActionResult<bool>> SetEnums(string reportType)
        {
            await GetUserAndProduction();

            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                var user = _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result;
                await _userManager.AddClaimAsync(user, new Claim(CustomClaimTypes.PageName.ToString(), reportType));
            }

            return true;
        }
    }
}

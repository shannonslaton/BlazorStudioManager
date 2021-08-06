using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BlazorStudioManager.Server.Data;
using BlazorStudioManager.Shared.IdentityModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using BlazorStudioManager.Shared;
using BlazorStudioManager.Shared.Models;

namespace BlazorStudioManager.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<StudioManagerUser> _userManager;
        private readonly SignInManager<StudioManagerUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly StudioManagerUserContext _contextUser;
        private readonly StudioManagerIdentityContext _contextIdentity;

        private string defaultPersonUrl;
        private string defaultPhotoUrl;

        private string blobConnectionString;

        private bool saveIdentitySuccess;
        private bool saveUserSuccess;
        private int savedUserChangesCount { get; set; } = 0;
        private int savedIdentityChangesCount { get; set; } = 0;
        private IConfiguration _configuration;
        private string userConnectionString;
        private StudioManagerUser CurrentUser { get; set; }

        public AuthController(UserManager<StudioManagerUser> userManager, SignInManager<StudioManagerUser> signInManager,
            StudioManagerUserContext contextUser, StudioManagerIdentityContext contextIdentity, IConfiguration configuration, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _contextUser = contextUser;
            _contextIdentity = contextIdentity;

            _configuration = configuration;

            defaultPersonUrl = "/images/UserIcon.png";
            defaultPhotoUrl = "/images/Picture.png";

            blobConnectionString = _configuration.GetConnectionString("StudioManagerUsersContainer");
        }

        #region Saves
        async Task GetUserAndProduction()
        {
            CurrentUser = await _contextIdentity.StudioManagerUser.FindAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            userConnectionString = _configuration.GetConnectionString("StudioManagerUserConnectionMaster");
            _contextUser.Database.GetDbConnection().ConnectionString = userConnectionString;
        }
        private async Task SaveUserContext()
        {
            try
            {
                savedUserChangesCount = await _contextUser.SaveChangesAsync();

                if (savedUserChangesCount > 0)
                {
                    saveUserSuccess = true;
                }
                else
                {
                    saveUserSuccess = false;
                }
            }
            catch (System.Exception ex)
            {
                var exceptions = ex.ToString();
                throw;
            }
        }
        private async Task SaveIdentityContext()
        {
            try
            {
                savedIdentityChangesCount = await _contextIdentity.SaveChangesAsync();

                if (savedIdentityChangesCount > 0)
                {
                    saveIdentitySuccess = true;
                }
                else
                {
                    saveIdentitySuccess = false;
                }

            }
            catch (System.Exception ex)
            {
                var exceptions = ex.ToString();
                throw;
            }
        }
        #endregion

        #region Authentication
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            CurrentUser = await _userManager.FindByNameAsync(request.UserName);

            if (CurrentUser == null) return BadRequest("User does not exist");

            var singInResult = await _userManager.CheckPasswordAsync(CurrentUser, request.Password);
            if (!singInResult) return BadRequest("Invalid password");

            await _signInManager.SignInAsync(CurrentUser, request.RememberMe);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest parameters)
        {
            var startDate = new DateTime(2021, 4, 15, 00, 01, 00);
            if (DateTime.Now > startDate)
            {
                CurrentUser = new StudioManagerUser();
                CurrentUser.UserName = parameters.Email;
                CurrentUser.Email = parameters.Email;

                var testuserConnectionString = _configuration.GetConnectionString("StudioManagerUserConnectionMaster");
                testuserConnectionString = testuserConnectionString.Replace("StudioManagerBlazorUser", "StudioManagerBlazorUser" + 0);
                _contextUser.Database.GetDbConnection().ConnectionString = testuserConnectionString;

                var userExisting = await _contextIdentity.StudioManagerUser.FirstOrDefaultAsync(c => c.Email == CurrentUser.Email);

                if (userExisting != null)
                {
                    if (userExisting.ProductionId == null)
                    {
                        _contextIdentity.StudioManagerUser.Remove(userExisting);
                        await _contextIdentity.SaveChangesAsync();
                    }
                }

                var result = await _userManager.CreateAsync(CurrentUser, parameters.Password);

                if (result.Succeeded)
                {
                    var roleToAdd = "Gold";

                    if (CurrentUser.Email == "shannonslaton@live.com")
                    {
                        roleToAdd = "Administrator";
                    }

                    var userResult = await _userManager.AddToRoleAsync(CurrentUser, roleToAdd);

                    if (userResult.Succeeded)
                    {
                        await UpdateNewSubscription(CurrentUser.Id, parameters);
                        if (savedUserChangesCount > 0 && savedIdentityChangesCount > 0)
                        {

                            var token = await _userManager.GenerateEmailConfirmationTokenAsync(CurrentUser);
                            token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));
                            var confirmationLink = parameters.BaseUrl + "ConfirmEmail/" + CurrentUser.Email + "/" + token;

                            await _emailSender.SendEmailAsync(parameters.Email, "StudioManager Email Confirmation", $"Please confirm your email by <a href='{HtmlEncoder.Default.Encode(confirmationLink)}'>clicking here</a>.");

                            return await Login(new LoginRequest
                            {
                                UserName = parameters.Email,
                                Password = parameters.Password,
                                IsNewUser = true
                            });
                        }
                        else
                        {
                            return BadRequest(result.Errors.FirstOrDefault()?.Description);
                        }

                    }
                    else
                    {
                        return BadRequest(result.Errors.FirstOrDefault()?.Description);
                    }
                }
                else
                {
                    return BadRequest(result.Errors.FirstOrDefault()?.Description);
                }
            }
            else
            {
                return Ok();
            }
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest request)
        {
            CurrentUser = await _userManager.FindByNameAsync(request.Email);
            if (CurrentUser == null) return BadRequest("User does not exist");

            var token = await _userManager.GeneratePasswordResetTokenAsync(CurrentUser);
            token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));
            var confirmationLink = request.BaseUrl + "ResetPassword/" + CurrentUser.Email + "/" + token;
            await _emailSender.SendEmailAsync(request.Email, "StudioManager Password Reset", $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(confirmationLink)}'>clicking here</a>.");

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmEmail(EmailConfirmationRequest emailConfirmation)
        {
            CurrentUser = await _userManager.FindByNameAsync(emailConfirmation.Email);
            if (CurrentUser == null) return BadRequest("User does not exist");
            emailConfirmation.Token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(emailConfirmation.Token));
            var result = await _userManager.ConfirmEmailAsync(CurrentUser, emailConfirmation.Token);

            if (result.Succeeded)
            {
                return Ok();
                //await _signInManager.SignInAsync(CurrentUser, true);
            }
            else
            {
                return BadRequest("Email Confirmation Failed.  Please contact StudioManager for help.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest parameters)
        {
            CurrentUser = await _userManager.FindByEmailAsync(parameters.Email);
            if (CurrentUser == null)
            {
                return BadRequest("User does not exist.  Please contact support for help.");
            }
            parameters.Token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(parameters.Token));
            var result = await _userManager.ResetPasswordAsync(CurrentUser, parameters.Token, parameters.Password);
            if (result.Succeeded)
            {
                if (CurrentUser == null) return BadRequest("User does not exist");
                var singInResult = await _signInManager.CheckPasswordSignInAsync(CurrentUser, parameters.Password, false);
                if (!singInResult.Succeeded) return BadRequest("Invalid password");
                await _signInManager.SignInAsync(CurrentUser, true);
                return Ok();

            }
            else
            {
                return BadRequest(result.Errors.FirstOrDefault()?.Description);
            }


        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            var userBaseConnectionString = _configuration.GetConnectionString("StudioManagerUserConnectionMasterBase");
            _configuration["ConnectionStrings:StudioManagerUserConnectionMaster"] = userBaseConnectionString;

            return Ok();
        }
        #endregion

        [HttpGet]
        public async Task<ActionResult<List<StudioManagerNetRole>>> GetPricingNetRoles()
        {
            var items = _contextIdentity.StudioManagerNetRole.Where(c => c.PublicRole == true);

            return await items.OrderByDescending(c => c.YearlyCost).ToListAsync();
        }

        [HttpGet]
        public async Task<CurrentUser> GetCurrentUserBasic()
        {
            await Task.Delay(1);

            var currentUser = new CurrentUser
            {
                IsAuthenticated = User.Identity.IsAuthenticated,
                UserName = User.Identity.Name,
                Claims = User.Claims
                .ToDictionary(c => c.Type, c => c.Value)
            };

            return currentUser;
        }

        [HttpGet]
        public async Task<bool> FinalizeLogin()
        {
            await GetUserAndProduction();
            await SaveIdentityContext();

            return true;
        }

        [HttpGet("{GetFull}")]
        public async Task<CurrentUser> GetCurrentUserInfo(bool GetFull)
        {
            await Task.Delay(1);

            var currentUser = new CurrentUser
            {
                IsAuthenticated = User.Identity.IsAuthenticated,
                UserName = User.Identity.Name,
                Claims = User.Claims
                .ToDictionary(c => c.Type, c => c.Value)
            };

            return currentUser;
        }

        #region Register New User
        public async Task<int> UpdateNewSubscription(string userId, RegisterRequest registerViewModel)
        {
            var thisUser = await _contextIdentity.StudioManagerUser.FirstOrDefaultAsync(c => c.Id == userId);
            var numUsersPerDatabase = 10;
            var numUsers = _contextIdentity.StudioManagerUser.Count();

            int numUsersInCurrentDatabase, databaseNumber = Math.DivRem(numUsers, numUsersPerDatabase, out numUsersInCurrentDatabase);

            if (numUsersInCurrentDatabase == 1)
            {
                var numUsersPerPool = 1000;
                int numUsersInCurrentPool, databasePoolNumber = Math.DivRem(numUsers, numUsersPerPool, out numUsersInCurrentPool);
                if (numUsersInCurrentPool == 500)
                {
                    var dbPoolNumberCreate = databasePoolNumber++.ToString();
                    await _emailSender.SendEmailAsync("StudioManager@outlook.com", "Pool Time", "Time to build a pool number " + dbPoolNumberCreate + ".");
                }

                var PoolName = "StudioManagerUsers" + databasePoolNumber;

                if (databasePoolNumber == 0)
                {
                    PoolName = "StudioManagerUsers";
                }

                var dbNumberCreate = (databaseNumber + 1).ToString();
                var connectionString = _configuration.GetConnectionString("StudioManagerUserConnectionMaster");
                var dbMasterName = "StudioManagerBlazorUser (SERVICE_OBJECTIVE = ELASTIC_POOL( name = " + PoolName + " ))";
                var dbCopyName = "StudioManagerBlazorUser" + dbNumberCreate;

                var commandText = "CREATE DATABASE " + dbCopyName + " AS COPY OF " + dbMasterName;
                var conn = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(commandText, conn);
                await command.Connection.OpenAsync();
                command.BeginExecuteNonQuery();
                await Task.Delay(1000); //The database needs this to be created.
                await command.Connection.CloseAsync();
            }

            thisUser.DatabaseNumber = databaseNumber.ToString();

            thisUser.FullName = thisUser.Email;
            thisUser.ThemeId = 6;
            thisUser.PhoneNumber = registerViewModel.PhoneNumber;
            thisUser.ShowNewUser = true;

            var newAspNetUserRole = await _contextIdentity.StudioManagerUserRole.FirstOrDefaultAsync(c => c.UserId == userId);
            var currentRole = await _contextIdentity.StudioManagerNetRole.FirstOrDefaultAsync(c => c.Id == newAspNetUserRole.RoleId);

            var showRoleName = currentRole.ShowRoleId.ToUpper();

            await _userManager.AddToRoleAsync(thisUser, showRoleName);
            await _userManager.RemoveFromRoleAsync(thisUser, currentRole.Name);

            newAspNetUserRole = await _contextIdentity.StudioManagerUserRole.FirstOrDefaultAsync(c => c.UserId == userId);

            newAspNetUserRole.SubscriptionRoleId = currentRole.Id;

            newAspNetUserRole.PurchaseDate = DateTime.UtcNow.Date;

            newAspNetUserRole.SubscriptionEndDate = DateTime.UtcNow.Date.AddDays(7);

            registerViewModel.DisplayName = registerViewModel.FirstName;

            var displayName = registerViewModel.FirstName + " " + registerViewModel.LastName;

            await SaveIdentityContext();

            userConnectionString = _configuration.GetConnectionString("StudioManagerUserConnectionMaster");
            userConnectionString = userConnectionString.Replace("StudioManagerBlazorUser", "StudioManagerBlazorUser" + thisUser.DatabaseNumber);
            _contextUser.Database.GetDbConnection().ConnectionString = userConnectionString;

            await SaveUserContext();
            await SaveIdentityContext();

            if (savedUserChangesCount > 0)
            {
                var currentUser = await (from c in _contextIdentity.StudioManagerUser
                                         where c.Id == userId
                                         select c).FirstOrDefaultAsync();

                var appointmentTypes = from c in _contextIdentity.DefaultAppointmentTypes
                                  select c;

                foreach (var item in appointmentTypes)
                {

                    DropDownOption newItem = new DropDownOption()
                    {
                        LastModifiedOnDt = DateTime.UtcNow,
                        LastModifiedById = currentUser.Id,
                        Color = item.ColorString,
                        DdoTitle = item.AppointmentTypeName,
                        DdoType = "AppointmentTypes",
                        Locked = true
                    };
                    await _contextUser.AddAsync(newItem);
                }


                var dropDownOptionDefaults = _contextIdentity.DropDownOptionDefaults;

                foreach (var dropDownOptionDefault in dropDownOptionDefaults)
                {
                    DropDownOption ddo = new DropDownOption()
                    {
                        DdoAbrv = dropDownOptionDefault.DdoAbrv,
                        DdoTitle = dropDownOptionDefault.DdoTitle,
                        DdoType = dropDownOptionDefault.DdoType,
                        LastModifiedById = currentUser.Id,
                        LastModifiedOnDt = DateTime.UtcNow,
                        DefaultDisciplineId = dropDownOptionDefault.DefaultDisciplineId,
                        DefaultCompanyMemberDepartmentId = dropDownOptionDefault.DefaultCompanyMemberDepartmentId,
                        DefaultProductionDisciplineId = dropDownOptionDefault.DefaultProductionDisciplineId
                    };

                    await _contextUser.AddAsync(ddo);
                }

                var disciplineColorDefaults = _contextIdentity.DisciplineColorDefaults;

                foreach (var disciplineColorDefault in disciplineColorDefaults)
                {
                    DisciplineColor discColor = new DisciplineColor()
                    {
                        LastModifiedById = currentUser.Id,
                        LastModifiedOnDt = DateTime.UtcNow,
                        Updated = true,
                        ColorString = disciplineColorDefault.ColorString,
                        DisciplineId = disciplineColorDefault.DisciplineId,
                        UserId = currentUser.Id
                    };

                    await _contextIdentity.AddAsync(discColor);
                }

                await SaveUserContext();
                await SaveIdentityContext();
            }

            return savedUserChangesCount;
        }

        public async Task<int> GetSubscriptionDaysRemaining(string currentAspUserId)
        {
            var todayDate = DateTime.UtcNow.Date;
            var currentAspUser = await (from c in _contextIdentity.StudioManagerUserRole
                                        where c.UserId == currentAspUserId
                                        select c).FirstOrDefaultAsync();

            TimeSpan remainingTimeSpan = (TimeSpan)(currentAspUser.SubscriptionEndDate - todayDate);
            var numberOfDaysRemiaing = remainingTimeSpan.Days;

            return numberOfDaysRemiaing;

        }
        #endregion

        #region StudioManagerUser
        public async Task<string> GetCurrentUserRoleIdByAspUserId(string currentAspUserId)
        {
            var currentUserRole = await (from c in _contextIdentity.StudioManagerNetRole
                                         join d in _contextIdentity.StudioManagerUserRole on c.Id equals d.RoleId
                                         where d.UserId == currentAspUserId
                                         select c).FirstOrDefaultAsync();

            return currentUserRole.Id;
        }

        public IQueryable<StudioManagerUser> ReadAllUsers()
        {
            return _contextIdentity.StudioManagerUser.OrderBy(c => c.Email);
        }

        public async Task DestroyAspNetUser(StudioManagerUser aspNetUser)
        {
            var deleteThis = await _contextIdentity.StudioManagerUser.FirstOrDefaultAsync(c => c.Id == aspNetUser.Id);

            _contextIdentity.StudioManagerUser.Remove(deleteThis);

            await SaveUserContext();
        }

        public async Task UpdateAspNetUser(StudioManagerUser aspNetUser)
        {
            var oneOfThese = await _contextIdentity.StudioManagerUser.FirstOrDefaultAsync(c => c.Id == aspNetUser.Id);

            oneOfThese.FullName = aspNetUser.FullName;

            await SaveUserContext();
        }

        public async Task<StudioManagerUser> GetAspNetUserByEmail(string Email)
        {
            var item = await _contextIdentity.StudioManagerUser.FirstOrDefaultAsync(c => c.Email == Email);

            return item;
        }

        #endregion

        public async Task<int> GetDefaultDisciplineId(string currentAspUserId)
        {
            var defaultDiscipline = await (from c in _contextIdentity.StudioManagerUser
                                           where c.Id == currentAspUserId
                                           select c).FirstOrDefaultAsync();

            return (int)defaultDiscipline.DisciplineId;
        }

        [HttpGet("{userId}")]
        public async Task<bool> UpdateNewUser(string userId)
        {
            var currentUser = await (from c in _contextIdentity.StudioManagerUser
                                     where c.Id == userId
                                     select c).FirstOrDefaultAsync();

            currentUser.ShowNewUser = false;

            await SaveIdentityContext();
            return saveIdentitySuccess;
        }
        [HttpGet("{userId}")]
        public async Task<bool> UpdateFreeTRial(string userId)
        {
            var currentUser = await (from c in _contextIdentity.StudioManagerUser
                                     where c.Id == userId
                                     select c).FirstOrDefaultAsync();

            currentUser.FreeTrialEnded = false;

            await SaveIdentityContext();
            return saveIdentitySuccess;
        }
        [HttpGet("{userId}")]
        public async Task<bool> UpdateNewFeatures(string userId)
        {
            var currentUser = await (from c in _contextIdentity.StudioManagerUser
                                     where c.Id == userId
                                     select c).FirstOrDefaultAsync();

            currentUser.ShowNewFeatures = false;

            await SaveIdentityContext();
            return saveIdentitySuccess;
        }

        [HttpPut]
        [Authorize(Policy = "Editing")]
        public async Task<ActionResult<StudioManagerUser>> Put(StudioManagerUser CurrentUser)
        {
            _contextIdentity.Entry(CurrentUser).State = EntityState.Modified;

            await SaveIdentityContext();

            return Ok(CurrentUser);
        }

        [HttpGet("{id}")]
        public async Task<bool> UpdateUserCompanyMember(int id)
        {
            await GetUserAndProduction();
            await SaveIdentityContext();

            return true;
        }
    }
}

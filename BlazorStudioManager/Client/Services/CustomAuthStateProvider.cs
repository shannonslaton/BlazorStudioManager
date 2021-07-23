using BlazorStudioManager.Shared;
using BlazorStudioManager.Shared.IdentityModels;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorStudioManager.Client.Services
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        //private readonly IAuthService api;
        private CurrentUser _currentUser;
        //private CurrentUser _loggedInCurrentUser;
        private readonly HttpClient _httpClient;

        public bool GetFull { get; set; } = false;

        public CustomAuthStateProvider(HttpClient httpClient)
        {
            //this.api = api;
            _httpClient = httpClient;


        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            try
            {
                var userInfo = new CurrentUser();

                userInfo = await CustGetCurrentUser(false);

                if (userInfo.IsAuthenticated)
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, _currentUser.UserName) }.Concat(_currentUser.Claims.Select(c => new Claim(c.Key, c.Value)));
                    identity = new ClaimsIdentity(claims, "Server authentication");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Request failed:" + ex.ToString());
            }

            return new AuthenticationState(new ClaimsPrincipal(identity));
        }

        public async Task<CurrentUser> CustGetCurrentUser(bool GetFull)
        {
            if (_currentUser != null && _currentUser.IsAuthenticated)
            {
                return _currentUser;
            }

            _currentUser = await _httpClient.GetFromJsonAsync<CurrentUser>("api/auth/GetCurrentUserInfo/" + GetFull);
            return _currentUser;
        }

        public async Task<int> MergeDropDownOptions()
        {
            var IsComplete = await _httpClient.GetFromJsonAsync<bool>("api/auth/MergeDropDownOptions");

            if (IsComplete)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public async Task<int> MergeContacts()
        {
            var IsComplete = await _httpClient.GetFromJsonAsync<bool>("api/auth/MergeContacts");
            if (IsComplete)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        public async Task<int> MergeContactSubs()
        {
            var IsComplete = await _httpClient.GetFromJsonAsync<bool>("api/auth/MergeContactSubs");
            if (IsComplete)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }
        public async Task<int> MergeCatalogItems()
        {
            var IsComplete = await _httpClient.GetFromJsonAsync<bool>("api/auth/MergeCatalogItems");
            if (IsComplete)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
        public async Task<int> MergeCatalogItemSubs()
        {
            var IsComplete = await _httpClient.GetFromJsonAsync<bool>("api/auth/MergeCatalogItemSubs");
            if (IsComplete)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }
        public async Task<int> FinalizeLogin()
        {
            var IsComplete = await _httpClient.GetFromJsonAsync<bool>("api/auth/FinalizeLogin");
            if (IsComplete)
            {
                return 6;
            }
            else
            {
                return 0;
            }
        }

        //public async Task<CurrentUser> CustGetFullCurrentUser(bool GetFull)
        //{
        //    if (_currentUser != null && _currentUser.IsAuthenticated)
        //    {
        //        return _currentUser;
        //    }

        //    _currentUser = await _httpClient.GetFromJsonAsync<CurrentUser>("api/auth/GetCurrentUserInfo/" + true);
        //    return _currentUser;
        //}

        public async Task Logout()
        {
            var result = await _httpClient.PostAsync("api/auth/logout", null);
            result.EnsureSuccessStatusCode();
            _currentUser = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task Login(LoginRequest loginParameters)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/login", loginParameters);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task Register(RegisterRequest registerParameters)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/register", registerParameters);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task ForgotPassword(ForgotPasswordRequest forgotPasswordParameters)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/ForgotPassword", forgotPasswordParameters);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task ConfirmEmail(EmailConfirmationRequest emailConfirmation)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/ConfirmEmail", emailConfirmation);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task ResetPassword(ResetPasswordRequest resetPasswordParameters)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/ResetPassword", resetPasswordParameters);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public async Task UpdateNewUser(string userId)
        {
            await _httpClient.GetFromJsonAsync<bool>("api/auth/UpdateNewUser/" + userId);
        }

        public async Task UpdateNewFeatures(string userId)
        {
            await _httpClient.GetFromJsonAsync<bool>("api/auth/UpdateNewFeatures/" + userId);
        }
    }
}

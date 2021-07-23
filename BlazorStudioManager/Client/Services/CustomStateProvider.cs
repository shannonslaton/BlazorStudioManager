//using Microsoft.AspNetCore.Components.Authorization;
//using BlazorStudioManager.Shared.IdentityModels;
//using BlazorStudioManager.Shared.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Net.Http.Json;
//using System.Security.Claims;
//using System.Threading.Tasks;

//namespace BlazorStudioManager.Client.Services
//{
//    public class CustomStateProvider : AuthenticationStateProvider
//    {
//        private readonly IAuthService api;
//        private CurrentUser _currentUser;
//        //private readonly HttpClient _httpClient;

//        public CustomStateProvider(IAuthService api, HttpClient httpClient)
//        {
//            this.api = api;
//            _httpClient = httpClient;
//        }
//        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
//        {
//            var identity = new ClaimsIdentity();
//            try
//            {
//                var userInfo = await _httpClient.GetFromJsonAsync<CurrentUser>("api/auth/currentuserinfo");
//                //return result;

//                var userInfo = await GetCurrentUser();
//                if (userInfo.IsAuthenticated)
//                {
//                    var claims = new[] { new Claim(ClaimTypes.Name, _currentUser.UserName) }.Concat(_currentUser.Claims.Select(c => new Claim(c.Key, c.Value)));
//                    identity = new ClaimsIdentity(claims, "Server authentication");
//                }
//            }
//            catch (HttpRequestException ex)
//            {
//                Console.WriteLine("Request failed:" + ex.ToString());
//            }

//            return new AuthenticationState(new ClaimsPrincipal(identity));
//        }

//        //public async Task<CurrentUser> GetCurrentUser()
//        //{
//        //    if (_currentUser != null && _currentUser.IsAuthenticated)
//        //    {
//        //        return _currentUser;
//        //    }

//        //    _currentUser = await api.CurrentUserInfo();
//        //    return _currentUser;
//        //}
//    }
//}

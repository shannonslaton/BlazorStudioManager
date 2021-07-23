using BlazorStudioManager.Shared;
using BlazorStudioManager.Shared.IdentityModels;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorStudioManager.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CurrentUser> AuthGetCurrentUserInfo()
        {
            var user = await _httpClient.GetFromJsonAsync<CurrentUser>("api/auth/GetCurrentUserInfo");
            //return new AuthenticationState(user);

            //var result = await _httpClient.GetFromJsonAsync<CurrentUser>("api/auth/currentuserinfo");
            return user;
        }

        public async Task<CurrentUser> AuthGetFullCurrentUserInfo()
        {
            var user = await _httpClient.GetFromJsonAsync<CurrentUser>("api/auth/GetFullCurrentUserInfo");
            //return new AuthenticationState(user);

            //var result = await _httpClient.GetFromJsonAsync<CurrentUser>("api/auth/currentuserinfo");
            return user;
        }

        public async Task Login(LoginRequest loginRequest)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/login", loginRequest);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

        public async Task Logout()
        {
            var result = await _httpClient.PostAsync("api/auth/logout", null);
            result.EnsureSuccessStatusCode();
        }

        public async Task Register(RegisterRequest registerRequest)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/register", registerRequest);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

        public async Task<bool> UpdateNewUser(string userId)
        {
            return await _httpClient.GetFromJsonAsync<bool>("api/auth/updatenewuser/" + userId);
        }
        public async Task<bool> UpdateFreeTrial(string userId)
        {
            return await _httpClient.GetFromJsonAsync<bool>("api/auth/UpdateFreeTrial/" + userId);
        }
        public async Task<bool> UpdateNewFeatures(string userId)
        {
            return await _httpClient.GetFromJsonAsync<bool>("api/auth/updatenewfeatures/" + userId);
        }

        public async Task ConfirmEmail(EmailConfirmationRequest emailConfirmation)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/confirmemail", emailConfirmation);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

        public async Task ResetPassword(ResetPasswordRequest resetPasswordRequest)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/resetpassword", resetPasswordRequest);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

        public async Task ForgotPassword(ForgotPasswordRequest forgotPasswordRequest)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/forgotpassword", forgotPasswordRequest);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

    }
}

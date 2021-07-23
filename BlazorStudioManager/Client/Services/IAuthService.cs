using BlazorStudioManager.Shared;
using BlazorStudioManager.Shared.IdentityModels;
using System.Threading.Tasks;

namespace BlazorStudioManager.Client.Services
{
    public interface IAuthService
    {
        Task Login(LoginRequest loginRequest);
        Task ForgotPassword(ForgotPasswordRequest forgotPasswordRequest);
        Task Register(RegisterRequest registerRequest);
        Task ConfirmEmail(EmailConfirmationRequest emailConfirmation);
        Task ResetPassword(ResetPasswordRequest resetPasswordRequest);
        Task Logout();
        Task<CurrentUser> AuthGetCurrentUserInfo();
        Task<CurrentUser> AuthGetFullCurrentUserInfo();
        Task<bool> UpdateFreeTrial(string userId);
        Task<bool> UpdateNewUser(string userId);
        Task<bool> UpdateNewFeatures(string userId);
    }
}

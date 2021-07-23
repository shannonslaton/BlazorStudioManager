using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;

namespace BlazorStudioManager.Server.Services
{
    public class AKVService
    {
        public string GetKeyVaultSecret(string secretName)
        {
            var azureServiceTokenProvider1 = new AzureServiceTokenProvider();
            var kv = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider1.KeyVaultTokenCallback));
            var secret = kv.GetSecretAsync(secretName).Result;
            return secret.Value;
        }
    }
}
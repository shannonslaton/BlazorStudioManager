using BlazorStudioManager.Client;
using BlazorStudioManager.Client.Services;
using BlazorStudioManager.Shared.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Telerik.Blazor.Services;
using Azure.Identity;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Azure.KeyVault;
using Microsoft.Extensions.Configuration.AzureKeyVault;

namespace BlazorStudioManager.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {

                var keyVaultEndpoint = GetKeyVaultEndpoint();
                if (!string.IsNullOrEmpty(keyVaultEndpoint))
                {
                    var azureServiceTokenProvider = new AzureServiceTokenProvider();
                    var keyVaultClient = new KeyVaultClient(
                        new KeyVaultClient.AuthenticationCallback(
                            azureServiceTokenProvider.KeyVaultTokenCallback));
                    //builder.AddAzureKeyVault(new Uri("https://showbuilder.vault.azure.net/"), new DefaultAzureCredential());
                    config.AddAzureKeyVault(
                        keyVaultEndpoint, keyVaultClient, new DefaultKeyVaultSecretManager());
                }
            })
                //.ConfigureAppConfiguration((context, config) =>
                //{
                //    var keyVaultEndpoint = new Uri(Environment.GetEnvironmentVariable("VaultUri"));
                //    config.AddAzureKeyVault(
                //    keyVaultEndpoint,
                //    new DefaultAzureCredential());
                //})
                //.ConfigureAppConfiguration((context, config) =>
                //{
                //    var keyVaultEndpoint = new Uri(Environment.GetEnvironmentVariable("VaultUri"));
                //    config.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());
                //})
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static string GetKeyVaultEndpoint() => "https://pilatesstudiomanager.vault.azure.net/";
    }
}

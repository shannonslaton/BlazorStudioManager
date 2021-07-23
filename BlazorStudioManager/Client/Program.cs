using BlazorStudioManager.Client.Services;
using BlazorStudioManager.Shared.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using Telerik.Blazor.Services;

namespace BlazorStudioManager.Client
{
    public class Program
    {
   //     public static async Task Main(string[] args)
   //     {
   //         var builder = WebAssemblyHostBuilder.CreateDefault(args);
   //         builder.RootComponents.Add<App>("#app");
			//builder.Services.AddTelerikBlazor();

   //         builder.Services.AddHttpClient("BlazorStudioManager.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
   //             .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

   //         // Supply HttpClient instances that include access tokens when making requests to the server project
   //         builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BlazorStudioManager.ServerAPI"));

   //         builder.Services.AddApiAuthorization();

   //         await builder.Build().RunAsync();
   //     }

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<CustomAuthStateProvider>();
            builder.Services.AddScoped<IStudioManagerService, StudioManagerService>();
            builder.Services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<CustomAuthStateProvider>());
            //builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<BrowserResizeService>();
            builder.Services.AddScoped<TimeZoneService>();

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddTelerikBlazor();

            // register a custom localizer for the Telerik components, after registering the Telerik services
            builder.Services.AddSingleton(typeof(ITelerikStringLocalizer), typeof(SampleResxLocalizer));

            var host = builder.Build();
            await SetCultureAsync(host);

            await host.RunAsync();
        }

        // based on https://github.com/pranavkm/LocSample
        private static async Task SetCultureAsync(WebAssemblyHost host)
        {
            var jsRuntime = host.Services.GetRequiredService<IJSRuntime>();
            var cultureName = await jsRuntime.InvokeAsync<string>("blazorCulture.get");

            if (cultureName != null)
            {
                var culture = new CultureInfo(cultureName);

                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;
            }
        }
    }
}

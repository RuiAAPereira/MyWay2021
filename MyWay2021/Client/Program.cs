using Blazored.Toast;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using MyWay2021.Client.Services;
using MyWay2021.Client.Shared;
using Syncfusion.Blazor;
using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyWay2021.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //Register Syncfusion license 
            Syncfusion.Licensing.SyncfusionLicenseProvider
                .RegisterLicense("NDkxMzUwQDMxMzkyZTMyMmUzMFZLamVNWC9tZXJXaVltSlNnN3BqNDhsMFlnVWZRNjNBTnIyR1lJbnAzb1k9");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("app");

            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AppStateProvider>();
            builder.Services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<AppStateProvider>());
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddBlazoredToast();

            #region Localization
            // Register the Syncfusion locale service to customize the  SyncfusionBlazor component locale culture
            builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));

            // Set the default culture of the application
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-PT");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("pt-PT");

            // Get the modified culture from culture switcher
            var host = builder.Build();
            var jsInterop = host.Services.GetRequiredService<IJSRuntime>();
            var result = await jsInterop.InvokeAsync<string>("cultureInfo.get");
            if (result != null)
            {
                // Set the culture from culture switcher
                var culture = new CultureInfo(result);
                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;
            }
            #endregion

            await host.RunAsync();
        }
    }
}

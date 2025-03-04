using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using TelephonyUI.Services;
using TelephonyUI.Services.Interfaces;

namespace TelephonyUI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //Added Services:
            builder.Services.AddRadzenComponents();
			builder.Services.AddScoped<IDataExportService, DataExportService>();
			builder.Services.AddSingleton<CallService>();
			builder.Services.AddScoped<DialPadService>();
			builder.Services.AddScoped(sp => new HttpClient
			{
				BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
			});
			
			await builder.Build().RunAsync();
        }
    }
}

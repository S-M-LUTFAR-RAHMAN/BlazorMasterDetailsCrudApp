using BlazorMasterDetailsCrudApp.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorMasterDetailsCrudApp.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


            builder.Services.AddScoped<CategoryService>();


            await builder.Build().RunAsync();
        }
    }
}

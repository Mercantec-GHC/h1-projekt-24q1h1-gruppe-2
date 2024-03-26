using BlazorApp.Components;
using Domain_Models;
namespace BlazorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<List<Sound>>(sp => new Itemdata().GenerateItemDataItems());

            //GetAllSounds from Postgres DB
            IConfiguration Configuration = builder.Configuration;
            string connectionString = Configuration.GetConnectionString("DefaultConnection") ?? Environment.GetEnvironmentVariables("DefaultConnection");
            builder.Services.AddSingleton<List<Sound>>(sp =>new DataBaseServive(connectionString).GetAllVehicles());

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}

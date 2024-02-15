using DomaineLayer.Model;
using DomaineLayer.Service;
using DomaineLayer.Service.Interface;
using TrainingApiBlizzard.Service;

namespace TrainingApiBlizzard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddHttpClient("DiabloClient", client =>
            {
                client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("BlizzardSetting:UrlBaseDiablo"));
            })
            .AddHttpMessageHandler<AuthHandler>();
            builder.Services.AddScoped<ITokenProvider, TokenProvider>();
            builder.Services.AddScoped<AuthHandler>();
            builder.Services.AddSingleton<IDataBaseService, DataBaseService>();

            var app = builder.Build();
            var dataBaseService = app.Services.GetRequiredService<IDataBaseService>();

            dataBaseService.seedData();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}
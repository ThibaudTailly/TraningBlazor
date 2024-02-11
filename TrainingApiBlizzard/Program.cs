using DataLayer.Service;
using DataLayer.Service.Interface;
using DomaineLayer.Model;
using TrainingApiBlizzard.Service;

namespace TrainingApiBlizzard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
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
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
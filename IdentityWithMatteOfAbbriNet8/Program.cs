using IdentityWithMatteOfAbbriNet8.Components;
using AspNetCore.Identity.Mongo;
using AspNetCore.Identity.Mongo.Model;
using IdentityWithMatteOfAbbriNet8.Data;
using IdentityWithMatteOfAbbriNet8.Data.Models;

namespace IdentityWithMatteOfAbbriNet8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            MongoDbConfig? mongoDbConfig = builder.Configuration.GetSection(nameof(MongoDbConfig)).Get<MongoDbConfig>();

            // builder.Services.AddIdentityMongoDbProvider<SiteUser>(
            // builder.Services.AddIdentityMongoDbProvider<MongoUser>(
            builder.Services.AddIdentityMongoDbProvider<SiteUser>(
                mongo =>
                {
                    mongo.ConnectionString = mongoDbConfig!.ConnectionString;
                }
                );


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

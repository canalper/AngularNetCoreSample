using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularNetCoreSample.Repository;
using AngularNetCoreSample.Repository.Interfaces;
using AngularNetCoreSample.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace YoneticiWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();
            services.AddMemoryCache();


            services.AddSingleton<IAnnualApplicationCountRepository, AnnualApplicationCountRepository>();
            services.AddSingleton<ITopClaimTopicRepository, TopClaimTopicRepository>();
            services.AddSingleton<IApplicationStatusRepository, ApplicationStatusRepository>();
            services.AddSingleton<ICallTurningIntoApplicationRepository, CallTurningIntoApplicationRepository>();

            services.AddSingleton<IAnnualApplicationCountService, AnnualApplicationCountService>();
            services.AddSingleton<ITopClaimTopicService, TopClaimTopicService>();
            services.AddSingleton<IApplicationStatusService, ApplicationStatusService>();
            services.AddSingleton<ICallTurningIntoApplicationService, CallTurningIntoApplicationService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());


            app.UseWhen(x => !x.Request.Path.Value.StartsWith("/api"), builder =>
            {
                builder.Use(async (context, next) =>
                {
                    await next();
                    if (context.Response.StatusCode == 404 && !Path.HasExtension(context.Request.Path.Value))
                    {
                        context.Request.Path = "/index.html";
                        await next();
                    }
                })
                    .UseDefaultFiles(new DefaultFilesOptions { DefaultFileNames = new List<string> { "index.html" } })
                    .UseStaticFiles();
            });

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            IList<CultureInfo> supportedCultures = new List<CultureInfo>
            {
                new CultureInfo("tr-TR")
            };
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("tr-TR"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

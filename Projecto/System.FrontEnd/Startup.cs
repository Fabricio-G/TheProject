using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Filters;

namespace System.FrontEnd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
     
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // para que tome la IP del x-forwarded-for
            var forwardingOptions = new ForwardedHeadersOptions()
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            };
            forwardingOptions.KnownNetworks.Clear();
            forwardingOptions.KnownProxies.Clear();
            app.UseForwardedHeaders(forwardingOptions);

            //Logger de core + serilog
            Log.Logger = new LoggerConfiguration().ReadFrom.ConfigurationSection(Configuration.GetSection("Serilog")).Filter.ByExcluding(Matching.FromSource("Microsoft")).Filter.ByExcluding(Matching.FromSource("System")).CreateLogger();
            loggerFactory.AddSerilog(Log.Logger);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

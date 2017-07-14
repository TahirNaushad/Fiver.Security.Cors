using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Fiver.Security.Cors
{
    public class Startup
    {
        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("fiver",
                    policy => policy.WithOrigins("http://localhost:21314"));
            });

            services.AddMvc();
            //services.AddMvc(options =>
            //{
            //    options.Filters.Add(new CorsAuthorizationFilterFactory("fiver"));
            //});
        }

        public void Configure
            (IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
            //app.UseCors("fiver");

            app.UseMvcWithDefaultRoute();
        }
    }
}

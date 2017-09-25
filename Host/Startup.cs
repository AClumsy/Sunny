using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Sunny.Transport;
using Sunny.Transport.UpstreamTransport;
using Sunny.Services;
using Sunny.Services.SunnyCore;
using Sunny.Transport.UpstreamProtocolAdaptation;

namespace Host
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ISunnyCoreService, DefaultSunnyCoreService>();
            services.AddTransient<HttpUpstreamProtocolAdaptation>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            Sunny.Configuration.ServiceProvider.Instance = app.ApplicationServices;
            app.UseMiddleware<HttpUpstreamTransport>();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

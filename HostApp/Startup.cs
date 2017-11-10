using Sunny.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Sunny.Application;

namespace HostApp
{
    public class Startup : IStartup
    {
        public void Configure(ISunnyApplicationBuilder app)
        {
            app.UseClientServices();
            Func<RequestDelegate, RequestDelegate> middleware = next =>
            {
                return context =>
                {
                   
                    return next(context);
                };
            };

            app.Use(middleware);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Sunny.Application;
using Autofac;
using Microsoft.Extensions.Logging;

namespace Host
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddSunny();
            services.AddLogging(builder=>
            {
                builder.AddFilter("Microsoft", LogLevel.Information);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            app.RunSunny();

            app.Run((context) =>
            {
                return context.Response.WriteAsync("测试");
            });
        }
    }
}

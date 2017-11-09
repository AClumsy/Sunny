using Microsoft.Extensions.DependencyInjection;
using Sunny.Application;
using Sunny.Configuration;
using Sunny.Hosting.AspNetCoreServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    ///  Pipeline extension methods for adding Sunny
    /// </summary>
    public static class SunnyApplicationBuilderExtensions
    {
        /// <summary>
        /// Adds Sunny to the pipeline.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <returns></returns>
        public static IApplicationBuilder UseSunny(this IApplicationBuilder app, Action<ISunnyApplicationBuilder> configureApp)
        {
            app.UseMiddleware<SunnyMiddleware>();

            //Get the ISunnyApplicationBuilder
            var builderFactory = app.ApplicationServices.GetRequiredService<ISunnyApplicationBuilderFactory>();
            ISunnyApplicationBuilder applicationBuilder = builderFactory.CreateBuilder();

            if (configureApp != null)
                configureApp(applicationBuilder);


            //Building SunnyApplication
            var sunnyContextFactory = app.ApplicationServices.GetRequiredService<ISunnyContextFactory>();
            var sunnyApplication = applicationBuilder.Build();
            var sunnyApp = new DefaultSunnyApplication(sunnyApplication, sunnyContextFactory);

            return app;
        }

        public static IApplicationBuilder UseSunny(this IApplicationBuilder app)
        {
            return app.UseSunny((build) =>
             {

             });
        }
    }
}

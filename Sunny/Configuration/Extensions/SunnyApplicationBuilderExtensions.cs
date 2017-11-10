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
            var sunnyApp = BuilderSunnyApplication(app, configureApp);
            app.UseMiddleware<SunnyMiddleware>(sunnyApp);
            return app;
        }

        public static IApplicationBuilder UseSunny(this IApplicationBuilder app)
        {
            return app.UseSunny((build) =>
            {
                build.UseSunnyService();
            });
        }

      
        private static DefaultSunnyApplication BuilderSunnyApplication(this IApplicationBuilder app, Action<ISunnyApplicationBuilder> configureApp)
        {

            //Get the ISunnyApplicationBuilder
            var builderFactory = app.ApplicationServices.GetRequiredService<ISunnyApplicationBuilderFactory>();
            ISunnyApplicationBuilder applicationBuilder = builderFactory.CreateBuilder();

            configureApp?.Invoke(applicationBuilder);

            //Building SunnyApplication
            var sunnyContextFactory = app.ApplicationServices.GetRequiredService<ISunnyContextFactory>();
            var sunnyApplication = applicationBuilder.Build();
            return new DefaultSunnyApplication(sunnyApplication, sunnyContextFactory);
        }
    }
}

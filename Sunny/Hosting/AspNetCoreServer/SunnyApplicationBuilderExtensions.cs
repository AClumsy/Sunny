using Sunny.Configuration;
using Sunny.Hosting.Server.AspNetCoreServer;
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
        public static IApplicationBuilder UseSunny(this IApplicationBuilder app)
        {

            app.UseMiddleware<SunnyMiddleware>();
            return app;
        }
    }
}

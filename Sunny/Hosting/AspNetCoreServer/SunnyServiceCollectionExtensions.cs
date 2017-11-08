using Sunny.Configuration;
using Sunny.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// DI extension methods for adding Sunny
    /// </summary>
    public static class SunnyServiceCollectionExtensions
    {
        /// <summary>
        /// Creates a builder.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static ISunnyBuilder AddSunnyBuilder(this IServiceCollection services)
        {
            return new DefaultSunnyBuilder(services);
        }

        /// <summary>
        /// Adds Sunny.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static ISunnyBuilder AddSunny(this IServiceCollection services)
        {
            var builder = services.AddSunnyBuilder();
            builder
                .AddServices();

            return builder;
        }

    }
}

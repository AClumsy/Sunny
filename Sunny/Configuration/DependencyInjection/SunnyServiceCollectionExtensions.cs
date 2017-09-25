using Sunny.Configuration;
using Sunny.Services;
using Sunny.Services.SunnyCore;
using Sunny.Transport;
using Sunny.Transport.UpstreamProtocolAdaptation;
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
            return new SunnyBuilder(services);
        }

        /// <summary>
        /// Adds IdentityServer.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static ISunnyBuilder AddSunny(this IServiceCollection services)
        {
            var builder = services.AddSunnyBuilder();

            builder.Services.AddTransient<ISunnyCoreService, DefaultSunnyCoreService>();
            builder.Services.AddTransient<IUpstreamProtocolAdaptation, HttpUpstreamProtocolAdaptation>();

            return new SunnyBuilder(services);
        }

    }
}

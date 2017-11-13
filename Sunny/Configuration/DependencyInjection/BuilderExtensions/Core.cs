using System;
using System.Collections.Generic;
using System.Text;
using Sunny.Application;
using Sunny.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// SunnyBuilder DI 扩展 
    /// </summary>
    public static class SunnyBuilderExtensionsCore
    {
        /// <summary>
        /// 添加Application服务
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static ISunnyBuilder AddCore(this ISunnyBuilder builder)
        {
            builder.Services.AddTransient<ISunnyApplicationBuilderFactory, DefaultSunnyApplicationBuilderFactory>();
            builder.Services.AddTransient<ISunnyContextFactory, DefaultSunnyContextFactory>();
            builder.Services.AddTransient<ISunnyServiceFactory, DefaultSunnyServiceFactory>();
            return builder;
        }
    }
}

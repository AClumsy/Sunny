using System;
using System.Collections.Generic;
using System.Text;
using Sunny.Services;
using Sunny.Services.Exception;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SunnyBuilderExtensionsService
    {
        
        /// <summary>
        /// 添加异常处理服务
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static ISunnyBuilder AddException(this ISunnyBuilder builder)
        {
            builder.Services.AddTransient<IExceptionService, DefaultExceptionService>();
            return builder;
        }
    }
}

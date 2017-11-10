using System;
using System.Collections.Generic;
using System.Text;
using Sunny.Services;

namespace Sunny.Application
{
    public static class UseSunnyServiceExtensions
    {
        public static ISunnyApplicationBuilder UseSunnyService(this ISunnyApplicationBuilder builder)
        {
            builder.UseExceptionService();//Exception Handling
            return builder;
        }

        public static ISunnyApplicationBuilder UseExceptionService(this ISunnyApplicationBuilder builder)
        {
            builder.UseService<IExceptionService>();
            return builder;
        }
    }
}

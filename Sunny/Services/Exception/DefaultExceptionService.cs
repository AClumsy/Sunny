using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Sunny.Application;
using Microsoft.Extensions.Logging;

namespace Sunny.Services.Exception
{
    public class DefaultExceptionService : IExceptionService
    {
        public async Task InvokeAsync(SunnyContext context, RequestDelegate next)
        {
            byte[] buffer = Encoding.UTF8.GetBytes("Sunny run successfully");
            await context.Response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
            await next(context);
        }
    }
}

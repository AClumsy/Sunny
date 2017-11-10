using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Sunny.Application;

namespace Sunny.Services.Exception
{
    public class DefaultExceptionService : IExceptionService
    {
        public async Task InvokeAsync(SunnyContext context, RequestDelegate next)
        {
            byte[] buffer = Encoding.UTF8.GetBytes("abc");
            await context.Response.OutputStream.WriteAsync(buffer,0, buffer.Length);
        }
    }
}

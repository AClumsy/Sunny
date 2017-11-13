using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sunny.Application;

namespace Sunny.Services.ServiceDiscovery
{
    public class DefaultServiceDiscoveryService : IServiceDiscoveryService
    {
        public async Task InvokeAsync(SunnyContext context, RequestDelegate next)
        {
            byte[] buffer = Encoding.UTF8.GetBytes("\r\nDefaultServiceDiscoveryService Get successfully");
            await context.Response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
        }
    }
}

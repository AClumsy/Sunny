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
        private readonly ILogger _logger;
        public DefaultExceptionService(ILogger<DefaultExceptionService> logger)
        {
            this._logger = logger;
         
        }
        public async Task InvokeAsync(SunnyContext context, RequestDelegate next)
        {

            this._logger.LogTrace("LogTrace");
            this._logger.LogDebug("LogDebug");
            this._logger.LogInformation("LogInformation");
            this._logger.LogWarning("LogWarning");
            this._logger.LogError("LogError");
            this._logger.LogCritical("LogCritical");
            byte[] buffer = Encoding.UTF8.GetBytes("Sunny run successfully");
            await context.Response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
            await next(context);
        }
    }
}

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sunny.Services;
using Sunny.Configuration;

namespace Sunny.Hosting.Http
{
    /// <summary>
    /// 上游通信 
    /// </summary>
    public class HttpHosting : ISunnyHosting
    {
        private readonly SunnyRequestDelegate _sunnyRequest;
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;
        public HttpHosting(RequestDelegate next, ILogger<HttpHosting> logger, SunnyRequestDelegate sunnyRequest)
        {
            this._sunnyRequest = sunnyRequest;
            this._logger = logger;
            this._next = next;
        }

        /// <summary>
        /// Invokes the middleware.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context)
        {
            SunnyContext sc = null;
            await this._sunnyRequest(sc);
            await _next(context);
        }

    }
}

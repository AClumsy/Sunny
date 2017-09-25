using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Sunny.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Sunny.Abstractions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Sunny.Configuration;

namespace Sunny.Transport.UpstreamTransport
{
    /// <summary>
    /// 上游通信 
    /// </summary>
    public class HttpUpstreamTransport : IUpstreamTransport
    {
        private readonly ISunnyCoreService _sunnyCore;
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;
        public HttpUpstreamTransport(RequestDelegate next, ILogger<HttpUpstreamTransport> logger, ISunnyCoreService handler)
        {
            this._sunnyCore = handler;
            this._logger = logger;
            this._next = next;
        }

        /// <summary>
        /// Invokes the middleware.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
           await this._sunnyCore.ProcessAsync(null);
            await _next(context);
        }
      
    }
}

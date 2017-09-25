using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sunny.Services;
using Sunny.Abstractions;
using Sunny.Configuration;
using Sunny.Transport.UpstreamProtocolAdaptation;

namespace Sunny.Transport.UpstreamTransport
{
    /// <summary>
    /// 上游通信 
    /// </summary>
    public class HttpUpstreamTransport : IUpstreamTransport
    {
        private readonly ISunnyCoreService _coreService;
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;
        private readonly IUpstreamProtocolAdaptation _protocolAdaptation;
        public HttpUpstreamTransport(RequestDelegate next, ILogger<HttpUpstreamTransport> logger, ISunnyCoreService coreService)
        {
            this._coreService = coreService;
            this._logger = logger;
            this._next = next;
            this._protocolAdaptation = ServiceProvider.Instance.GetService<IUpstreamProtocolAdaptation>();
        }

        /// <summary>
        /// Invokes the middleware.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context)
        {
            await this._coreService.ProcessAsync(null);
            await _next(context);
        }

    }
}

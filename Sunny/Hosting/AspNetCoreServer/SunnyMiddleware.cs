using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Sunny.Application;
using Sunny.Application.FeatureCollection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sunny.Hosting.AspNetCoreServer
{
    public class SunnyMiddleware
    {
        private readonly Microsoft.AspNetCore.Http.RequestDelegate _next;
        private readonly ILogger _logger;
        private readonly IFeatureCollection features;
        private readonly ISunnyApplication<SunnyContext> application;
        /// <summary> 
        /// Initializes a new instance of the <see cref="SunnyMiddleware"/> class.
        /// </summary>
        /// <param name="next">The next.</param>
        /// <param name="logger">The logger.</param>
        public SunnyMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next, ILogger<SunnyMiddleware> logger,
            ISunnyApplication<SunnyContext> _application)
        {
            this._next = next;
            this._logger = logger;
            this.features = new DefaultFeatureCollection();
            this.application = _application;
        }

        /// <summary>
        /// Invokes the middleware.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="router">The router.</param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
            AspNetCoreServerFeature feature = new AspNetCoreServerFeature(context);
            this.features.Set<ISunnyRequestFeature>(feature);
            this.features.Set<ISunnyResponseFeature>(feature);

            SunnyContext sunnyContext = this.application.CreateContext(this.features);
            await this.application.ProcessRequestAsync(sunnyContext)
                .ContinueWith(_ => application.DisposeContext(sunnyContext, _.Exception));
            await _next(context);
        }
    }
}

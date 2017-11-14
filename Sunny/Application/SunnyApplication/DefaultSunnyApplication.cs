using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Sunny.Application
{
    public class DefaultSunnyApplication : ISunnyApplication<DefaultSunnyApplication.Context>
    {
        private readonly RequestDelegate _application;
        private readonly ISunnyContextFactory _sunnyContextFactory;

        public DefaultSunnyApplication(RequestDelegate application, ISunnyContextFactory sunnyContextFactory)
        {
            this._application = application;
            this._sunnyContextFactory = sunnyContextFactory;
        }

        public Context CreateContext(IFeatureCollection contextFeatures)
        {
            var context = new Context
            {
                SunnyContext = _sunnyContextFactory.Create(contextFeatures)
            };
            return context;
        }

        public void DisposeContext(Context context, Exception exception)
        {
            var sunnyContext = context.SunnyContext;
            _sunnyContextFactory.Dispose(sunnyContext);
        }

        public Task ProcessRequestAsync(Context context)
        {
            return this._application(context.SunnyContext);
        }

        public struct Context
        {
            public SunnyContext SunnyContext { get; set; }
            public IDisposable Scope { get; set; }
            public long StartTimestamp => Stopwatch.GetTimestamp();
        }
    }
}

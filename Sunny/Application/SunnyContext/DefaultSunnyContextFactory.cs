using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sunny.Application
{

    public class DefaultSunnyContextFactory : ISunnyContextFactory
    {
        private static AsyncLocal<SunnyContext> _httpContextCurrent = new AsyncLocal<SunnyContext>();

        public SunnyContext Create(IFeatureCollection featureCollection)
        {
            this.SunnyContext = new DefaultSunnyContext(featureCollection);
            return this.SunnyContext;
        }

        public void Dispose(SunnyContext httpContext)
        {
            this.SunnyContext = null;
        }

        public SunnyContext SunnyContext
        {
            get
            {
                return _httpContextCurrent.Value;
            }
            set
            {
                _httpContextCurrent.Value = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sunny.Application.SunnyApplication
{
    public class DefaultSunnyApplication : ISunnyApplication<SunnyContext>
    {
        public SunnyContext Context { get; }
        public RequestDelegate Application { get; }
        public DefaultSunnyApplication(RequestDelegate application,SunnyContext context)
        {
            this.Application = application;
            this.Context = context;
        }

        public SunnyContext CreateContext(IFeatureCollection contextFeatures)
        {
            throw new NotImplementedException();
        }

        public void DisposeContext(SunnyContext context, Exception exception)
        {
            throw new NotImplementedException();
        }

        public Task ProcessRequestAsync(SunnyContext context)
        {
            throw new NotImplementedException();
        }
    }
}

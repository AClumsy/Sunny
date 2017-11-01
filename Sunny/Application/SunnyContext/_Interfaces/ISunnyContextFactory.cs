using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Application
{
    public interface ISunnyContextFactory
    {
        SunnyContext Create(IFeatureCollection featureCollection);
        void Dispose(SunnyContext httpContext);
    }
}

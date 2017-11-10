using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Application
{
    /// <summary>
    ///  SunnyContext 工厂接口
    /// </summary>
    public interface ISunnyContextFactory
    {
        SunnyContext Create(IFeatureCollection featureCollection);
        void Dispose(SunnyContext httpContext);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sunny.Application
{
    public interface ISunnyApplication<TContext>
    {
        TContext CreateContext(IFeatureCollection contextFeatures);
        void DisposeContext(TContext context, Exception exception);
        Task ProcessRequestAsync(TContext context);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sunny.Application;

namespace Sunny.Services.SecondaryCache
{
    public class DefaultSecondaryCache<TCache> : ISecondaryCacheService<TCache>
    {
        public Task InvokeAsync(SunnyContext context, RequestDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}

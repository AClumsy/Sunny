using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SunnyBuilderServices
    {
        public static ISunnyBuilder AddServices(this ISunnyBuilder builder)
        {
            return builder;
        }
    }
}

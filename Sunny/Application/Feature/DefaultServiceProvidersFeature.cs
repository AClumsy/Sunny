using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Application.Feature
{
    public class DefaultServiceProvidersFeature : IServiceProvidersFeature
    {
        public IServiceProvider RequestServices { get; set; }
    }
}

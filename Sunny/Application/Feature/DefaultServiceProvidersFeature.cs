using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Application.Feature
{
    internal class DefaultServiceProvidersFeature : IServiceProvidersFeature
    {
        public IServiceProvider RequestServices { get; set; }
    }
}

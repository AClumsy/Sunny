using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Application.Feature
{
    public interface IServiceProvidersFeature
    {
        IServiceProvider RequestServices { get; }
    }
}

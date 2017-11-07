using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Application
{
    public interface IServiceProvidersFeature
    {
        IServiceProvider RequestServices { get; set; }
    }
}

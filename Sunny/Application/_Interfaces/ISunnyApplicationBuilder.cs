using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Application
{
    public interface ISunnyApplicationBuilder
    {
        RequestDelegate Build();
        ISunnyApplicationBuilder UseService(Func<RequestDelegate, RequestDelegate> middleware);
    }
}

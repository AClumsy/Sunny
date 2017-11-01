using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Application
{
    public interface ISunnyApplicationBuilder
    {
        RequestDelegate Build();
        ISunnyApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware);
    }
}

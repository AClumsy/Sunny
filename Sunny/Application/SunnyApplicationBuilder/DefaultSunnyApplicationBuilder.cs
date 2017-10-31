using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Application.SunnyApplicationBuilder
{
    public class DefaultSunnyApplicationBuilder : ISunnyApplicationBuilder
    {
        public RequestDelegate Build()
        {
            throw new NotImplementedException();
        }

        public ISunnyApplicationBuilder UseService(Func<RequestDelegate, RequestDelegate> middleware)
        {
            throw new NotImplementedException();
        }
    }
}

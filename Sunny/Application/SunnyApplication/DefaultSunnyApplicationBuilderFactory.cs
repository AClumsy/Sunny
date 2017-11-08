using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Application
{
    public class DefaultSunnyApplicationBuilderFactory : ISunnyApplicationBuilderFactory
    {
        public ISunnyApplicationBuilder CreateBuilder()
        {
            return new DefaultSunnyApplicationBuilder();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Hosting.SunnyHostBuilder
{
    public class DefaultSunnyHostBuilder : ISunnyHostBuilder
    {
        public ISunnyHost Build()
        {
            throw new NotImplementedException();
        }

        public ISunnyHost UseServer(IServerFactory factory)
        {
            throw new NotImplementedException();
        }

        public ISunnyHost UseStartup(IStartup startup)
        {
            throw new NotImplementedException();
        }
    }
}

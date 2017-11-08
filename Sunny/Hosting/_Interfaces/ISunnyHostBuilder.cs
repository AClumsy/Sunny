using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Hosting
{
    public interface ISunnyHostBuilder
    {
        ISunnyHostBuilder UseServer(IServerFactory factory);
        ISunnyHostBuilder UseStartup(IStartup startup);
        ISunnyHost Build();
    }
}

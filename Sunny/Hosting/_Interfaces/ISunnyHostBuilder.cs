using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Hosting
{
    public interface ISunnyHostBuilder
    {
        ISunnyHostBuilder UseServer(IServerFactory factory);
        ISunnyHostBuilder UseStartup<TStartup>() where TStartup : IStartup;
        ISunnyHost Build();
    }
}

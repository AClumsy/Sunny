using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Hosting
{
    public interface ISunnyHostBuilder
    {
        ISunnyHost UseServer(IServerFactory factory);
        ISunnyHost UseStartup(IStartup startup);
        ISunnyHost Build();
    }
}

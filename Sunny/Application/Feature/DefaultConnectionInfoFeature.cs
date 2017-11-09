using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Sunny.Application.Feature
{
    internal class DefaultConnectionInfoFeature : IConnectionInfoFeature
    {
        public string ConnectionId { get; set; }
        public IPAddress RemoteIpAddress { get;  }
        public IPAddress LocalIpAddress { get; }
        public int RemotePort { get;  }
        public int LocalPort { get;  }
        public object ServerContext => null;
    }
}

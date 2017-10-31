using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Sunny.Application.Feature
{
    public class DefaultConnectionInfoFeature : IConnectionInfoFeature
    {
        public string ConnectionId { get; set; }
        public IPAddress RemoteIpAddress { get; set; }
        public IPAddress LocalIpAddress { get; set; }
        public int RemotePort { get; set; }
        public int LocalPort { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sunny
{
    /// <summary>
    /// 请求底层连接的信息。
    /// </summary>
    public abstract class ConnectionInfo
    {
        public abstract string Id { get; }

        public abstract IPAddress RemoteIpAddress { get; }

        public abstract int RemotePort { get; }

        public abstract IPAddress LocalIpAddress { get;  }

        public abstract int LocalPort { get;}

      
    }
}

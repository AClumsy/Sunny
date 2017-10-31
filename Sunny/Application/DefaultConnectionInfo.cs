using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Sunny.Application.Feature;

namespace Sunny.Application
{
    public class DefaultConnectionInfo : ConnectionInfo
    {
        public DefaultConnectionInfo(SunnyContext context)
        {
            this.Context = context;
            this.Feature = this.Context.Features.Get<IConnectionInfoFeature>();
        }

        private IConnectionInfoFeature Feature { get; }
        private SunnyContext Context { get; }
       
        public override string Id => this.Feature.ConnectionId;
        public override IPAddress RemoteIpAddress => this.Feature.RemoteIpAddress;
        public override int RemotePort => this.Feature.RemotePort;
        public override IPAddress LocalIpAddress => this.Feature.LocalIpAddress;
        public override int LocalPort => this.Feature.LocalPort;


    }
}

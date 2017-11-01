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
        private readonly static FeatureReference<IConnectionInfoFeature> featureReference = new FeatureReference<IConnectionInfoFeature>(new DefaultConnectionInfoFeature());
        public DefaultConnectionInfo(SunnyContext context)
        {
            this.SunnyContext = context;
        }

    
        private SunnyContext SunnyContext { get; }
        private IConnectionInfoFeature Feature => featureReference.Fetch(this.SunnyContext.Features);
        public override string Id => this.Feature.ConnectionId;
        public override IPAddress RemoteIpAddress => this.Feature.RemoteIpAddress;
        public override int RemotePort => this.Feature.RemotePort;
        public override IPAddress LocalIpAddress => this.Feature.LocalIpAddress;
        public override int LocalPort => this.Feature.LocalPort;

        public override object ServerContext => this.Feature.ServerContext;
    }
}

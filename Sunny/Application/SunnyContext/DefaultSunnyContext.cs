using Sunny.Application.Feature;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Sunny.Application
{
    public class DefaultSunnyContext : SunnyContext
    {
        public DefaultSunnyContext()
            : this(new DefaultFeatureCollection())
        {

        }
        public DefaultSunnyContext(IFeatureCollection featureCollection)
        {
            this.Features = featureCollection;
            this.Request = new DefaultSunnyRequest(this);
            this.Response = new DefaultSunnyResponse(this);
            this.ConnectionInfo = new DefaultSunnyConnectionInfo(this);
            this.RequestServices = featureCollection.Get<IServiceProvidersFeature>().RequestServices;
        }

        public override IFeatureCollection Features { get; }
        public override SunnyRequest Request { get; }
        public override SunnyResponse Response { get; }
        public override SunnyConnectionInfo ConnectionInfo { get; }
        public override ClaimsPrincipal User { get; }
        public override IServiceProvider RequestServices { get; }
    }
}

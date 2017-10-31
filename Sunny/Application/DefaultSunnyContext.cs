using Sunny.Application.FeatureCollection;
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
            this.Features.Set<ISunnyRequestFeature>(new DefaultSunnyRequestFeature());
            this.Features.Set<ISunnyResponseFeature>(new DefaultSunnyResponseFeature());
            this.Features.Set<IConnectionInfoFeature>(new DefaultConnectionInfoFeature());
        }
        public DefaultSunnyContext(IFeatureCollection featureCollection)
        {
            this.Features = featureCollection;
            this.Request = new DefaultSunnyRequest(this);
            this.Response = new DefaultSunnyResponse(this);
            this.ConnectionInfo = new DefaultConnectionInfo(this);
        }

        public override IFeatureCollection Features { get; }
        public override SunnyRequest Request { get; }
        public override SunnyResponse Response { get; }
        public override ConnectionInfo ConnectionInfo { get; }
        public override ClaimsPrincipal User { get; }
    }
}

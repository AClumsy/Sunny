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

        }
        public DefaultSunnyContext(IFeatureCollection featureCollection)
        {
            this.Features = featureCollection;
        }

        public override IFeatureCollection Features { get; }
        public override SunnyRequest Request => new DefaultSunnyRequest(this);
        public override SunnyResponse Response => new DefaultSunnyResponse(this);
        public override ConnectionInfo ConnectionInfo => new DefaultConnectionInfo(this);
        public override ClaimsPrincipal User { get; }


    
 
    }
}

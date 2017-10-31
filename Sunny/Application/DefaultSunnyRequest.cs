using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sunny.Application.Feature;
using Microsoft.AspNetCore.Http;

namespace Sunny.Application
{
    public class DefaultSunnyRequest : SunnyRequest
    {
        public DefaultSunnyRequest(SunnyContext context)
        {
            this.SunnyContext = context;
            this.Feature = this.SunnyContext.Features.Get<ISunnyRequestFeature>();
        }
        private ISunnyRequestFeature Feature { get; }
        public override string RequestId => this.Feature.RequestId;
        public override SunnyContext SunnyContext { get; }
        public override HostString Host => new HostString(this.Feature.Host, this.Feature.Port);
        public override PathString Path => new PathString(this.Feature.Path);
        public override SunnyRouteing SunnyRoute { get; internal set; }
        public override long? ContentLength => this.Feature.ContentLength;
        public override Stream Body => this.Feature.Body;
        public override object HostServer => this.Feature.HostServer;
    }
}

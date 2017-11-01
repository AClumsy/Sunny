using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sunny.Application.Feature;
using Microsoft.AspNetCore.Http;
using Sunny.Models;

namespace Sunny.Application
{
    public class DefaultSunnyRequest : SunnyRequest
    {
        private readonly static FeatureReference<ISunnyRequestFeature> featureReference = new FeatureReference<ISunnyRequestFeature>(new DefaultSunnyRequestFeature());
        public DefaultSunnyRequest(SunnyContext context)
        {
            this.SunnyContext = context;

        }
        private ISunnyRequestFeature Feature => featureReference.Fetch(this.SunnyContext.Features);
        public override string RequestId => this.Feature.RequestId;
        public override SunnyContext SunnyContext { get; }
        public override HostString Host => new HostString(this.Feature.Host, this.Feature.Port);
        public override PathString Path => new PathString(this.Feature.Path);
        public override SunnyRouteing SunnyRoute { get; internal set; }
        public override long? ContentLength => this.Feature.ContentLength;
        public override Stream Body => this.Feature.Body;
    }
}

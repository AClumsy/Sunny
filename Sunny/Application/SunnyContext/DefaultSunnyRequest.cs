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
            this.Feature = featureReference.Fetch(this.SunnyContext.Features);
            this.Host = new HostString(this.Feature.Host, this.Feature.Port);
            this.Path = new PathString(this.Feature.Path);
        }
        private ISunnyRequestFeature Feature { get; }
        public override string RequestId => this.Feature.RequestId;
        public override SunnyContext SunnyContext { get; }
        public override HostString Host { get; }
        public override PathString Path { get; }
        public override SunnyRouteing SunnyRoute { get; internal set; }
        public override long? ContentLength => this.Feature.ContentLength;
        public override Stream Body => this.Feature.Body;
    }
}

using Sunny.Application.Feature;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sunny.Application
{
    public class DefaultSunnyResponse : SunnyResponse
    {
        private readonly static FeatureReference<ISunnyResponseFeature> featureReference = new FeatureReference<ISunnyResponseFeature>(new DefaultSunnyResponseFeature());

        public DefaultSunnyResponse(SunnyContext context)
        {
            this.SunnyContext = context;
            this.Feature = featureReference.Fetch(this.SunnyContext.Features);
            this.StatusCode = this.Feature.StatusCode;
        }
        private ISunnyResponseFeature Feature { get; }
        public override SunnyContext SunnyContext { get; }
        public override Stream OutputStream => this.Feature.OutputStream;
        public override string StatusCode { get; internal set; }

    }
}

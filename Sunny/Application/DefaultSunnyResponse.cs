using Sunny.Application.Feature;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sunny.Application
{
    public class DefaultSunnyResponse : SunnyResponse
    {
        private string _statusCode { get; set; }
        public DefaultSunnyResponse(SunnyContext context)
        {
            this.SunnyContext = context;
            this.Feature = this.SunnyContext.Features.Get<ISunnyResponseFeature>();
            this.StatusCode = this.Feature.StatusCode;
        }
        private ISunnyResponseFeature Feature { get; }
        public override SunnyContext SunnyContext { get; }
        public override Stream OutputStream => this.Feature.OutputStream;
        public override string StatusCode { get; internal set; }

    }
}

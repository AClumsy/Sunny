using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sunny.Application.Feature
{
    public class DefaultSunnyResponseFeature : ISunnyResponseFeature
    {
        public DefaultSunnyResponseFeature()
        {
            this.OutputStream = Stream.Null;
            this.StatusCode = "200";
        }

        public Stream OutputStream { get; set; }

        public string StatusCode { get; set; }
    }
}

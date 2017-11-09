using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Sunny.Application.Feature
{
    internal class DefaultSunnyRequestFeature : ISunnyRequestFeature
    {
        public DefaultSunnyRequestFeature()
        {
            this.Host = string.Empty;
            this.Path = string.Empty;
            this.RequestId = "";
            this.Body = Stream.Null;
            this.ContentLength = 0;
            this.Port = 80;
            this.HostServer = null;
        }
        public string RequestId { get; set; }
        public string Host { get; set; }
        public string Path { get; set; }
        public Stream Body { get; set; }
        public long ContentLength{ get; set; }
        public int Port { get; set; }
        public object HostServer { get; set; }
    }
}

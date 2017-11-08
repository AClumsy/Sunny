using Microsoft.AspNetCore.Http;
using Sunny.Application;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace Sunny.Hosting.AspNetCoreServer
{
    public class AspNetCoreServerFeature : ISunnyRequestFeature, ISunnyResponseFeature, IConnectionInfoFeature
    {
        public HttpContext Context { get; }
        public string ConnectionId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IPAddress RemoteIpAddress => throw new NotImplementedException();

        public IPAddress LocalIpAddress => throw new NotImplementedException();

        public int RemotePort => throw new NotImplementedException();

        public int LocalPort => throw new NotImplementedException();

        public object ServerContext => throw new NotImplementedException();

        public Stream OutputStream => throw new NotImplementedException();

        public string StatusCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RequestId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Host { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Port { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Path { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Stream Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long ContentLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public AspNetCoreServerFeature(HttpContext context)
        {
            this.Context = context;

        }
    }
}

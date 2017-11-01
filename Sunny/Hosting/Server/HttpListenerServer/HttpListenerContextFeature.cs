using Sunny.Application;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using Sunny.Application.Feature;

namespace Sunny.Hosting.Server
{
    public class HttpListenerContextFeature : ISunnyRequestFeature, ISunnyResponseFeature, IConnectionInfoFeature
    {
        public HttpListenerContext Context { get; }
        public string RequestId { get { return this.Context.Response.ContentType; } set { this.Context.Response.ContentType = value; } }
        public string Host { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Port { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Path { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Stream Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object HostServer => this.Context;
        public long ContentLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Stream OutputStream => this.Context.Response.OutputStream;

        public string StatusCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ConnectionId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPAddress RemoteIpAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPAddress LocalIpAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int RemotePort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int LocalPort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object ServerContext => this.Context;

        public HttpListenerContextFeature(HttpListenerContext context)
        {
            this.Context = context;

        }


    }
}

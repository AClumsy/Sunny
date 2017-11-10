using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using Sunny.Application.Feature;

namespace Sunny.Hosting.AspNetCoreServer
{
    public class AspNetCoreServerFeature : ISunnyRequestFeature, ISunnyResponseFeature, ISunnyConnectionInfoFeature, IServiceProvidersFeature
    {
        private HttpContext Context { get; }

        public IPAddress RemoteIpAddress => this.Context.Connection.RemoteIpAddress;

        public IPAddress LocalIpAddress => this.Context.Connection.LocalIpAddress;

        public int RemotePort => this.Context.Connection.RemotePort;

        public int LocalPort => this.Context.Connection.LocalPort;

        public object ServerContext => this.Context;

        public Stream OutputStream => this.Context.Response.Body;

        public string StatusCode
        {
            get { return this.Context.Response.StatusCode.ToString(); }
            set { this.Context.Response.StatusCode = int.Parse(value); }
        }
        public string RequestId
        {
            get { return ""; }
            set { }
        }
        public string Host
        {
            get { return this.Context.Request.Host.ToString(); }
            set { this.Context.Request.Host = new HostString(value); }
        }
        public int Port
        {
            get { return this.LocalPort; }
            set { }
        }
        public string Path
        {
            get { return ""; }
            set { }
        }
        public Stream Body
        {
            get { return this.Context.Request.Body; }
            set { }
        }
        public long ContentLength
        {
            get { return (long)this.Context.Request.ContentLength; }
            set { }
        }
        public string ConnectionId
        {
            get { return this.Context.Connection.Id; }
            set { this.Context.Connection.Id = value; }
        }

        public IServiceProvider RequestServices => this.Context.RequestServices;

        public AspNetCoreServerFeature(HttpContext context)
        {
            this.Context = context;

        }
    }
}

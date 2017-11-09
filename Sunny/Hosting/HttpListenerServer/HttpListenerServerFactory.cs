using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Hosting.HttpListenerServer
{
    public class HttpListenerServerFactory : IServerFactory
    {
        private string listenUrl;
        public HttpListenerServerFactory(string listenUrl = null)
        {
            this.listenUrl = listenUrl ?? "http://localhost:418/";
        }
        public IServer CreateServer()
        {
            return new HttpListenerServer(listenUrl);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Sunny.Application;
using Sunny.Application.Feature;
using System.Threading.Tasks;


namespace Sunny.Hosting.HttpListenerServer
{
    public class HttpListenerServer : IServer
    {
        public HttpListener Listener { get; }
        public IFeatureCollection Features { get; }
        public HttpListenerServer(string url)
        {
            this.Listener = new HttpListener();
            this.Listener.Prefixes.Add(url ?? "http://localhost:418/");
        }
        public Task StartAsync<TContext>(ISunnyApplication<TContext> application)
        {
            this.Listener.Start();
            while (true)
            {
                HttpListenerContext httpListenerContext = this.Listener.GetContext();
                HttpListenerContextFeature feature = new HttpListenerContextFeature(httpListenerContext);
                this.Features.Set<ISunnyRequestFeature>(feature);
                this.Features.Set<ISunnyResponseFeature>(feature);

                TContext context = application.CreateContext(this.Features);
                application.ProcessRequestAsync(context)
                    .ContinueWith(_ => httpListenerContext.Response.Close())
                    .ContinueWith(_ => application.DisposeContext(context, _.Exception));
            }
        }

        public Task StopAsync()
        {
            return Task.Run(() =>
            {
                this.Listener.Stop();
            });
        }
    }
}

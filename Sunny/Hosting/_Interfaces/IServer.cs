using Sunny.Application;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sunny.Hosting
{
    public interface IServer
    {
        /// <summary>
        /// A collection of Sunny features of the server.
        /// </summary>
        IFeatureCollection Features { get; }
        Task StartAsync<TContext>(ISunnyApplication<TContext> application);
        Task StopAsync();
    }
}

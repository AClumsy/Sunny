using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Sunny.Hosting.SunnyHost
{
    public class DefaultSunnyHostBuilder : ISunnyHostBuilder
    {
        private readonly IServiceCollection services;
        private IStartup startup = new DefaultStartup();

        public DefaultSunnyHostBuilder()
        {
            services = new ServiceCollection();

        }
        public ISunnyHost Build()
        {
            var host = new DefaultSunnyHost(services, startup);
            return host;
        }

        public ISunnyHostBuilder UseServer(IServerFactory factory)
        {
            services.AddSingleton<IServerFactory>(factory);
            return this;
        }
        public ISunnyHostBuilder UseStartup<TStartup>() where TStartup : IStartup
        {
            this.startup = (IStartup)Activator.CreateInstance(typeof(TStartup)); ;
            return this;
        }


    }
}

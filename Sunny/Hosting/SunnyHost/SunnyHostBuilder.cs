using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Hosting
{
    public class SunnyHostBuilder : ISunnyHostBuilder
    {
        private readonly IServiceCollection services;
        private IStartup startup;

        public SunnyHostBuilder()
        {
            services = new ServiceCollection();
        }
        public ISunnyHost Build()
        {
            var host = new SunnyHost(services, startup);

            return host;
        }

        public ISunnyHostBuilder UseServer(IServerFactory factory)
        {
            services.AddSingleton<IServerFactory>(factory);
            return this;
        }

        public ISunnyHostBuilder UseStartup(IStartup startup)
        {
            this.startup = startup;
            return this;
        }
    }
}

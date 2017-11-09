using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Sunny.Application;

namespace Sunny.Hosting
{
    public class SunnyHost : ISunnyHost
    {
        private readonly IServiceProvider serviceProvider;
        private readonly IStartup startup;
        public SunnyHost(IServiceCollection services, IStartup startup)
        {
            this.startup = startup;
            this.startup.ConfigureServices(services);
            this.serviceProvider = services.BuildServiceProvider();
        }

        public IServiceProvider Services => this.serviceProvider;

        public void Start()
        {
            ISunnyApplicationBuilder applicationBuilder = serviceProvider.GetRequiredService<ISunnyApplicationBuilderFactory>().CreateBuilder();
            this.startup.Configure(applicationBuilder);
            IServer server = serviceProvider.GetRequiredService<IServerFactory>().CreateServer();

            //Building SunnyApplication
            var sunnyContextFactory = serviceProvider.GetRequiredService<ISunnyContextFactory>();
            var sunnyApplication = applicationBuilder.Build();
            var hostingApp = new DefaultSunnyApplication(sunnyApplication, sunnyContextFactory);

            //Start Server
            server.StartAsync(hostingApp);
        }
    }
}

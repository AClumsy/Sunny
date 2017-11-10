using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Services
{
    public class DefaultSunnyServiceFactory : ISunnyServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public DefaultSunnyServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ISunnyService Create(Type serviceType) 
        {

            return _serviceProvider.GetRequiredService(serviceType) as ISunnyService;
        }

        public void Release(ISunnyService service)
        {
            // The container owns the lifetime of the service
        }
    }
}

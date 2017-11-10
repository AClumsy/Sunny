using System;
using System.Collections.Generic;
using System.Text;
using Sunny.Services;
using Microsoft.Extensions.DependencyInjection;
using Sunny.Infrastructure;
using System.Reflection;

namespace Sunny.Application
{
    public static class UseServiceExtensions
    {
        public static ISunnyApplicationBuilder UseService<TService>(this ISunnyApplicationBuilder app) where TService : ISunnyService
        {
            return app.UseService(typeof(TService));

        }

        public static ISunnyApplicationBuilder UseService(this ISunnyApplicationBuilder app, Type serviceType)
        {
            if (!typeof(ISunnyService).GetTypeInfo().IsAssignableFrom(serviceType.GetTypeInfo()))
            {
                throw new InvalidOperationException(Resources.FormatException_UseServiceServiceTypeNotInheritedISunnyService(serviceType));
            }
            return app.Use(next =>
            {
                return async context =>
                {
                    var serviceFactory = context.RequestServices.GetService<ISunnyServiceFactory>();
                    if (serviceFactory == null)
                    {
                        // No service factory
                        throw new InvalidOperationException(Resources.FormatException_UseServiceNoSuunyServiceFactory(typeof(ISunnyServiceFactory)));
                    }

                    var service = serviceFactory.Create(serviceType);
                    if (service == null)
                    {
                        // The factory returned null, it's a broken implementation
                        throw new InvalidOperationException(Resources.FormatException_UseServiceUnableToCreateSunnyService(serviceFactory.GetType(), serviceType));
                    }

                    try
                    {
                        await service.InvokeAsync(context, next);
                    }
                    finally
                    {
                        serviceFactory.Release(service);
                    }
                };
            });
        }
    }
}

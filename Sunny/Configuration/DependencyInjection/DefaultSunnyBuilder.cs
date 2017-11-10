// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using Microsoft.Extensions.DependencyInjection;
using System;

namespace Sunny.Configuration
{
    /// <summary>
    /// Sunny helper class for DI configuration
    /// </summary>
    public class DefaultSunnyBuilder : ISunnyBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultSunnyBuilder"/> class.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <exception cref="System.ArgumentNullException">services</exception>
        public DefaultSunnyBuilder(IServiceCollection services)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }

        /// <summary>
        /// Gets the services.
        /// </summary>
        /// <value>
        /// The services.
        /// </value>
        public IServiceCollection Services { get; }

        /// <summary>
        /// Build the ISunnyBuilder
        /// </summary>
        /// <returns></returns>
        public ISunnyBuilder Build()
        {
            this.AddApplication()
                .AddException();
            return this;
        }
    }
}
﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Sunny.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Hosting
{
    public interface IStartup
    {
        void ConfigureServices(IServiceCollection services);

        void Configure(ISunnyApplicationBuilder app);
    }
}

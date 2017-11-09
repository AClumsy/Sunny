using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sunny.Application;

namespace Sunny.Services
{
    /// <summary>
    ///  Sunny 服务基础接口 
    /// </summary>
    public interface ISunnyService
    {
        Task InvokeAsync(SunnyContext context, RequestDelegate next);
    }
}

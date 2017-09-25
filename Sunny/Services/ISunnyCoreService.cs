using Sunny.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sunny.Services
{
    /// <summary>
    /// Sunny 处理核心处理器
    /// </summary>
    public interface ISunnyCoreService : ISunnyService
    {
        Task<SunnyResponse> ProcessAsync(SunnyRequest request);
    }
}

using Sunny.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sunny.Transport
{
    /// <summary>
    /// 下流请求分发中心
    /// </summary>
    public interface IDownstreamTransport: ISunnyTransport
    {
        Task<SunnyResponse> ProcessAsync(SunnyRequest request);
    }
}

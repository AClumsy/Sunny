using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sunny.Transport
{
    /// <summary>
    /// 上流协议适配器
    /// </summary>
    public interface IUpstreamProtocolAdaptation : ISunnyProtocolAdaptation
    {
         Task<SunnyRequest> AdaptationAsync(object request);
    }
}

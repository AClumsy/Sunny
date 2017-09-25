using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sunny.Transport.UpstreamProtocolAdaptation
{
    public class HttpUpstreamProtocolAdaptation : IUpstreamProtocolAdaptation
    {
        public async Task<SunnyRequest> AdaptationAsync(object request)
        {
            SunnyRequest req = new DefaultSunnyRequest();
            req.Authentication = null;
            return req;
        }
    }
}

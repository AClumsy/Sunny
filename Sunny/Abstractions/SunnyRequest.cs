using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sunny
{
    /// <summary>
    /// 表示 Sunny 请求对象
    /// </summary>
    public abstract class SunnyRequest
    {
        protected SunnyRequest()
        {

        }
        public abstract SunnyContext SunnyContext { get; }
        public abstract SunnyAuthenticated Authentication { get; set; }
        public abstract SunnyAuthorisated Authorisation { get; set; }
        public abstract SunnyRequestMessage RequestMessage { get; set; }
        public abstract HostString Host { get; set; }
        
    }
}

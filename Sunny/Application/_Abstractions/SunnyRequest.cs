using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sunny.Application
{
    /// <summary>
    /// 表示 Sunny 请求对象
    /// </summary>
    public abstract class SunnyRequest
    {
        public abstract string RequestId { get; }
        public abstract SunnyContext SunnyContext { get; }
        //public abstract SunnyAuthenticated Authentication { get; set; }
        //public abstract SunnyAuthorisated Authorisation { get; set; }
        public abstract HostString Host { get; }
        public abstract PathString Path { get;  }
        public abstract SunnyRouteing SunnyRoute { get; internal set; }
        public abstract long? ContentLength { get; }
        public abstract Stream Body { get;  }
        /// <summary>
        /// 主机服务上下文
        /// </summary>
        public abstract object HostServer { get; }
    }
}

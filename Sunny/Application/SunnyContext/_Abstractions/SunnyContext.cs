using Sunny.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Sunny.Application
{
    /// <summary>
    /// 表示 Sunny 上下文
    /// </summary>
    public abstract class SunnyContext
    {
        public string RequestId { get { return this.Request.RequestId; } }
        public SunnyRouteing SunnyRoute { get { return this.Request.SunnyRoute; } }
        public abstract IFeatureCollection Features { get; }
        public abstract SunnyRequest Request { get; }
        public abstract SunnyResponse Response { get; }
        public abstract SunnyConnectionInfo ConnectionInfo { get; }
        public abstract ClaimsPrincipal User { get; }
        public abstract IServiceProvider RequestServices { get; }
    }
}

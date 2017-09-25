using Sunny.Models;
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
        public abstract SunnyAuthenticated Authentication { get; set; }
        public abstract SunnyAuthorisated Authorisation { get; set; }
        public abstract SunnyRoute SunnyRoute { get; set; }
        public abstract SunnyRequestMessage Body { get; set; }
        public abstract HostString Host { get; set; }
        public abstract RequestId RequestId { get; set; }
        public abstract SunnyContext SunnyContext { get; }
    }
}

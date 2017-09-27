using Sunny.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny
{
    /// <summary>
    /// 表示 Sunny 上下文
    /// </summary>
    public abstract class SunnyContext
    {
        public abstract SunnyRequest Request { get;}
        public abstract SunnyResponse Response { get; }
        /// <summary>
        /// Gets information about the underlying connection for this request.
        /// </summary>
        public abstract ConnectionInfo Connection { get; }
        public abstract string RequestId { get; set; }
        public abstract Routeing SunnyRoute { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Abstractions
{
    /// <summary>
    /// 表示 Sunny 上下文
    /// </summary>
    public abstract class SunnyContext
    {
        public abstract SunnyRequest Request { get;}

        public abstract SunnyResponse Response { get; }
    }
}

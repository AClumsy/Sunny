using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sunny.Application
{
    /// <summary>
    /// 表示 Sunny 响应对象
    /// </summary>
    public abstract class SunnyResponse
    {
        public abstract SunnyContext SunnyContext { get; }
        public abstract Stream OutputStream { get; }
        public abstract string StatusCode { get; internal set; }
    }
}

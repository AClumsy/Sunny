using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny
{
    /// <summary>
    /// 表示 Sunny 响应对象
    /// </summary>
    public abstract class SunnyResponse
    {
        public abstract SunnyContext SunnyContext { get; }
    }
}

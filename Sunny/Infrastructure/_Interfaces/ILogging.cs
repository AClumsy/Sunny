using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Infrastructure
{
    /// <summary>
    /// 日志记录  
    /// </summary>
    public interface ILogging<out TCategoryName> : ILogger
    {
       
    }
}

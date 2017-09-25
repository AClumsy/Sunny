using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Models
{
    /// <summary>
    /// 全局请求ID
    /// </summary>
    public class RequestId
    {
        public RequestId(string requestIdKey, string requestIdValue)
        {
            RequestIdKey = requestIdKey;
            RequestIdValue = requestIdValue;
        }

        public string RequestIdKey { get; private set; }
        public string RequestIdValue { get; private set; }
    }
}

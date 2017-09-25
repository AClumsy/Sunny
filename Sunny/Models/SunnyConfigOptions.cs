using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Models
{
    public class SunnyConfigOptions
    {
        public bool IsAuthenticated { get; }
        public bool IsAuthorised { get; }
        public bool IsCached { get; }
        public bool IsQos { get; }
        public bool EnableRateLimiting { get; }
        public bool EnableTrustControl { get; }
        public DataSecurityType DataSecurity { get; }
    }
    public enum DataSecurityType
    {
        /// <summary>
        /// 纯文本
        /// </summary>
        PlainText,
        /// <summary>
        /// 签名
        /// </summary>
        Signature,
        /// <summary>
        /// 密文
        /// </summary>
        Ciphertext
    }
}




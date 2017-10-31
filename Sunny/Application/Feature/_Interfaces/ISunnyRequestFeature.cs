using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sunny.Application.Feature
{
    public interface ISunnyRequestFeature : IFeature
    {
        string RequestId { get; set; }
        string Host { get; set; }
        int Port { get; set; }
        string Path { get; set; }
        Stream Body { get; set; }
        object HostServer { get; set; }
        long ContentLength { get; set; }
    }
}

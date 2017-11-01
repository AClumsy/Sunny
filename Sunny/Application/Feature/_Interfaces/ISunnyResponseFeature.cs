using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sunny.Application
{
    public interface ISunnyResponseFeature: IFeature
    {
        Stream OutputStream { get; }
        string StatusCode { get; set; }
    }
}

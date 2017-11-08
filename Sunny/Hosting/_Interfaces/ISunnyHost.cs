using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Hosting
{
    public interface ISunnyHost
    {
        IServiceProvider Services { get; }
        void Start();
    }
}

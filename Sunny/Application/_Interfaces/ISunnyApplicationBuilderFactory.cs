using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Application
{
    /// <summary>
    /// SunnyApplication 建造器 工厂接口
    /// </summary>
    public interface ISunnyApplicationBuilderFactory
    {
        ISunnyApplicationBuilder CreateBuilder();
    }
}

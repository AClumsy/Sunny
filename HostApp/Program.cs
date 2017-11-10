using System;
using Sunny.Hosting;
using Sunny.Hosting.HttpListenerServer;
using Sunny.Hosting.SunnyHost;

namespace HostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new DefaultSunnyHostBuilder()
                             .UseServer(new HttpListenerServerFactory())
                             //.UseStartup<Startup>()
                             .Build()
                             .Start();
            Console.WriteLine("Hello World!");
        }
    }
}

using System;
using Sunny.Hosting;
using Sunny.Hosting.HttpListenerServer;

namespace HostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new SunnyHostBuilder()
                             .UseServer(new HttpListenerServerFactory())
                             //.UseStartup<Startup>()
                             .Build()
                             .Start();
            Console.WriteLine("Hello World!");
        }
    }
}

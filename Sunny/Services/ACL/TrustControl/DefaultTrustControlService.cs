using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sunny.Application;

namespace Sunny.Services.ACL
{
    public class DefaultTrustControlService : ISunnyService
    {
        public Task InvokeAsync(SunnyContext context, RequestDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}

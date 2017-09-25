using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sunny.Abstractions;

namespace Sunny.Services.SunnyCore
{
    public class DefaultSunnyCoreService : ISunnyCoreService
    {
        public Task<SunnyResponse> ProcessAsync(SunnyRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

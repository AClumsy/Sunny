using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Services
{
    /// <summary>
    /// Sunny Service 工厂接口
    /// </summary>
    public interface ISunnyServiceFactory
    {
        /// <summary>
        /// Creates a Service instance for each request.
        /// </summary>
        /// <param name="serviceType">The concrete <see cref="Type"/> of the <see cref="ISunnyService"/>.</param>
        /// <returns>The <see cref="ISunnyService"/> instance.</returns>
        ISunnyService Create(Type serviceType );

        /// <summary>
        /// Releases a <see cref="ISunnyService"/> instance at the end of each request.
        /// </summary>
        /// <param name="service">The <see cref="ISunnyService"/> instance to release.</param>
        void Release(ISunnyService service);
    }
}

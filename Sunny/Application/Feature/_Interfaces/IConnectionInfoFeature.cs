using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Sunny.Application
{
    public interface IConnectionInfoFeature: IFeature
    {
        /// <summary>
        /// The unique identifier for the connection the request was received on. This is primarily for diagnostic purposes.
        /// </summary>
        string ConnectionId { get; set; }

        /// <summary>
        /// The IPAddress of the client making the request. Note this may be for a proxy rather than the end user.
        /// </summary>
        IPAddress RemoteIpAddress { get; }

        /// <summary>
        /// The local IPAddress on which the request was received.
        /// </summary>
        IPAddress LocalIpAddress { get; }

        /// <summary>
        /// The remote port of the client making the request.
        /// </summary>
        int RemotePort { get;  }

        /// <summary>
        /// The local port on which the request was received.
        /// </summary>
        int LocalPort { get; }

        object ServerContext { get; }
    }
}

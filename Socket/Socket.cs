using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.Storage.Streams;
using UWPSocket = Windows.Networking.Sockets;
using DotNetSocket = System.Net.Sockets;
namespace System.Net.Sockets
{
    public class Socket
    {
        #region Member
        private UWPSocket.StreamSocket innerSocket;
        #endregion
        #region Inner Func
        #endregion
        #region Common Func
        public Socket()
        { }
        #endregion
    }
}

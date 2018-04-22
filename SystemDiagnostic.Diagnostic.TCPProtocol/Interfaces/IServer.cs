using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using SystemDiagnostic.Diagnostic.TCPProtocol.Extensions;

namespace SystemDiagnostic.Diagnostic.TCPProtocol.Interfaces
{
    public interface IServer
    {
        event RecieveDataSocket RecieveDataEvent;
        event SocketAction SystemCloseEvent;
        int SendBufferLength {get;set;}
        int RecieveBufferLength {get;set;}
        int TimeOutPing {get;set;}
        IEnumerable<IPEndPoint> Clients {get;}
        void Start(int maxBacklogConnection);
        void Stop();
        Task SendData(byte[] data,IPEndPoint recipient);
        Task BroadCastData(byte[] data);
        bool Kick(IPEndPoint client);
    }
}

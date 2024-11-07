﻿using System.Net;
using System.Net.Sockets;
using System.Text;
using static UDPSocket;

public class UDPSocket
{
    private Socket _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
    private const int bufSize = 8 * 1024;
    private State state = new State();
    private EndPoint epFrom = new IPEndPoint(IPAddress.Any, 0);
    private AsyncCallback recv = null;

    public class State
    {
        public byte[] buffer = new byte[bufSize];   
    }
    public void Server(String address,int port)
    {
        _socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress, true);
        _socket.Bind(new IPEndPoint(IPAddress.Parse(address), port));
        Receive();
    }
    public void Client(String address,int port) 
    {
        
        _socket.Connect(IPAddress.Parse(address), port);
        Receive();
    }
    public void Send(string text)
    {
        byte[] data = Encoding.UTF8.GetBytes(text);
        _socket.BeginSend(data, 0, data.Length, SocketFlags.None, (ar) =>
        {
            State so = (State)ar.AsyncState;
            int bytes = _socket.EndSend(ar);
            Console.WriteLine("SEND: {0}, {1}", bytes, text);
        }, state);
    }
    
    private void Receive()
    {
        _socket.BeginReceiveFrom(state.buffer, 0, bufSize, SocketFlags.None, ref epFrom, recv = (ar) =>
        {
            State so = (State)ar.AsyncState;
            int bytes = _socket.EndReceiveFrom(ar, ref epFrom);
            _socket.BeginReceiveFrom(so.buffer, 0, bufSize, SocketFlags.None, ref epFrom, recv, so);
            Console.WriteLine("RECV: {0}: {1}, {2}", epFrom.ToString(), bytes, Encoding.UTF8.GetString(so.buffer, 0, bytes));
        }, state);
    }
  
static void Main(string[] args)
    {
        UDPSocket s = new UDPSocket();
        s.Server("127.0.0.1", 33333);

        UDPSocket c = new UDPSocket();
        c.Client("127.0.0.1", 33333);
        c.Send("UDP TEST VTCA!");
    }
}


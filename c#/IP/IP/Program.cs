using System.Net;
using System.Net.Sockets;
using System.Text;

internal class Sever
{
    static void Main(string[] args)
    {
        IPAddress address = IPAddress.Parse("127.0.0.1");
        TcpListener listener = new TcpListener(address,666 );
        Console.WriteLine("Sever is listening... please wait !");
        bool info = false;
        listener.Start();
        Socket socket = listener.AcceptSocket();

        byte[] data = new byte[1024];
        socket.Receive(data);
        string str = Encoding.ASCII.GetString(data);
        Console.WriteLine("Client name: My computer");
        Console.WriteLine("Infomation Given: \"" + str + "\"");

        socket.Send(Encoding.ASCII.GetBytes("Hello, " + str));

        Console.WriteLine("Server is closing...");
        socket.Close();
        listener.Stop();
        Console.ReadKey();
    }
}
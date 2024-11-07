using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;

internal class App
{
    static void Main(string[] args)
    {
        TcpClient client = new TcpClient();

        client.Connect("127.0.0.1", 666);

        NetworkStream stream = client.GetStream();
        Console.Write("Give Some infomation:");
        string info = Console.ReadLine();

        byte[] data = Encoding.ASCII.GetBytes(info);
        stream.Write(data, 0, data.Length);

        byte[] dataReceive = new byte[1024];
        stream.Read(dataReceive, 0, 1024);
        Console.WriteLine("Server return: \"" + Encoding.ASCII.GetString(dataReceive) + "\"");

        stream.Close();
        client.Close();
    }
}
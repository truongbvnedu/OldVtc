using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LAB3_EX3_Client
{
    class Client
    {
        static void MakeBreakLine(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // 1. Create
            TcpClient client = new TcpClient();

            // 2. Connect (Update)
            Console.Write("Input IP Address Server: ");
            string address = Console.ReadLine();
            client.Connect(address, 8888);

            // 3. Get stream (Update)
            NetworkStream stream = client.GetStream();
            Console.Write("Input Your name: ");
            string name = Console.ReadLine();
            byte[] usernameData = Encoding.UTF8.GetBytes(name);
            stream.Write(usernameData, 0, usernameData.Length);

            MakeBreakLine(20);

            Thread receiveThread = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        byte[] dataReceive = new byte[1024];
                        int bytesRead = stream.Read(dataReceive, 0, 1024);
                        string str = Encoding.UTF8.GetString(dataReceive, 0, bytesRead);
                        Console.WriteLine(str);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    client.Close();
                }
            });

            receiveThread.Start();

            while (true)
            {
                Console.Write(name + ": ");
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(name + ": " + message);
                stream.Write(data, 0, data.Length);
            }
        }
    }
}

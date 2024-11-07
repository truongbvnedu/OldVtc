using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LAB3_EX3_Server
{
    class Server
    {
        static void Main(string[] args)
        {
            // 1. Listen
            IPAddress address = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(address, 8888);
            Console.WriteLine("Server is listening...");
            listener.Start();

            List<Socket> clients = new List<Socket>();

            while (true)
            {
                Socket socket = listener.AcceptSocket();
                clients.Add(socket);

                // 2. Create new thread to handle the client connection
                Thread clientThread = new Thread(() =>
                {
                    try
                    {
                        // 3. Receive the client's username
                        byte[] usernameData = new byte[1024];
                        int usernameBytesRead = socket.Receive(usernameData);
                        string username = Encoding.UTF8.GetString(usernameData, 0, usernameBytesRead);
                        Console.WriteLine(username + " joined the chat.");

                        while (true)
                        {
                            // 4. Receive data
                            byte[] data = new byte[1024];
                            int bytesRead = socket.Receive(data);
                            string str = Encoding.UTF8.GetString(data, 0, bytesRead);
                            Console.WriteLine(str);

                            // 5. Send back
                            foreach (Socket client in clients)
                            {
                                if (client != socket)
                                {
                                    
                                    client.Send(Encoding.UTF8.GetBytes(str));
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    finally
                    { 
                        clients.Remove(socket);
                        socket.Close();
                    }
                });

                // 6. Start client thread
                clientThread.Start();
            }
        }
    }
}

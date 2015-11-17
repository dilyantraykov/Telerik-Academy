using System.Net;
using System.Net.Sockets;

namespace ChatSender
{
    using System;
    using IronMQ;

    public class Startup
    {
        public static void Main()
        {
            Client client = new Client(
                "564ad77373d0cd00060000dd",
                "sZYHg6S1N2cQU63ias0O");
            Queue queue = client.Queue("Telerik Academy");
            Console.WriteLine("Enter messages to be sent to Telerik Academy:");
            while (true)
            {
                string msg = Console.ReadLine();
                queue.Push(GetLocalIPAddress() + ": " + msg);
                Console.WriteLine("Message sent to Telerik Academy.");
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Unknown IP");
        }
    }
}

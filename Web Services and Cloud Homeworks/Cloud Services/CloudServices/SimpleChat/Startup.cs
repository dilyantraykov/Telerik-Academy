namespace SimpleChat
{
    using System;
    using System.Threading;
    using IronMQ;
    using IronMQ.Data;

    public class Startup
    {
        static void Main()
        {
            Client client = new Client(
                "564ad77373d0cd00060000dd",
                "sZYHg6S1N2cQU63ias0O");
            Queue queue = client.Queue("Telerik Academy");
            Console.WriteLine("Listening for new messages from Telerik Academy:");
            while (true)
            {
                Message msg = queue.Get();
                if (msg != null)
                {
                    Console.WriteLine(msg.Body);
                    queue.DeleteMessage(msg);
                }
                Thread.Sleep(100);
            }
        }
    }
}

namespace QueueImplementation
{
    using System;

    /// <summary>
    /// 13. Implement the ADT queue as dynamic linked list.
    /// - Use generics(LinkedQueue<T>) to allow storing different data types in the queue.
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var queue = new LinkedQueue<int>();
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);

            Console.WriteLine("Items before dequeue: ");
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }

            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine();

            Console.WriteLine("Items after dequeue: ");
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}

namespace StackImplementation
{
    using System;

    /// <summary>
    /// 12. Implement the ADT stack as auto-resizable array.
    /// - Resize the capacity on demand(when no space is available to add / insert a new element).
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            Console.WriteLine("Stack size: {0}", stack.Count);
            Console.WriteLine("Stack capacity: {0}", stack.Capacity);

            Console.WriteLine("Item removed: {0}", stack.Pop());
            Console.WriteLine("Item removed: {0}", stack.Pop());
            Console.WriteLine("Item viewed: {0}", stack.Peek());
            Console.WriteLine("Item removed: {0}", stack.Pop());
            Console.WriteLine("Item viewed: {0}", stack.Peek());
        }
    }
}

namespace ReverseNumbersWithStack
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 2. Write a program that reads N integers from the console and reverses them using a stack.
    /// - Use the Stack<int> class.
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var numbers = new Stack<int>();

            Console.WriteLine("Input numbers: ");
            var inputLine = Console.ReadLine();

            while (inputLine != string.Empty)
            {
                var number = int.Parse(inputLine);
                numbers.Push(number);
                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Here are the reversed numbers: ");
            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}

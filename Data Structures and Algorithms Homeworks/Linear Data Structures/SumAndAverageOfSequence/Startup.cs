namespace SumAndAverageOfSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 1. Write a program that reads from the console a sequence of positive integer numbers.
    /// - The sequence ends when empty line is entered.
    /// - Calculate and print the sum and average of the elements of the sequence.
    /// - Keep the sequence in List<int>.
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var numbers = new List<int>();

            Console.WriteLine("Input numbers: ");
            var inputLine = Console.ReadLine();

            while (inputLine != string.Empty)
            {
                var number = int.Parse(inputLine);
                numbers.Add(number);
                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Average: {0}", numbers.Average());
            Console.WriteLine("Sum: {0}", numbers.Sum());
        }
    }
}

namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 5. Write a program that removes from given sequence all negative numbers.
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Input numbers: ");
            var numbers = new List<int>();
            var inputLine = Console.ReadLine();

            while (inputLine != string.Empty)
            {
                var number = int.Parse(inputLine);
                numbers.Add(number);
                inputLine = Console.ReadLine();
            }

            var positiveNumbers = numbers.Where(n => n >= 0).ToList();

            Console.WriteLine("Here are the positive numbers: ");
            positiveNumbers.ForEach(n => Console.Write("{0} ", n));
            Console.WriteLine();
        }
    }
}

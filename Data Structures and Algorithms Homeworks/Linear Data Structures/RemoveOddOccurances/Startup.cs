namespace RemoveOddOccurances
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 6. Write a program that removes from given sequence all numbers that occur odd number of times.
    /// Example:
    /// {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
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

            var occurances = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!occurances.ContainsKey(number))
                {
                    occurances.Add(number, 1);
                }
                else
                {
                    occurances[number]++;
                }
            }

            var numberWithEvenNumberOfOccurances = occurances.Where(n => n.Value % 2 == 0).Select(n => n.Key).ToList();

            Console.WriteLine("Here are the numbers with even number of occurances: ");
            numberWithEvenNumberOfOccurances.ForEach(n => Console.Write("{0} ", n));
            Console.WriteLine();
        }
    }
}

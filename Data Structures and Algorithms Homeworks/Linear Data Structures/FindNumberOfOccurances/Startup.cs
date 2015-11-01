namespace FindNumberOfOccurances
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 7. Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
    /// Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
    /// 2 → 2 times
    /// 3 → 4 times
    /// 4 → 3 times
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

            Console.WriteLine("Here are the number of occurances: ");
            foreach (var occurance in occurances)
            {
                Console.WriteLine("{0} -> {1} times", occurance.Key, occurance.Value);
            }
        }
    }
}

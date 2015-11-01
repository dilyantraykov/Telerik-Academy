namespace SortNumbers
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 3. Write a program that reads a sequence of integers (List<int>)
    /// ending with an empty line and sorts them in an increasing order.
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

            numbers.Sort();
            Console.WriteLine("Here are the sorted numbers: ");
            numbers.ForEach(n => Console.WriteLine(n));
            Console.WriteLine();
        }
    }
}

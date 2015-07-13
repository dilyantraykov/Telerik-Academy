namespace CSharp1ExamTask5
{
    using System;
    using System.Text.RegularExpressions;

    class FindBits
    {
        static void Main()
        {
            int numberToGetTheLast5BitsOf = int.Parse(Console.ReadLine());
            string mostRight5Bits = Convert.ToString((long)numberToGetTheLast5BitsOf, 2).PadLeft(5, '0');

            int numbersCount = int.Parse(Console.ReadLine());
            string[] numbers = new string[numbersCount];

            int count = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                // convert the number into its 29-bits string equivalent
                numbers[i] = Convert.ToString(long.Parse(Console.ReadLine()), 2).PadLeft(29, '0');
                string testBits = "(?=" + mostRight5Bits + ")";
                count += Regex.Matches(numbers[i], @testBits).Count;
            }

            Console.WriteLine(count);
        }
    }
}

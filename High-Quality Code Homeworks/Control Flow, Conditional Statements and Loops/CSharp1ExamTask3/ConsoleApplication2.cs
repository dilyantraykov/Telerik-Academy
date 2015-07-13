namespace CSharp1ExamTask3
{
    using System;
    using System.Numerics;

    public class ConsoleApplication2
    {
        public static void Main()
        {
            string[] numbers = new string[10000];
            BigInteger totalProductBefore10 = 1;
            BigInteger totalProductAfter10 = 1;
            bool moreThan10 = false;

            for (int i = 0; i < 10000; i++)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                numbers[i] = input;

                if (i % 2 == 0)
                {
                    long product = 1;
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[j] != '0')
                        {
                            product *= int.Parse(input[j].ToString());
                        }
                    }

                    if (i < 10)
                    {
                        totalProductBefore10 *= product;
                    }
                    else
                    {
                        moreThan10 = true;
                        totalProductAfter10 *= product;
                    }
                }
            }

            Console.WriteLine(totalProductBefore10);

            if (moreThan10)
            {
                Console.WriteLine(totalProductAfter10);
            }
        }
    }
}

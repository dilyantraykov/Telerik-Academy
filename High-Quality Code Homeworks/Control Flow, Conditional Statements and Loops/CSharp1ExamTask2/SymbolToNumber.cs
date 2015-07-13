namespace CSharp1ExamTask2
{
    using System;

    public class SymbolToNumber
    {
        public static void Main()
        {
            int secret = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '@')
                {
                    break;
                }

                double encodedValue = 0;
                var currentSum = 0;

                if ('0' <= text[i] && text[i] <= '9')
                {
                    currentSum = text[i] + secret + 500;
                }
                else if (('A' <= text[i] && text[i] <= 'Z') || ('a' <= text[i] && text[i] <= 'z'))
                {
                    currentSum = (text[i] * secret) + 1000;
                }
                else
                {
                    currentSum = text[i] - secret;
                }

                encodedValue += currentSum;

                if (i % 2 == 0)
                {
                    encodedValue /= 100;
                    Console.WriteLine("{0:F2}", encodedValue);
                }
                else
                {
                    encodedValue *= 100;
                    Console.WriteLine("{0}", encodedValue);
                }
            }
        }
    }
}

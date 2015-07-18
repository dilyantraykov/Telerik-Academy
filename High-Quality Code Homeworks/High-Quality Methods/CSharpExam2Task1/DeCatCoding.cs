namespace CSharpExam2Task1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DeCatCoding
    {
        private const int FirstBase = 21;
        private const int SecondBase = 26;

        public static void Main()
        {
            string[] words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var finalWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                ulong wordAsNBasedNumber = 0;

                for (int position = words[i].Length - 1; position >= 0; position--)
                {
                    var currentLetterAsInt = (ulong)(words[i][words[i].Length - 1 - position] - 'a');
                    var powerOfBase = Power(FirstBase, position);
                    wordAsNBasedNumber += currentLetterAsInt * powerOfBase;
                }

                var wordInSecondBase = new StringBuilder();

                do
                {
                    var currentLetterInSecondBaseBase = (char)((wordAsNBasedNumber % SecondBase) + 'a');
                    wordInSecondBase.Append(currentLetterInSecondBaseBase);
                    wordAsNBasedNumber /= SecondBase;
                }
                while (wordAsNBasedNumber > 0);

                finalWords.Add(Reverse(wordInSecondBase.ToString()));
            }

            Console.Write(string.Join(" ", finalWords));
        }

        private static ulong Power(ulong number, int power)
        {
            ulong result = 1;

            for (var i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

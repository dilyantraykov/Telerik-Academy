/*
Condition
*/

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        var alphabet = new string[168];
        for (int i = 0; i < 168; i++)
        {
            var firstLetter = i / 26;
            var secondLetter = i % 26;
            if (i < 26)
            {
                alphabet[i] = ((char)('A' + secondLetter)).ToString();

            }
            else
            {
                alphabet[i] = ((char)('a' + firstLetter - 1)).ToString() + (char)('A' + secondLetter);
            }
        }
        for (int i = 167; i >= 0; i--)
        {
            input = input.Replace(alphabet[i], i.ToString() + " ");
        }
        var digits = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        BigInteger numberInDecimal = 0;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            numberInDecimal += int.Parse(digits[digits.Length - 1 - i]) * (long)Math.Pow(168, i);
        }
        Console.WriteLine(numberInDecimal);
    }
}

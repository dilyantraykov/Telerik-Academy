/*
Condition
*/

using System;
using System.Text;
using System.Numerics;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        input = input.ToUpper();
        input = input.Replace("BIN", "1");
        input = input.Replace("OBJEC", "2");
        input = input.Replace("F", "0");
        input = input.Replace("MNTRAVL", "3");
        input = input.Replace("LPVKNQ", "4");
        input = input.Replace("PNWE", "5");
        input = input.Replace("HT", "6");
        var strangeNumber = input;
        BigInteger number = 0;
        for (int i = strangeNumber.Length - 1; i >= 0; i--)
        {
            number += int.Parse(strangeNumber[strangeNumber.Length - 1 - i].ToString()) * (long)Math.Pow(7, i);
        }
        Console.WriteLine(number);
    }
}

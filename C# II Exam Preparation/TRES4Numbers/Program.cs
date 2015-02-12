using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        List<int> digits = new List<int>();
        while(N > 0)
        {
            int digit = (int)(N % 9);
            digits.Add(digit);
            N /= 9;
        }
        digits.Reverse();
        List<string> tres4 = new List<string>();
        foreach (var digit in digits)
        {
            switch(digit)
            {
                case 0:
                    tres4.Add("LON+");
                    break;
                case 1:
                    tres4.Add("VK-");
                    break;
                case 2:
                    tres4.Add("*ACAD");
                    break;
                case 3:
                    tres4.Add("^MIM");
                    break;
                case 4:
                    tres4.Add("ERIK|");
                    break;
                case 5:
                    tres4.Add("SEY&");
                    break;
                case 6:
                    tres4.Add("EMY>>");
                    break;
                case 7:
                    tres4.Add("/TEL");
                    break;
                case 8:
                    tres4.Add("<<DON");
                    break;
            }
        }

        if (digits.Count == 0)
        {
            tres4.Add("LON+");
        }

        foreach (var word in tres4)
        {
            Console.Write(word);
        }
    }
}

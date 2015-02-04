using System;
using System.Numerics;

class Cake
{
    static void Main()
    {
        long A = long.Parse(Console.ReadLine());
        long B = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine());
        long D = long.Parse(Console.ReadLine());
        decimal sum = ((decimal)A / B + (decimal)C / D);
        BigInteger F = (A*D + C*B);
        BigInteger G = (B*D);
        if (sum < 1)
        {
            decimal fraction = sum;
            Console.WriteLine("{0:F22}", fraction);
        }
        else
        {
            long fraction = (long)sum;
            Console.WriteLine(fraction);
        }

        Console.WriteLine("{0}/{1}", F, G);
    }
}

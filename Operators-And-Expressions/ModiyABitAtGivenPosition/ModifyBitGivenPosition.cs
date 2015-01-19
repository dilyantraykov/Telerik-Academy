// Problem 14. Modify a Bit at Given Position

// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyBitGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Input n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Input p: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Input v: ");
        byte v = byte.Parse(Console.ReadLine());
        int result;
        int mask;
        if (v==0)
        {
            mask = ~(1 << p);
            result = n & mask;
        }
        else
        {
            mask = 1 << p;
            result = n | mask;
        }
        Console.WriteLine("Binary result: " + Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine("Result: " + result);
    }
}

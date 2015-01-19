// Problem 12. Extract Bit from Integer

// Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitInteger
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        Console.WriteLine(bit);
    }
}


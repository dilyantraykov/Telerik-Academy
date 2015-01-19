// Problem 15.* Bits Exchange

// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("n: " + n);
        Console.WriteLine("Binary n: " + Convert.ToString(n, 2).PadLeft(32, '0'));
        // The number 7 represented in binary code is 111
        // 111 moved 3 positions left is 111000 and 111000 & number = the 3rd, 4th and 5th bit
        // We get the 24th, 25th and 26th bit analogously and put both in their own variables
        uint firstThree = (7 << 3) & n;
        uint secondThree = (7 << 24) & n;
        // Move the bits to their desired positions
        firstThree <<= 21;
        secondThree >>= 21;
        // Put zeroes in positions 3, 4, 5 and 24, 25, 26 in number
        n &= ~(7u << Convert.ToInt32(3));
        n &= ~(7u << Convert.ToInt32(24));
        // Add the exchanged bits
        n |= firstThree;
        n |= secondThree;
        Console.WriteLine("Result: " + n);
        Console.WriteLine("Binary result: " + Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}


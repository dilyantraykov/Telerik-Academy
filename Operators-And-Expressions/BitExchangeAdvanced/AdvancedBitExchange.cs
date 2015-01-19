// Problem 16.** Bit Exchange (Advanced)

// Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
// The first and the second sequence of bits may not overlap.

using System;

class AdvancedBitExchange
{
    static uint BitExchange(uint n, sbyte p, sbyte q, sbyte k)
    {
        uint firstThree;
        uint secondThree;
        sbyte bigger, smaller;
        if (p < q || p == q) // see which number is bigger
        {
            smaller = p;
            bigger = q;
        }
        else
        {
            smaller = q;
            bigger = p;
        }
        string str = null;
        for (int i = 0; i < k; i++)
        {
            str += "1"; // get the number of bits that need to be copied and turn them into 11111... (1 k times)
        }
        uint bin = Convert.ToUInt32(str, 2); // convert that binary number to a decimal number
        firstThree = (bin << smaller) & n; // get the first k bits from n
        secondThree = (bin << bigger) & n; // get the second k bits from n
        firstThree <<= bigger - smaller; // move first bits into the place of the second bits
        secondThree >>= bigger - smaller; // move second bits into the place of the first bits
        n &= ~(bin << Convert.ToInt32(smaller)); // put zeros in the places of the first bits in number n
        n &= ~(bin << Convert.ToInt32(bigger)); // put zeros in the places of the second bits in number n
        n |= firstThree; // place the first bits in place
        n |= secondThree; // place the second bits in place
        return n;
    }

    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        sbyte p = sbyte.Parse(Console.ReadLine());
        sbyte q = sbyte.Parse(Console.ReadLine());
        sbyte k = sbyte.Parse(Console.ReadLine());
        if (Math.Abs(p) + Math.Abs(k) > 32 || Math.Abs(q) + Math.Abs(k) > 32) // check if bits are out of range
        {
            Console.WriteLine("out of range");
        }
        else
        {
            if (((p < q || p == q) && p + k > q) || ((p > q) && (q + k > p))) // check if bits are overlapping
            {
                Console.WriteLine("overlapping");
            }
            else
            {
                Console.WriteLine("n: " + n);
                Console.WriteLine("Binary n: " + Convert.ToString(n, 2).PadLeft(32, '0'));
                uint result = BitExchange(n, p, q, k); // do the magic
                Console.WriteLine("Result: " + result);
                Console.WriteLine("Binary result: " + Convert.ToString(result, 2).PadLeft(32, '0'));
            }
        }
    }
}


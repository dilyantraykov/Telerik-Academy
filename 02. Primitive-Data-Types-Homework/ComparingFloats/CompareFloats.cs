// Problem 13.* Comparing Floats
   
// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;

class CompareFloats
{
    private static void equalFloats(double a, double b)
    {
        double eps = 0.000001;
        if (Math.Abs(a - b) < eps)
        {
            Console.WriteLine(a + " = " + b + ": True");
        }
        else
        {
            Console.WriteLine(a + " = " + b + ": False");
        }
    }
    static void Main()
    {
        double a = 5.3;
        double b = 6.01;
        equalFloats(a, b);
        a = 5.00000001;
        b = 5.00000003;
        equalFloats(a, b);
        a = 5.00000005;
        b = 5.00000001;
        equalFloats(a, b);
        a = -0.0000007;
        b = 0.00000007;
        equalFloats(a, b);
        a = -4.999999;
        b = -4.999998;
        equalFloats(a, b);
        a = 4.999999;
        b = 4.999998;
        equalFloats(a, b);
    }
}


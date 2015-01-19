// Problem 5. Third Digit is 7?

// Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigit7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine((n/100)%10 == 7 ? "true" : "false");
    }
}

// Problem 6. Four-Digit Number

// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
// Prints on the console the number in reversed order: dcba (in our example 1102).
// Puts the last digit in the first position: dabc (in our example 1201).
// Exchanges the second and the third digits: acbd (in our example 2101).
// The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigit
{
    static void Main()
    {
        Console.WriteLine("Insert 4-digit number: ");
        ushort n = ushort.Parse(Console.ReadLine());
        int a = (n / 1000) % 10;
        int b = (n / 100) % 10;
        int c = (n / 10) % 10;
        int d = n % 10;
        int sum = a + b + c + d;
        int reversed = d * 1000 + c * 100 + b * 10 + a;
        int lastDigitFirst = d * 1000 + a * 100 + b * 10 + c;
        int secondDigitThird = a * 1000 + c * 100 + b * 10 + d;
        Console.WriteLine("Sum: " + sum + "\nReversed: " + reversed +
            "\nLast digit in first position: " + lastDigitFirst + 
            "\nSecond digit in third position: " + secondDigitThird);
    }
}


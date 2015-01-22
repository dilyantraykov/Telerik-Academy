//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©

using System;

class Triangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("   \u00A9");
        Console.WriteLine();
        Console.WriteLine("  \u00A9 \u00A9");
        Console.WriteLine();
        Console.WriteLine(" \u00A9   \u00A9");
        Console.WriteLine();
        Console.WriteLine("\u00A9 \u00A9 \u00A9 \u00A9");
    }
}

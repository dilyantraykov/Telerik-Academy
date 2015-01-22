// Problem 4. Multiplication Sign

// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

using System;

class Sign
{
    static void Main()
    {
        Console.WriteLine("Insert a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The sign of the operation is:");
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else if (a > 0)
        {
            if (b > 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (b < 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
        else if (b > 0)
        {
            if (a > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
        else if (c > 0)
        {
            if (a < 0 && b < 0)
            {
                Console.WriteLine("+");

            }
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}


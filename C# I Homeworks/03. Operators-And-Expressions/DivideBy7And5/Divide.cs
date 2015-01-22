// Problem 3. Divide by 7 and 5

// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class Divide
{
    static void Main()
    {
        Console.WriteLine("Insert n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Can n be devided by 5 and 7?");
        Console.WriteLine((n % 7 == 0) && (n % 5) == 0 && (n!=0) ? "Yes!" : "No!");
    }
}


// Problem 7. Point in a Circle

// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Insert x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert y: ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine((x*x+y*y <= 4) ? "true" : "false");
        char sex = char.Parse(Console.ReadLine());
    }
}


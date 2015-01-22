// Problem 3. Circle Perimeter and Area

// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class PrintCirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Insert the radius of the circle: ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter: {0:F2}", 2*Math.PI*r);
        Console.WriteLine("Area: {0:F2}", Math.PI*r*r);
    }
}


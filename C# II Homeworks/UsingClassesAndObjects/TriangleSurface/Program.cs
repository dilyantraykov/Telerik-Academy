/*
Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
    Side and an altitude to it;
    Three sides;
    Two sides and an angle between them;
Use System.Math
*/

using System;

class Program
{
    static void Main()
    {
        double surface = 0;
        Console.WriteLine("Choose method to find surface: ");
        Console.WriteLine("1. Side and an altitude to it");
        Console.WriteLine("2. Three sides");
        Console.WriteLine("3. Two sides and an angle between them");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.Write("Enter the side of the triangle: ");
                double side = double.Parse(Console.ReadLine());
                Console.Write("Enter the altitude of the triangle: ");
                double altitude = double.Parse(Console.ReadLine());
                surface = side * altitude / 2;
                break;
            case 2:
                Console.Write("Enter side #1 of the triangle: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Enter side #2 of the triangle: ");
                double side2 = double.Parse(Console.ReadLine());
                Console.Write("Enter side #3 of the triangle: ");
                double side3 = double.Parse(Console.ReadLine());
                double p = (side1 + side2 + side3) / 2;
                surface = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
                break;
            case 3:
                Console.Write("Enter side #1 of the triangle: ");
                side1 = double.Parse(Console.ReadLine());
                Console.Write("Enter side #2 of the triangle: ");
                side2 = double.Parse(Console.ReadLine());
                Console.Write("Enter the angle of the triangle: ");
                double angleInDegrees = double.Parse(Console.ReadLine());
                double angleInRadians = Math.PI * angleInDegrees / 180.0;
                surface = (side1 * side2 * Math.Sin(angleInRadians)) / 2;
                break;
            default:
                Console.WriteLine("Invalid input!");
                return;
        }
        Console.WriteLine("The surface is {0:F3}", surface);

    }
}


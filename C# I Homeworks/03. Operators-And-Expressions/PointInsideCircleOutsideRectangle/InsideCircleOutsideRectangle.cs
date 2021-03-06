﻿// Problem 10. Point Inside a Circle & Outside of a Rectangle

// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class InsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine("Insert point x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert point y: ");
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = (x-1)*(x-1) + (y-1)*(y-1) <= 1.5*1.5;
        bool isInRectangle = (x<=5 && x>=-1 && y<=1 && y>=-1);
        Console.WriteLine("Is the point inside the circle and outside the rectangle?");
        if (isInCircle && !isInRectangle)
        {
            Console.WriteLine("Yes!");
        }
        else
        {
            Console.WriteLine("No!");
        }
    }
}


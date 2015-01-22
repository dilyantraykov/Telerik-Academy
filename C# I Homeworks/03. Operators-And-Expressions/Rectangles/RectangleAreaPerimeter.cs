// Problem 4. Rectangles

// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class RectangleAreaPerimeter
{
    static void Main()
    {
        Console.WriteLine("Insert rectangle width: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert rectangle height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Rectangle Perimeter: " + 2 * (width + height));
        Console.WriteLine("Rectangle Area: " + width * height);
    }
}

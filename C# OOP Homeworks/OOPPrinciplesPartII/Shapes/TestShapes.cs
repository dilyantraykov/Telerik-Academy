using System;
using System.Collections.Generic;

namespace Shapes
{
    class TestShapes
    {
        public static void Main()
        {
            var shapes = new List<Shape>()
            {
                new Rectangle(5, 6),
                new Square(5),
                new Triangle(6,2)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name + " Area: " + shape.CalculateSurface());
            }
        }
    }
}

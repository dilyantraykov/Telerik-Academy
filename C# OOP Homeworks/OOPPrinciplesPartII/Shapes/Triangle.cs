using System;

namespace Shapes
{
    class Triangle : Shape
    {
        public Triangle(double initialWidth, double initialHeight)
            : base(initialWidth, initialHeight)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height) / 2;
        }
    }
}

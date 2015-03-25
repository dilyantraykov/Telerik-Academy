using System;

namespace Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double initialWidth, double initialHeight)
            : base(initialWidth, initialHeight)
        {
            this.Width = initialWidth;
            this.Height = initialHeight;
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}

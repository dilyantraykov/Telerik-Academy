using System;

namespace Shapes
{
    class Square : Shape
    {
        public Square(double initialWidth)
            : base(initialWidth, initialWidth)
        {
            this.Width = initialWidth;
            this.Height = initialWidth;
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}

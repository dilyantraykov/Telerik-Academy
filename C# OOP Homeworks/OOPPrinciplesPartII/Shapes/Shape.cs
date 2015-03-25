using System;

namespace Shapes
{
    public abstract class Shape
    {
        protected double width;
        protected double height;

        protected Shape(double initialWidth, double initialHeight)
        {
            this.Width = initialWidth;
            this.Height = initialHeight;
        }

        public double Width
        {
            get { return this.width; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width should be positive!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height should be positive!");
                }
                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}

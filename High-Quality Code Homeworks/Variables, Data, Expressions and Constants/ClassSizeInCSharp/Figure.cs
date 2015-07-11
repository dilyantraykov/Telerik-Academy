namespace Figures
{
    using System;

    public class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height");
                }

                this.height = value;
            }
        }

        public static Figure GetRotatedFigure(Figure figure, double angleOfRotation)
        {
            var absoluteCosine = Math.Abs(Math.Cos(angleOfRotation));
            var absoluteSine = Math.Abs(Math.Sin(angleOfRotation));

            var cosineTimesWidth = absoluteCosine * figure.width;
            var sineTimesHeight = absoluteSine * figure.height;
            var sineTimesWidth = absoluteSine * figure.width;
            var cosineTimesHeight = absoluteCosine * figure.height;

            var figureWidth = cosineTimesWidth + sineTimesHeight;
            var figureHeight = sineTimesWidth + cosineTimesHeight;

            var rotatedFigure = new Figure(figureWidth, figureHeight);

            return rotatedFigure;
        }
    }
}

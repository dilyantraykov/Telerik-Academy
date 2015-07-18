namespace CohesionAndCoupling
{
    using System;

    public class Utils2D
    {
        public static double Width { get; set; }

        public static double Height { get; set; }

        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            var deltaX = (x2 - x1) * (x2 - x1);
            var deltaY = (y2 - y1) * (y2 - y1);
            double distance = Math.Sqrt(deltaX + deltaY);
            return distance;
        }

        public static double CalcDiagonalXY()
        {
            double distance = CalcDistance2D(0, 0, Width, Height);
            return distance;
        }

        public static double CalcDiagonalXZ()
        {
            double distance = CalcDistance2D(0, 0, Width, Utils3D.Depth);
            return distance;
        }

        public static double CalcDiagonalYZ()
        {
            double distance = CalcDistance2D(0, 0, Height, Utils3D.Depth);
            return distance;
        }
    }
}

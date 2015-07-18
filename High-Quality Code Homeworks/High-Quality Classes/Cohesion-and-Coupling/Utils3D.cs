namespace CohesionAndCoupling
{
    using System;

    public class Utils3D : Utils2D
    {
        public static double Depth { get; set; }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            var deltaX = (x2 - x1) * (x2 - x1);
            var deltaY = (y2 - y1) * (y2 - y1);
            var deltaZ = (z2 - z1) * (z2 - z1);
            double distance = Math.Sqrt(deltaX + deltaY + deltaZ);
            return distance;
        }

        public static double CalcDiagonalXYZ()
        {
            double distance = CalcDistance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        public static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }
    }
}

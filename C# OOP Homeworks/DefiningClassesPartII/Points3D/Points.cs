using System;

namespace Points3D
{
    public static class Distance
    {
        public static double GetDistance(Point3D p1, Point3D p2)
        {
            var xd = p2.X - p1.X;
            var yd = p2.Y - p1.Y;
            var zd = p2.Z - p1.Z;
            return Math.Sqrt(xd*xd + yd*yd + zd*zd);
        }
    }

    public struct Point3D
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static Point3D O
        {
            get { return o; }
        }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            var result = String.Format("({0}, {1}, {2})", this.X, this. Y, this.Z);
            return result;
        }
    }
}

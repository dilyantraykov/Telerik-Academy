using System;

namespace Points3D
{
    public class TestPoints3D
    {
        static void Main()
        {
            var p1 = new Point3D(2, 1, 4);
            Console.WriteLine("Point 1: {0}", p1);
            Console.WriteLine("Point O: {0}", Point3D.O);

            Console.WriteLine();
            Console.WriteLine("Distance between points 1 and O: {0}", Distance.GetDistance(p1, Point3D.O));

            var path1 = new Path(p1, Point3D.O);
            Console.WriteLine();
            Console.WriteLine("Path to save: {0}", path1);

            PathStorage.Save(path1, "MyPath");
            Console.WriteLine();
            Console.WriteLine("Loaded path: {0}", PathStorage.Load("MyPath"));
        }
    }
}

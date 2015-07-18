using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Utils2D.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Utils3D.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Utils2D.Width = 3;
            Utils2D.Height = 4;
            Utils3D.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", Utils3D.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Utils3D.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", Utils2D.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", Utils2D.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", Utils2D.CalcDiagonalYZ());
        }
    }
}

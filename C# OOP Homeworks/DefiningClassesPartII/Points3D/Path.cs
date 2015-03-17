namespace Points3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Path
    {
        private readonly List<Point3D> _points;

        public Path(params Point3D[] points)
        {
            this._points = new List<Point3D>();
            foreach (var point3D in points)
            {
                this._points.Add(point3D);
            }
        }

        public Path(IEnumerable<Point3D> points)
        {
            this._points = points.Select(x => x).ToList();
        }

        public int Count
        {
            get
            {
                return this._points.Count;
            }
        }

        public Point3D this[int index]
        {
            get
            {
                return this._points[index];
            }
            set
            {
                this._points[index] = value;
            }
        }

        public void AddPoint(Point3D p)
        {
            this._points.Add(p);
        }

        public override string ToString()
        {
            return String.Join(" -> ", this._points);
        }
    }

    public static class PathStorage
    {
        private const string dir = @"..\..\Paths";

        public static void Save(Path path, string pathName)
        {
            bool exists = Directory.Exists(dir);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            var fileName = String.Format("{0}\\{1}.txt", dir, pathName.Trim());
            using (var writer = new StreamWriter(fileName))
            {
                writer.Write(path);
            }
        }

        public static Path Load(string pathName)
        {
            var path = new Path();
            var fileName = String.Format("{0}\\{1}.txt", dir, pathName.Trim());

            try
            {
                using (var reader = new StreamReader(fileName))
                {
                    var allPoints = reader.ReadToEnd().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var point in allPoints)
                    {
                        var coordinates = point.Trim('(').Trim(')')
                            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => double.Parse(x))
                            .ToArray();

                        path.AddPoint(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.Write("The path \"{0}\" cannot be found.", pathName);
                return null;
            }

            return path;
        }
    }
}

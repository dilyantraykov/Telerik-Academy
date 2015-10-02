namespace TraverseDirectoryWithXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    class TraverseDirectory
    {
        static void Main()
        {
            string dirPath = "D:/Programming/FoodStore/"; // change with a valid folder on your system
            var dir = Traverse(dirPath);
            dir.Save("../../directory.xml");
            Console.WriteLine("Result saved in directory.xml");
        }

        static XElement Traverse(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(Traverse(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                element.Add(new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("ext", Path.GetExtension(file))));
            }

            return element;
        }
    }
}

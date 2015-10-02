namespace TraverseDirectory
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    class TraverseDirectory
    {
        static void Main()
        {
            using (XmlTextWriter writer = new XmlTextWriter("../../directory.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 2;

                string dirPath = "D:/Programming/FoodStore/"; // change with a valid folder on your system

                writer.WriteStartDocument();
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", dirPath);
                Traverse(dirPath, writer);
                writer.WriteEndDocument();
            }

            Console.WriteLine("Result saved in directory.xml");
        }

        static void Traverse(string dir, XmlTextWriter writer)
        {
            foreach (var directory in Directory.GetDirectories(dir))
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", directory);
                Traverse(directory, writer);
                writer.WriteEndElement();
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", Path.GetFileNameWithoutExtension(file));
                writer.WriteAttributeString("ext", Path.GetExtension(file));
                writer.WriteEndElement();
            }
        }
    }
}

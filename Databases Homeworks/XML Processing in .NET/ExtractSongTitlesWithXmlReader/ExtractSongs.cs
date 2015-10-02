namespace ExtractSongTitlesWithXmlReader
{
    using System;
    using System.Xml;

    class ExtractSongs
    {
        static void Main(string[] args)
        {
            using (XmlReader reader = XmlReader.Create("../../../catalog.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}

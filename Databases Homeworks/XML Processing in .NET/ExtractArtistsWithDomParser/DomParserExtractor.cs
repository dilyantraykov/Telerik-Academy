namespace ExtractArtistsWithDomParser
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class DomParserExtractor
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");

            XmlElement catalogNode = doc.DocumentElement;

            foreach (var pair in ExtractDifferentArtists(catalogNode))
            {
                Console.WriteLine("{0} has {1} album(s)", pair.Key, pair.Value);
            }
        }

        private static Dictionary<string, int> ExtractDifferentArtists(XmlElement root)
        {
            var catalog = new Dictionary<string, int>();
            var artists = root.GetElementsByTagName("artist");

            foreach (XmlElement artist in artists)
            {
                var artistName = artist.InnerText;

                if (catalog.ContainsKey(artistName))
                {
                    catalog[artistName] += 1;
                }
                else
                {
                    catalog.Add(artistName, 1);
                }
            }

            return catalog;
        }
    }
}

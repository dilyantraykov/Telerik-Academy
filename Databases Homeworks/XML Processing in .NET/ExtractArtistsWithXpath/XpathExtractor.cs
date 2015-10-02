using System;
using System.Collections.Generic;
using System.Xml;

namespace ExtractArtistsWithXpath
{
    class XpathExtractor
    {
        static void Main(string[] args)
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
            var query = "/catalog/album/artist";
            var artists = root.SelectNodes(query);

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

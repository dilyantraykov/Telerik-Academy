namespace ExtractOldAlbumPrices
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class AlbumsExtractor
    {
        static void Main()
        {
            var doc = XDocument.Load("../../../catalog.xml");

            var albumPrices = from album in doc.Descendants("album")
                             where int.Parse(album.Element("year").Value) < 2010
                             select album.Element("price").Value;

            Console.WriteLine(string.Join(Environment.NewLine, albumPrices));
        }
    }
}

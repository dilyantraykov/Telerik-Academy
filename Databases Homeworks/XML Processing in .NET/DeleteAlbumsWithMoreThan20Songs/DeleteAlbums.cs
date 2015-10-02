namespace DeleteAlbumsWithMoreThan20Songs
{
    using System;
    using System.Xml;

    class DeleteAlbums
    {
        static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../../catalog.xml");
            var root = doc.DocumentElement;

            DeleteAlbumsWithPriceMoreThanX(root, 20.0m);
            doc.Save("../../newCatalog.xml");
            Console.WriteLine("Catalog saved as newCatalog.xml");
        }

        private static void DeleteAlbumsWithPriceMoreThanX(XmlElement root, decimal maxPrice)
        {
            var xmlNodeList = root.SelectNodes("album");

            if (xmlNodeList == null)
            {
                return;
            }

            foreach (XmlElement album in xmlNodeList)
            {
                var xmlElement = album["price"];
                if (xmlElement == null)
                {
                    continue;
                }

                var xmlPrice = xmlElement.InnerText;
                var albumPrice = decimal.Parse(xmlPrice);

                if (albumPrice > maxPrice)
                {
                    root.RemoveChild(album);
                }
            }
        }
    }
}

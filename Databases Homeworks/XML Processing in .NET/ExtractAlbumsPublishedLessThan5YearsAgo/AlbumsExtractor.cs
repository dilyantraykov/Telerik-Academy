namespace ExtractAlbumsPublishedLessThan5YearsAgo
{
    using System;
    using System.Xml;

    class AlbumsExtractor
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");
            var query = "/catalog/album[year<2010]/price";

            var albumPrices = doc.SelectNodes(query);

            foreach (XmlNode price in albumPrices)
            {
                Console.WriteLine(price.InnerText);
            }
        }
    }
}

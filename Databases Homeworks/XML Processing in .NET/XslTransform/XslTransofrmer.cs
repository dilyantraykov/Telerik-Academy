namespace XslTransform
{
    using System;
    using System.Xml.Xsl;

    class XslTransofrmer
    {
        static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../catalog.xslt");
            xslt.Transform("../../../catalog.xml", "../../catalog.html");
            Console.WriteLine("Result saved as catalog.html");
        }
    }
}

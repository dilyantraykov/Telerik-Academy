using System;
using System.IO;
using System.Xml.Linq;

namespace ExtractPersonInfo
{
    class PersonInfo
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = new StreamReader("../../person.txt"))
            {
                var personElement = new XElement("person",
                    new XElement("name", reader.ReadLine()),
                    new XElement("address", reader.ReadLine()),
                    new XElement("phone", reader.ReadLine()));

                Console.WriteLine("Person saved in person.xml");
                personElement.Save("../../person.xml");
            }
        }
    }
}

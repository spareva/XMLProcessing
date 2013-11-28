using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace XML
{
    class Program
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Catalogue.xml");
            XmlNode rootNode = doc.DocumentElement;

            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach (XmlNode album in rootNode.ChildNodes)
            {
                var price = album["price"].InnerText;

                if (decimal.Parse(price) > 20)
                {
                    rootNode.RemoveChild(album);
                }
            }
            doc.Save("newCatalogue.xml");
        }
    }
}

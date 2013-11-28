using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Xsl;

namespace XML
{
    class Program
    {
        static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../catalogue.xslt");
            xslt.Transform("../../catalogue.xml", "../../catalogue.html");

            XmlDocument doc = new XmlDocument();
            doc.Load("Catalogue.xml");
            XmlNode rootNode = doc.DocumentElement;

            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach (XmlNode album in rootNode.ChildNodes)
            {
                var artist = album["artist"].InnerText;

                if (!dic.ContainsKey(artist))
                {
                    dic.Add(artist, 1);
                }
                else
                {
                    dic[artist]++;
                }
            }

            foreach (var artistInfo in dic)
            {
                Console.WriteLine("{0} has {1} albums.", artistInfo.Key, artistInfo.Value);
            }
        }
    }
}

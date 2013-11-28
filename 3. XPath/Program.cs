using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _3.XPath
{
    class Program
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Catalogue.xml");
            XmlNode root = doc.DocumentElement;

            Dictionary<string, int> list = new Dictionary<string, int>();

            XmlNodeList albums = doc.SelectNodes("catalogue/album");

            foreach (XmlNode album in albums)
            {
                string artistName = album.SelectSingleNode("artist").InnerText;

                if (!list.ContainsKey(artistName))
                {
                    list.Add(artistName, 1);
                }
                else
                {
                    list[artistName]++;
                }
            }

            foreach (var artistInfo in list)
            {
                Console.WriteLine("{0} has {1} albums.", artistInfo.Key, artistInfo.Value);
            }
        }
    }
}

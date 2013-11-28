using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractPriceLINQ
{
    class Program
    {
        static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../catalogue.xml");

            var albums =
                from album in xmlDoc.Descendants("album")
                where int.Parse(album.Element("year").Value) < 2008
                select new
                {
                    Title = album.Element("name").Value,
                    Price = album.Element("price").Value
                };
            Console.WriteLine("Found {0} albums:", albums.Count());
            foreach (var album in albums)
            {
                Console.WriteLine("{0} -> Price {1}", album.Title, album.Price);
            }
        }
    }
}

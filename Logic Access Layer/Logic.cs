using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Access_Layer
{

    public class XML_reader
    {
        public void XMLfeeder ()
        {
            //Ladda hem XML.
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString("http://www.aftonbladet.se/rss.xml");
            }

            //Skapa en objektrepresentation.
            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);

            //Iterera igenom elementet item.
            foreach (System.Xml.XmlNode item
               in dom.DocumentElement.SelectNodes("channel/item"))
            {
                //Skriv ut dess titel.
                var title = item.SelectSingleNode("title");
                Console.WriteLine(title.InnerText);
            }

        }

        class Category
        {
            List<Category> categories = new List<Category>
            {
                new Category ("Hälsa"),
                new Category ("Programmering"),
                new Category ("Vetenskap")
            };


            public Category(string kategori)
            {
                Kategori = kategori;
            }

            public string Kategori { get; set; }

            public override string ToString()
            {
                return Kategori.ToString();
            }

            internal void addCategory (string kategori)
            {
                categories.Add(new Category

            }
        }
    }
}

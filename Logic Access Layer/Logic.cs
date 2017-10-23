using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Text;
using System.Xml;
using System.Linq;
using Data.Entities;

namespace Logic_Access_Layer
{

    
    
        internal class RSSReader : IReader
        {
            
        public IEnumerabe<FeedItem> Read (string url)
            {
        
            var xml = "";
            var feedItems = new List<FeedItem>();
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);
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
                var publishDate = item.SelectSingleNode("pubDate").InnerText;
                var id = Guid.NewGuid();
                XmlNodeList link = item.SelectNodes ("link");
                var links = link.cast<XmlNode>()
                    .Select(node => node.innerText)
                    .ToList();

                var feedItem = new FeedItem() { title = title, id = id, Links = links, publishDate = publishDate};
                feedItems.Add(feedItem);
            }

            return feedItems;
        }

       
        }
    }


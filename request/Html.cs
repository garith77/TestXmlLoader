using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace request
{
    public class Html
    {
        public void HtmlPackage()
        {
            /*
             *  http://stackoverflow.com/questions/4935446/string-to-htmldocument
             *  http://htmlagilitypack.codeplex.com/
             *  http://htmlagilitypack.codeplex.com/wikipage?title=Examples
             *  
            */

            //HtmlDocument doc = new HtmlDocument();
            //doc.Load("Xml.html");

            //foreach(HtmlNode link in doc.DocumentNode.ChildNodes["p"])
            //{
            //    var test = link.InnerHtml;
            //}
            //doc.Save("file.htm");


            HtmlDocument htmldoc = new HtmlDocument();
            htmldoc.Load("Xml.html");
            HtmlNodeCollection linkNodes = htmldoc.DocumentNode.SelectNodes("//div");
            var meh = "";
            foreach (HtmlNode linkNode in linkNodes)
            {
                if (linkNode.Name.Equals("p"))
                {
                    meh = linkNode.InnerText;
                }
            }


            //var firstSubmainNodeName = doc
            //.DocumentNode
            //.Descendants()
            //.Where(n => n.Attributes["class"].Value == "submain")
            //.First()
            //.InnerText;



            //HtmlAgilityPack.HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//div[@class=\"submain\"]");
            //foreach (HtmlAgilityPack.HtmlNode node in nodes)
            //{
            //    //Do you say you want to access to <h2>, <p> here?
            //    //You can do:
            //    HtmlNode h2Node = node.SelectSingleNode("./p"); //That will get the first <h2> node
            //    //HtmlNode allH2Nodes = node.SelectNodes(".//p"); //That will search in depth too

            //    //And you can also take a look at the children, without using XPath (like in a tree):        
            //    //HtmlNode h2Node = node.ChildNodes["div"];
            //}

        }
    }
}

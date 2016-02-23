using request.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace request
{
    public class Xml
    {
        public void XmlCriteria()
        {
            //Create Xml document
            XmlDocument XMLDoc = new XmlDocument();
            //Load Xml into Document
            XMLDoc.Load("http://sandbox.training.gov.au/TrainingComponentFiles/ICT/ICTPRG507_R1.xml");

            // create a writer and open the file
            TextWriter tw = new StreamWriter("Xml.html");

            //Select each node with Topic element name
            XmlNodeList NodeList = XMLDoc.GetElementsByTagName("Topic");
            //Go through each node
            foreach (XmlNode Node in NodeList)
            {
                //Surround each Topic
                tw.WriteLine("<div>");
                //Select the nodes I want information from
                XmlNode headingNodes = Node["Object"];
                XmlNode textNodes = Node["Text"];
                //Title of each element
                tw.WriteLine("<h1>");
                tw.WriteLine(headingNodes["Description"].InnerText);
                tw.WriteLine("</h1>");
                //The body of text In each element
                XmlNodeList textElements = textNodes.ChildNodes;
                if (textElements.Count >= 1)
                {
                    foreach (XmlNode firstLayer in textElements)
                    {
                        //If there is a table in the element
                        if (firstLayer.Name.Equals("table"))
                        {
                            tw.WriteLine("<table>");
                            foreach (XmlNode secondLayer in firstLayer)
                            {
                                if (secondLayer.Name.Equals("tr"))
                                {
                                    //each row
                                    tw.WriteLine("<tr>");
                                    foreach (XmlNode thirdLayer in secondLayer)
                                    {
                                        if (thirdLayer.Name.Equals("td") && !thirdLayer.InnerText.Equals(""))
                                        {
                                            //Each column
                                            tw.WriteLine("<td>");
                                            foreach (XmlNode fourthLayer in thirdLayer)
                                            {
                                                //Body of Text
                                                tw.WriteLine("<p>");
                                                if (!fourthLayer.InnerText.Equals(""))
                                                {
                                                    tw.WriteLine(fourthLayer.InnerText);
                                                }
                                                tw.WriteLine("</p>");
                                            }
                                            tw.WriteLine("</td>");
                                        }
                                    }
                                    tw.WriteLine("</tr>");
                                }
                            }
                            tw.WriteLine("</table>");
                        }
                        //If there is no table in the element
                        else
                        {
                            //Body of text
                            if (!firstLayer.InnerText.Equals(""))
                            {                            
                                tw.WriteLine("<p>");
                                tw.WriteLine(firstLayer.InnerText);
                                tw.WriteLine("</p>");
                            }
                        }
                    }
                }
                tw.WriteLine("</div>");
            }
            //Close text reader
            tw.Close();
            Console.WriteLine("Completed Xml data transfer");
        }

        //Thinking can just put the one method and pass in a string with the link
        public void XmlAssesment()
        {
            //Create Xml document
            XmlDocument XMLDoc = new XmlDocument();
            //Load Xml into Document
            XMLDoc.Load("http://sandbox.training.gov.au/TrainingComponentFiles/ICT/ICTPRG507_AssessmentRequirements_R1.xml");

            // create a writer and open the file
            TextWriter tw = new StreamWriter("Xml.html");

            //Select each node with Topic element name
            XmlNodeList NodeList = XMLDoc.GetElementsByTagName("Topic");
            //Go through each node
            foreach (XmlNode Node in NodeList)
            {
                //Surround each Topic
                tw.WriteLine("<div>");
                //Select the nodes I want information from
                XmlNode headingNodes = Node["Object"];
                XmlNode textNodes = Node["Text"];
                //Title of each element
                tw.WriteLine("<h1>");
                tw.WriteLine(headingNodes["Description"].InnerText);
                tw.WriteLine("</h1>");
                //The body of text In each element
                XmlNodeList textElements = textNodes.ChildNodes;
                if (textElements.Count >= 1)
                {
                    foreach (XmlNode firstLayer in textElements)
                    {
                        //If there is a table in the element
                        if (firstLayer.Name.Equals("table"))
                        {
                            tw.WriteLine("<table>");
                            foreach (XmlNode secondLayer in firstLayer)
                            {
                                if (secondLayer.Name.Equals("tr"))
                                {
                                    //each row
                                    tw.WriteLine("<tr>");
                                    foreach (XmlNode thirdLayer in secondLayer)
                                    {
                                        if (thirdLayer.Name.Equals("td") && !thirdLayer.InnerText.Equals(""))
                                        {
                                            //Each column
                                            tw.WriteLine("<td>");
                                            foreach (XmlNode fourthLayer in thirdLayer)
                                            {
                                                //Body of Text
                                                tw.WriteLine("<p>");
                                                if (!fourthLayer.InnerText.Equals(""))
                                                {
                                                    tw.WriteLine(fourthLayer.InnerText);
                                                }
                                                tw.WriteLine("</p>");
                                            }
                                            tw.WriteLine("</td>");
                                        }
                                    }
                                    tw.WriteLine("</tr>");
                                }
                            }
                            tw.WriteLine("</table>");
                        }
                        //If there is no table in the element
                        else
                        {
                            //Body of text
                            if (!firstLayer.InnerText.Equals(""))
                            {
                                tw.WriteLine("<p>");
                                tw.WriteLine(firstLayer.InnerText);
                                tw.WriteLine("</p>");
                            }
                        }
                    }
                }
                tw.WriteLine("</div>");
            }
            //Close text reader
            tw.Close();
            Console.WriteLine("Completed Xml data transfer");
        }

        //Gets UnitCode details
        public List<UnitCodeModelView> GetUnitCode()
        {
            List<UnitCodeModelView> unitCodeModel = new List<UnitCodeModelView>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Z:\\pls.xml");
            XmlNodeList NodeList = xmlDoc.GetElementsByTagName("Unit");
            string[] unitCodeList = new string[NodeList.Count];
            var count = 1;
            foreach (XmlNode Node in NodeList)
            {
                UnitCodeModelView data = new UnitCodeModelView();
                data.UnitCode = Node["UnitCode"].InnerText;
                data.Name = Node["UnitName"].InnerText;
                data.XmlAssesmentLink = Node["AssesmentRequirments"].InnerText;
                data.XmlCriteriaLink = Node["Elements"].InnerText;
                count++;
                unitCodeModel.Add(data);
            }

            return unitCodeModel;
        }


        //Test Codes
        //****** Not needed
        public void XmlThree()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml("Books.xml"); // suppose that myXmlString contains "<Names>...</Names>"

            XmlNodeList xnList = xml.SelectNodes("/Bookstore/Bookgenre");
            foreach (XmlNode xn in xnList)
            {
                string Genre = xn["title"].InnerText;
                Console.WriteLine(Genre);
            }
        }

        public void XmlFour()
        {
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.Load(@"");
            XmlNodeList NodeList = XMLDoc.SelectNodes("/xml_api_reply/weather/forecast_information/");
            foreach (XmlNode Node in NodeList)
            {
                string DTime = Node["current_date_time"].InnerText;
                //Do something with DTime
            }
        }

        public void XmlFive()
        {
            //Load Xml from website
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.Load("http://sandbox.training.gov.au/TrainingComponentFiles/ICT/ICTPRG507_AssessmentRequirements_R1.xml");

            //Create an XmlNamespaceManager for resolving namespaces.
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(XMLDoc.NameTable);
            nsmgr.AddNamespace("http://www.authorit.com/xml/authorit", "urn:samples");

            //Select and display the value of all the ISBN attributes.
            XmlNodeList nodeList;
            XmlElement root = XMLDoc.DocumentElement;
            nodeList = root.SelectNodes("/authorit/objects/book/@basedon", nsmgr);
            foreach (XmlNode isbn in nodeList)
            {
                Console.WriteLine(isbn.Value);
            }

        }

        public void XmlSix()
        {
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.Load("http://sandbox.training.gov.au/TrainingComponentFiles/ICT/ICTPRG507_AssessmentRequirements_R1.xml");

            //Loads Xml tags of specific name
            XmlNodeList elemList = XMLDoc.GetElementsByTagName("Topic");
            string[] arrayOfItems = new string[elemList.Count];
            for (int i = 0; i < elemList.Count; i++)
            {
                Console.WriteLine(elemList[i].ParentNode.Name);
                arrayOfItems[i] = elemList[i].InnerText;
                Console.WriteLine(elemList[i].InnerText);
                string attrVal = elemList[i].InnerText;
            }
        }

        public void XmlSeven()
        {
            XElement po = XElement.Load("http://sandbox.training.gov.au/TrainingComponentFiles/ICT/ICTPRG507_AssessmentRequirements_R1.xml");
            IEnumerable<XElement> childElements =
                from el in po.Elements()
                select el;
            foreach (XElement el in childElements)
                Console.WriteLine("Name: " + el.Name);
        }

        public void XmlOne()
        {
            XmlTextReader reader = new XmlTextReader("Books.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        //Console.Write("<" + reader.Name);
                        //Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        //Console.Write("</" + reader.Name);
                        //Console.WriteLine(">");
                        break;
                }
            }
        }
    }

}

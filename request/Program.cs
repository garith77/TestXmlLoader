using HtmlAgilityPack;
using Microsoft.Office.Interop.Word;
using request.Model;
using request.TgaTrainingComp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace request
{
    public class Program
    {
        static void Main(string[] args)
        {

            Xml test = new Xml();
            test.XmlAssesment();
            test.XmlCriteria();

            /*

             * http://sandbox.training.gov.au/TrainingComponentFiles/ICT/ICTPRG507_AssessmentRequirements_R1.xml
             * http://sandbox.training.gov.au/TrainingComponentFiles/ICT/ICTPRG507_R1.xml
             * 
             * http://www.freeformatter.com/xml-formatter.html#ad-output

           */

            var x = 1;
            while (x !=0)
            {
                Console.WriteLine("1.Create Word Document , 2. TGA request course details ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Word document = new Word();
                        document.CreateDocumentWithData();
                        break;
                    case 2:
                        TgaRequest newRequest = new TgaRequest();
                        newRequest.Main();
                        break;

                }
            }
        }

        

        

        

        

        
    }
}

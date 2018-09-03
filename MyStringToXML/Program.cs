using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyStringToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bookCategories = new string[] { "web", "child", "cooking", "language" };

            string xmlFileName = @"C:\temp\stringToXml.xml";
            FileStream fileStream = File.Create(xmlFileName);

            XmlWriter xmlWriter = XmlWriter.Create(fileStream, new XmlWriterSettings { Indent = true });

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("bookCategories");

            foreach (var item in bookCategories)
                xmlWriter.WriteElementString("bookCategories", item);

            xmlWriter.WriteEndElement();
            xmlWriter.Dispose();
            fileStream.Dispose();

            long n = new FileInfo(xmlFileName);
        }
    }
}

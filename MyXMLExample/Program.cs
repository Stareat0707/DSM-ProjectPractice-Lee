using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyXMLExample
{
    class Program
    {
        static List<MyPerson> MakePeople()
        {
            var people = new List<MyPerson>
            {
                new MyPerson
                {
                    FirstName = "James",
                    LastName = "Corn",
                    Birthday = DateTime.Now
                },
                new MyPerson
                {
                    FirstName = "Kevin",
                    LastName = "Soo",
                    Birthday = DateTime.Now
                },
                new MyPerson
                {
                    FirstName = "Alice",
                    LastName = "Trivia",
                    Birthday = DateTime.Now
                }
            };

            return people;
        }

        static XmlSerializer CreateXmlFile(List<MyPerson> people)
        {
            string xmlFilePath = @"C:\temp\mypeople.xml";
            FileStream xmlStream = File.Create(xmlFilePath);
            var xs = new XmlSerializer(typeof(List<MyPerson>));
            xs.Serialize(xmlStream, people);
            xmlStream.Dispose();
            return xs;
        }

        static void Main(string[] args)
        {
            var people = MakePeople();
            var xs= CreateXmlFile(people);
            
        }
    }
}

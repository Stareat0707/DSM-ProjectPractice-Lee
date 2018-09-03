using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialization
{
    class Program
    {
        static List<Employee> CreateEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    ID = 1,
                    Name = "Tom",
                    HireDate = new DateTime(2015, 3, 1)
                },
                new Employee
                {
                    ID = 2,
                    Name = "Sam",
                    HireDate = new DateTime(2016, 3, 1)
                },
                new Employee
                {
                    ID = 3,
                    Name = "Kate",
                    HireDate = new DateTime(2017, 3, 1)
                }
            };

            return employees;
        }

        static List<EmployAttr> CreateEmployees2()
        {
            var employees = new List<EmployAttr>
            {
                new EmployAttr
                {
                    FirstName = "Sam",
                    LastName = "Potter"
                },
                new EmployAttr
                {
                    FirstName = "Jack",
                    LastName = "Potter"
                },
                new EmployAttr
                {
                    FirstName = "Kevin",
                    LastName = "Potter"
                }
            };

            return employees;
        }

        static XmlSerializer CreateXmlFile(List<Employee> employees)
        {
            string xmlFilePath = @"C:\temp\employees.xml";
            FileStream xmlStream = File.Create(xmlFilePath);
            var xs = new XmlSerializer(typeof(List<Employee>));
            xs.Serialize(xmlStream, employees);
            xmlStream.Dispose();
            return xs;
        }

        static XmlSerializer CreateXmlFile2(List<EmployAttr> employees)
        {
            string xmlFilePath = @"C:\temp\employees_Attr.xml";
            FileStream xmlStream = File.Create(xmlFilePath);
            var xs = new XmlSerializer(typeof(List<EmployAttr>));
            xs.Serialize(xmlStream, employees);
            xmlStream.Dispose();
            return xs;
        }

        static void Main(string[] args)
        {
            var people = CreateEmployees();
            var xs = CreateXmlFile(people);
            
            var people2 = CreateEmployees2();
            var xs2 = CreateXmlFile2(people2);
        }
    }
}

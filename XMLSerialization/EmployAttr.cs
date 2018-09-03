using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialization
{
    public class EmployAttr
    {
        [XmlAttribute("fname")]
        public string FirstName { get; set; }

        [XmlAttribute("lname")]
        public string LastName { get; set; }
    }
}

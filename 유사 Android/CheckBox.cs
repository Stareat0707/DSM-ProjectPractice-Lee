using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace a_Android
{
    public class CheckBox
    {
        [XmlAttribute("id")]
        public string ID { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}

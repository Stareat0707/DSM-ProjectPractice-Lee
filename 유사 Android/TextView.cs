using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace a_Android
{
    public class TextView
    {
        [XmlAttribute("layout_height")]
        public string LayoutHeight { get; set; }

        [XmlAttribute("layout_width")]
        public string LayoutWidth { get; set; }

        [XmlAttribute("text")]
        public string Text { get; set; }

        [XmlAttribute("textSize")]
        public string TextSize { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace a_Android
{
    public class LinearLayout
    {
        [XmlAttribute("layout_width")]
        public string LayoutWidth { get; set; }

        [XmlAttribute("layout_height")]
        public string LayoutHeight { get; set; }

        [XmlAttribute("gravity")]
        public string Gravity { get; set; }

        public TextView TextView { get; set; }
        
        public CheckBox CheckBox { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace a_Android
{
    class Program
    {
        static void Main(string[] args)
        {
            var linearLayout = new List<LinearLayout>
            {
                new LinearLayout
                {
                    LayoutWidth = "match_parent",
                    LayoutHeight = "wrap_content",
                    Gravity = "center_vertical",

                    TextView = new TextView
                    {
                        LayoutHeight = "wrap_content",
                        LayoutWidth = "match_parent",
                        Text = "하루종일",
                        TextSize = "24dp"
                    },

                    CheckBox = new CheckBox
                    {
                        ID = "@+id/allDay",
                        Text = "선택"
                    }
                }
            };

            string xmlFilePath = @"C:\temp\linear_layout.xml";
            FileStream xmlStream = File.Create(xmlFilePath);
            var xs = new XmlSerializer(typeof(List<LinearLayout>));
            xs.Serialize(xmlStream, linearLayout);
            xmlStream.Dispose();
        }
    }
}

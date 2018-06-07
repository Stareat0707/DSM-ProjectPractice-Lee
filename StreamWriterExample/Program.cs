using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter streamWriter = new StreamWriter(@"C:\temp\test.txt", true);

            streamWriter.WriteLine("첫번째 시험중입니다.");
            streamWriter.WriteLine("두번째 시험중입니다.");
            streamWriter.WriteLine("세번째 시험중입니다.");

            streamWriter.Close();
        }
    }
}

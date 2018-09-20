using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace _01_08_나성식_ABCMonitor
{
    class TotalScoreSaver
    {
        public static void Save(List<Student> students)
        {
            Console.WriteLine("종합 점수 저장 시작...");

            StreamWriter streamWriter = new StreamWriter("../../JSON/c.json");
            JArray jArray = JArray.FromObject(students);
                streamWriter.WriteLine(jArray.ToString());

            streamWriter.Close();
            Console.WriteLine("종합 점수 저장 종료...");
        }
    }
}

using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Threading.Tasks;

namespace _01_08_나성식_ABC
{
    class ScoreLoader
    {
        // 파일 로딩 메소드
        public static void Load(string subject)
        {
            Console.WriteLine($"{subject} 점수 로딩 시작...");

            StreamReader streamReader = new StreamReader($"../../JSON/{(subject == "korean" ? "a.json" : "b.json")}");

            JArray jArray = JArray.Parse(streamReader.ReadToEnd());
            decimal i = 0;
            foreach (JToken jToken in jArray)
            {
                Console.WriteLine($"{subject} 점수 로딩중: {++i / jArray.Count * 100}%");
                Student student = new Student { Number = jToken["Number"].ToObject<int>(), Name = jToken["Name"].ToString() };
                if (subject == "korean")
                    student.KoreanScore = jToken["KoreanScore"].ToObject<int>();
                else
                    student.MathScore = jToken["MathScore"].ToObject<int>();

                // 파일에서 읽은 정보를 전송
                TotalScoreSaver.AddStudent(student);
            }

            streamReader.Close();
            Console.WriteLine($"{subject} 점수 로딩 종료...");
        }

        // 비동기 Task 시작
        public static Task Run(string subject)
        {
            return Task.Factory.StartNew(() => Load(subject));
        }
    }
}

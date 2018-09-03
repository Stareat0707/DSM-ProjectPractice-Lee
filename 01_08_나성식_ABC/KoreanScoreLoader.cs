using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Threading.Tasks;

namespace _01_08_나성식_ABC
{
    class KoreanScoreLoader
    {
        // 파일이 모두 불러왔는지 확인하는 플래그
        public static bool IsDone { get; private set; }

        // 파일 로딩 메소드
        public static void Load()
        {
            Console.WriteLine("국어 점수 로딩 시작...");

            StreamReader streamReader = new StreamReader("../../JSON/a.json");
            
            JArray jArray = JArray.Parse(streamReader.ReadToEnd());
            foreach (JToken jToken in jArray)
                // 파일에서 읽은 정보를 전송
                TotalScoreSaver.AddStudent(new Student { Number = jToken["Number"].ToObject<int>(), Name = jToken["Name"].ToString(), KoreanScore = jToken["KoreanScore"].ToObject<int>() });

            streamReader.Close();
            Console.WriteLine("국어 점수 로딩 종료...");

            IsDone = true;
        }

        // 비동기 Task 시작
        public static Task Run()
        {
            return Task.Factory.StartNew(Load);
        }
    }
}

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace _01_08_나성식_ABC
{
    class TotalScoreSaver
    {
        private static List<Student> students;

        // 보내지는 정보를 받는 메소드
        public static void AddStudent(Student newStudent)
        {
            if (students == null)
                students = new List<Student>();

            // 겹칠 경우 두 객체 통합
            foreach (Student student in students)
            {
                if (student.Number == newStudent.Number)
                {
                    newStudent.KoreanScore = Math.Max(student.KoreanScore, newStudent.KoreanScore);
                    newStudent.MathScore = Math.Max(student.MathScore, newStudent.MathScore);
                    students.Remove(student);
                    break;
                }
            }
            students.Add(newStudent);
        }

        public static void Save()
        {
            // 등수를 매기기 위해 정렬
            students.Sort(delegate (Student a, Student b)
            {
                return a.TotalScore.CompareTo(b.TotalScore) * -1;
            });

            for (int i = 0; i < students.Count; ++i)
                students[i].Rank = i + 1;

            // 학번 순으로 재정렬
            students.Sort(delegate (Student a, Student b)
            {
                return a.Number.CompareTo(b.Number);
            });
            
            Console.WriteLine("종합 점수 저장 시작...");

            StreamWriter streamWriter = new StreamWriter("../../JSON/c.json");
            JArray jArray = JArray.FromObject(students);
                streamWriter.WriteLine(jArray.ToString());

            streamWriter.Close();
            Console.WriteLine("종합 점수 저장 종료...");
        }
    }
}

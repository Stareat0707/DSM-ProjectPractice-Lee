using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_나성식_ABCMonitor
{
    class Student
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int KoreanScore { get; set; }
        public int MathScore { get; set; }
        public int TotalScore
        {
            get
            {
                return KoreanScore + MathScore;
            }
        }
        public decimal Average
        {
            get
            {
                return (KoreanScore + MathScore) / 2.0M;
            }
        }
    }
}

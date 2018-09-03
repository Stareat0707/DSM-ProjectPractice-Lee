using System.Threading.Tasks;

namespace _01_08_나성식_ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            // a.json, b.json 로드 시작
            Task koreanScoreLoader = ScoreLoader.Run("korean");
            Task mathScoreLoader = ScoreLoader.Run("math");

            // 두 파일을 모두 불러올 때까지 대기
            Task.WaitAll(koreanScoreLoader, mathScoreLoader);

            // c.json에 저장
            TotalScoreSaver.Save();
        }
    }
}

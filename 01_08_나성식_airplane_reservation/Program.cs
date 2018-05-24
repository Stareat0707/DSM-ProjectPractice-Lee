using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_나성식_airplane_reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            JejuAirPlane[] jejuAirPlanes = new JejuAirPlane[3] { new JejuAirPlane(9), new JejuAirPlane(13), new JejuAirPlane(22) };
            NewYorkAirPlane[] newYorkAirPlanes = new NewYorkAirPlane[3] { new NewYorkAirPlane(9), new NewYorkAirPlane(9), new NewYorkAirPlane(13) };
            SydneyAirPlane[] sydneyAirPlanes = new SydneyAirPlane[3] { new SydneyAirPlane(22), new SydneyAirPlane(22), new SydneyAirPlane(22) };
            
            while (true)
            {
                switch (SelectMenu())
                {
                    case 1:
                        Console.WriteLine("예약");
                        ShowDestinations();
                        switch (GetInput())
                        {
                            case 1:
                                Console.WriteLine("제주도행 비행기");
                                ReserveAirPlane(jejuAirPlanes);
                                break;
                            case 2:
                                Console.WriteLine("뉴욕행 비행기");
                                ReserveAirPlane(newYorkAirPlanes);
                                break;
                            case 3:
                                Console.WriteLine("시드니행 비행기");
                                ReserveAirPlane(sydneyAirPlanes);
                                break;
                            default:
                                Console.WriteLine("오류 발생");
                                return;
                        }
                        Console.Write("돌아가려면 아무 키나 누르십시오.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("예약철회");
                        ShowDestinations();
                        switch (GetInput())
                        {
                            case 1:
                                Console.WriteLine("제주도행 비행기");
                                Cancle(jejuAirPlanes);
                                break;
                            case 2:
                                Console.WriteLine("뉴욕행 비행기");
                                Cancle(newYorkAirPlanes);
                                break;
                            case 3:
                                Console.WriteLine("시드니행 비행기");
                                Cancle(sydneyAirPlanes);
                                break;
                            default:
                                Console.WriteLine("오류 발생");
                                return;
                        }
                        Console.Write("돌아가려면 아무 키나 누르십시오.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("조회");
                        ShowDestinations();
                        switch (GetInput())
                        {
                            case 1:
                                Console.WriteLine("제주도행 비행기");
                                ShowAirPlanes(jejuAirPlanes);
                                break;
                            case 2:
                                Console.WriteLine("뉴욕행 비행기");
                                ShowAirPlanes(newYorkAirPlanes);
                                break;
                            case 3:
                                Console.WriteLine("시드니행 비행기");
                                ShowAirPlanes(sydneyAirPlanes);
                                break;
                            default:
                                Console.WriteLine("오류 발생");
                                return;
                        }
                        Console.Write("돌아가려면 아무 키나 누르십시오.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("오류 발생");
                        return;
                }
            }
        }

        static int SelectMenu()
        {
            Console.WriteLine("1. 예약");
            Console.WriteLine("2. 예약철회");
            Console.WriteLine("3. 조회");
            Console.WriteLine("4. 종료");
            Console.WriteLine();
            Console.Write("입력: ");
            int input = Console.Read() - 48;
            Console.ReadLine();
            Console.Clear();
            return input;
        }

        static void ShowDestinations()
        {
            Console.WriteLine();
            Console.WriteLine("목적지 선택");
            Console.WriteLine();
            Console.WriteLine("1. 제주도");
            Console.WriteLine("2. 뉴욕");
            Console.WriteLine("3. 시드니");
            Console.WriteLine();
        }

        static void ShowAirPlanes(AirPlane[] airPlanes)
        {
            Console.WriteLine();
            int i = 0;
            foreach (var airPlane in airPlanes)
                Console.WriteLine(++i + ". " + airPlane.GetDescription());
            Console.WriteLine();
        }

        static void ReserveAirPlane(AirPlane[] airPlanes)
        {
            ShowAirPlanes(airPlanes);
            int input = GetInput() - 1;
            airPlanes[input].Reserve();
            Console.WriteLine();
        }

        static void Cancle(AirPlane[] airPlanes)
        {
            ShowAirPlanes(airPlanes);
            int input = GetInput() - 1;
            airPlanes[input].Cancle();
            Console.WriteLine();
        }

        static int GetInput()
        {
            Console.Write("선택: ");
            int input = Console.Read() - 48;
            Console.ReadLine();
            Console.Clear();
            return input;
        }
    }
}

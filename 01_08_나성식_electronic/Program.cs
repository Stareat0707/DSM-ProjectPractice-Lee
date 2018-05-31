using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_나성식_electronic
{
    class Program
    {
        static void GetChar()
        {
            Console.WriteLine();
            Console.Write("계속하려면 아무 키나 누르세요...");
            Console.ReadKey();
            Console.Clear();
        }

        static int StringToInt(string str)
        {
            int returnValue = 0;

            foreach (var c in str)
            {
                returnValue *= 10;
                returnValue += c - 48;
            }

            return returnValue;
        }

        static void Main(string[] args)
        {
            List<HomeAppliance> homeAppliances = new List<HomeAppliance>();

            while (true)
            {
                Console.WriteLine("1. 물품 조회");
                Console.WriteLine("2. 검색");
                Console.WriteLine("3. 입고");
                Console.WriteLine("4. 판매");
                Console.WriteLine("다른 키: 종료");
                Console.Write("선택: ");
                int input = StringToInt(Console.ReadLine());
                Console.Clear();

                bool flag;
                switch (input)
                {
                    case 1:
                        Console.WriteLine("물품 조회");
                        Console.WriteLine();

                        if (homeAppliances.Count != 0)
                        {
                            foreach (var homeAppliance in homeAppliances)
                                Console.WriteLine(homeAppliance.GetDescription());
                        }
                        else
                            Console.WriteLine("물품이 없습니다.");

                        GetChar();
                        break;

                    case 2:
                        Console.WriteLine("검색");
                        Console.WriteLine();
                        Console.Write("찾으시는 물품의 이름을 작성해주세요: ");
                        string homeApplianceToSearch = Console.ReadLine();
                        Console.WriteLine();

                        flag = false;
                        foreach (var homeAppliance in homeAppliances)
                        {
                            if (homeAppliance.Name == homeApplianceToSearch)
                            {
                                Console.WriteLine(homeAppliance.GetDescription());
                                flag = true;
                            }
                        }

                        if (!flag)
                            Console.WriteLine("물품이 없습니다.");

                        GetChar();
                        break;

                    case 3:
                        Console.WriteLine("입고");
                        Console.WriteLine();
                        Console.WriteLine("입고하시는 물품의 정보를 작성합니다.");
                        Console.WriteLine();
                        Console.Write("물품 이름: ");
                        string name = Console.ReadLine();

                        string quality = null;
                        if (name == "노트북")
                        {
                            Console.Write("노트북 사양: ");
                            quality = Console.ReadLine();
                        }

                        Console.Write("물품 정가: ");
                        int price = StringToInt(Console.ReadLine());
                        Console.Write("물품 재고: ");
                        int num = StringToInt(Console.ReadLine());

                        for (int i = 0; i < num; ++i)
                        {
                            switch (name)
                            {
                                case "텔레비전":
                                    homeAppliances.Add(new TV(name, price));
                                    break;

                                case "냉장고":
                                    homeAppliances.Add(new Refrigerator(name, price));
                                    break;

                                case "노트북":
                                    homeAppliances.Add(new Raptop(name, price, quality));
                                    break;

                                default:
                                    homeAppliances.Add(new HomeAppliance(name, price));
                                    break;
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("입고가 완료되었습니다.");
                        GetChar();

                        break;

                    case 4:
                        Console.WriteLine("판매");
                        Console.WriteLine();
                        Console.Write("판매하시는 물품의 이름을 작성해주세요: ");
                        string homeApplianceToSale = Console.ReadLine();
                        Console.WriteLine();

                        flag = false;
                        foreach (var homeAppliance in homeAppliances)
                        {
                            if (homeAppliance.Name == homeApplianceToSale)
                            {
                                Console.WriteLine(homeAppliance.GetDescription());
                                Console.WriteLine("이 물품을 판매하시겠습니까? (Y/N)");
                                if(Console.ReadLine()=="Y")
                                {
                                    homeAppliances.Remove(homeAppliance);
                                    Console.WriteLine("판매하였습니다.");
                                    flag = true;
                                    break;
                                }
                            }
                        }

                        if (!flag)
                            Console.WriteLine("물품이 없습니다.");

                        GetChar();
                        break;

                    default:
                        return;
                }
            }
        }
    }
}

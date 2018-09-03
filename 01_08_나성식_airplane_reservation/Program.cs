using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Linq;
using ReserveStatus;

namespace _01_08_나성식_airplane_reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = null;
            using (var db = new Database())
            {
                Console.Write("이름: ");
                string name = Console.ReadLine();
                bool flag = false;
                using (IDbContextTransaction t = db.Database.BeginTransaction())
                {
                    IQueryable<User> users = db.Users;
                    foreach (var u in users)
                    {
                        if (u.UserName == name)
                        {
                            user = u;
                            flag = true;
                            break;
                        }
                    }
                }

                if (!flag)
                {
                    user = new User { UserName = name, Password = "Yeah" };
                    db.Users.Add(user);

                    Console.WriteLine("회원가입 완료.");
                }

                db.SaveChanges();
            }

            Console.WriteLine();

            int input = 0;
            while (input != 4)
            {
                Console.WriteLine("1. 예약");
                Console.WriteLine("2. 예약철회");
                Console.WriteLine("3. 조회");
                Console.WriteLine("4. 종료");
                Console.WriteLine();
                Console.Write("입력: ");
                input = Int32.Parse(Console.ReadLine());
                Console.Clear();
                IQueryable<Airplane> airplanes;
                switch (input)
                {
                    case 1:
                        Console.WriteLine("예약");

                        using (var db = new Database())
                        {
                            using (IDbContextTransaction t = db.Database.BeginTransaction())
                            {
                                airplanes = db.Airplanes;
                                foreach (var airplane in airplanes)
                                    Console.WriteLine($"{airplane.AirplaneID}. {airplane.Destination}행 {airplane.DepartureTime}시 비행기. 좌석: ({airplane.ReservationNum}/{airplane.Capacity})");
                                input = GetInput();
                                foreach (var airplane in airplanes)
                                {
                                    if (--input == 0)
                                    {
                                        bool result = airplane.Reserve(user);
                                        db.Reserves.Add(new Reserve { UserID = user.UserID, AirplaneID = airplane.AirplaneID, Status = (result ? Status.Reserved : Status.Waiting) });
                                        db.Airplanes.Update(airplane);
                                        break;
                                    }
                                }
                                Console.WriteLine();
                            }

                            db.SaveChanges();
                        }
                        break;

                    case 2:
                        Console.WriteLine("예약철회");
                        using (var db = new Database())
                        {
                            using (IDbContextTransaction t = db.Database.BeginTransaction())
                            {
                                IQueryable<Reserve> reserves = db.Reserves;
                                int i = 0;
                                foreach (var reserve in reserves)
                                {
                                    if (reserve.UserID == user.UserID)
                                        Console.WriteLine($"{++i}. {db.Airplanes.Find(reserve.AirplaneID).Destination}행 {db.Airplanes.Find(reserve.AirplaneID).DepartureTime}시 비행기. 상태: " + (reserve.Status == Status.Reserved ? "예약됨" : "대기중"));
                                }
                                input = GetInput();
                                Reserve targetReserve = null;
                                foreach (var reserve in reserves)
                                {
                                    if (reserve.UserID == user.UserID)
                                    {
                                        if (--i == 0)
                                        {
                                            targetReserve = reserve;
                                            break;
                                        }
                                    }
                                }

                                db.Airplanes.Find(targetReserve.AirplaneID).Cancle();
                                db.Reserves.Remove(targetReserve);
                            }

                            db.SaveChanges();
                        }

                        Console.WriteLine();
                        Console.Write("계속하려면 아무 키나 누르십시오 . . .");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("조회");
                        using (var db = new Database())
                        {
                            using (IDbContextTransaction t = db.Database.BeginTransaction())
                            {
                                IQueryable<Reserve> reserves = db.Reserves;
                                foreach (var reserve in reserves)
                                {
                                    if (reserve.UserID == user.UserID)
                                        Console.WriteLine($"{db.Airplanes.Find(reserve.AirplaneID).Destination}행 {db.Airplanes.Find(reserve.AirplaneID).DepartureTime}시 비행기. 상태: " + (reserve.Status == Status.Reserved ? "예약됨" : "대기중"));
                                }
                                Console.Write("계속하려면 아무 키나 누르십시오 . . .");
                                Console.ReadKey();
                                Console.Clear();
                            }

                            db.SaveChanges();
                        }
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("오류 발생");
                        break;
                }
            }
        }

        static int GetInput()
        {
            Console.Write("선택: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.Clear();
            return input;
        }
    }
}

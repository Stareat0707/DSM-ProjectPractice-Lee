using System;
using System.Collections.Generic;

namespace _01_08_나성식_airplane_reservation
{
    public class Airplane
    {
        public int AirplaneID { get; set; }
        public string Destination { get; set; }
        public int DepartureTime { get; set; }
        public int Capacity { get; set; }
        public int ReservationNum { get; set; }

        public bool Reserve(User user)
        {
            if (++ReservationNum > Capacity)
            {
                Console.WriteLine("좌석이 가득 차 대기열에 등록됐습니다.");
                return false;
            }
            else
            {
                Console.WriteLine("좌석 예매에 성공했습니다.");
                return true;
            }
        }

        public void Cancle()
        {
            if (ReservationNum <= 0)
                Console.WriteLine("예약 내역이 없습니다.");
            else
            {
                --ReservationNum;
                Console.WriteLine("예약을 취소했습니다.");
            }
        }
    }
}

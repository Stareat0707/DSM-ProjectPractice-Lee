using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_나성식_airplane_reservation
{
    class AirPlane
    {
        protected enum Destination
        {
            Jeju,
            NewYork,
            Sydney
        }

        protected int Capacity { get; set; }
        protected int ReservationNum { get; set; }
        protected int DepartureTime { get; set; }
        protected Destination Dest { get; set; }

        public void Reserve()
        {
            if (++ReservationNum > Capacity)
                Console.WriteLine("좌석이 가득 차 대기열에 등록됐습니다.");
            else
                Console.WriteLine("좌석 예매에 성공했습니다.");
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

        public string GetDescription()
        {
            return $"출발 시간: {DepartureTime}시, " +
                      $"좌석: {(ReservationNum > Capacity ? 50 : ReservationNum)}/{Capacity}, " +
                      $"대기열: {(ReservationNum > Capacity ? ReservationNum - Capacity : 0)}명";
        }
    }
}

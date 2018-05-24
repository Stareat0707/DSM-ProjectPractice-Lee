using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_나성식_airplane_reservation
{
    class JejuAirPlane : AirPlane
    {
        public JejuAirPlane(int departureTime)
        {
            Capacity = 50;
            ReservationNum = 0;
            DepartureTime = departureTime;
            Dest = Destination.Jeju;
        }
    }
}

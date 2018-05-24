using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_나성식_airplane_reservation
{
    class SydneyAirPlane : AirPlane
    {
        public SydneyAirPlane(int departureTime)
        {
            Capacity = 200;
            ReservationNum = 0;
            DepartureTime = departureTime;
            Dest = Destination.Sydney;
        }
    }
}

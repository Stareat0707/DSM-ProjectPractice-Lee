using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {
            Room LivingRoom = new Room
            {
                Name = "거실"
            };

            Room DiningRoom = new Room
            {
                Name = "식당"
            };

            Room Kitchen = new Room
            {
                Name = "부엌"
            };

            Outside Frontyard = new Outside
            {
                Name = "앞마당"
            };
            Outside Backyard = new Outside
            {
                Name = "뒷마당"
            };

            LivingRoom.Exits = new Location[] { Frontyard, DiningRoom };
            DiningRoom.Exits = new Location[] { LivingRoom, Kitchen };
            Kitchen.Exits = new Location[] { DiningRoom, Backyard };
            Frontyard.Exits = new Location[] { LivingRoom, Backyard };
            Backyard.Exits = new Location[] { Kitchen, Frontyard };

            LivingRoom.Description();
            DiningRoom.Description();
            Kitchen.Description();
            Frontyard.Description();
            Backyard.Description();
        }
    }
}

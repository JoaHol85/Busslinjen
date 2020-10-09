using System;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        public static List<Station> stationList = new List<Station>();
        public static List<Passenger> passengerList = new List<Passenger>();
        public static Bus bus = new Bus();


        static void Main(string[] args)
        {
            CreateStations();

        }

        static void CreateStations()
        {
            for (int i = 1; i <= 10; i++)
            {
                new Station($"Station {i}");
            }
        }

 





    }
}

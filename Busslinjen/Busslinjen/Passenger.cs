using System;
using System.Collections.Generic;
using System.Text;

namespace Busslinjen
{
    class Passenger
    {
        public Station StationToSpawnAt { get; set; }
        public Station StationToGetOffAt { get; set; }
        public bool CurrentOnBus { get; set; } = false;
        public bool ArrivedAtDestination { get; set; } = false;

        public Passenger()
        {
            (StationToSpawnAt, StationToGetOffAt) = RandomizeStation();
        }

        static (Station, Station) RandomizeStation()
        {
            int stationNumberSpawn = 0;
            int stationNumberOff = 0;
            Random random = new Random();
            bool same = true;
            while (same)
            {
                stationNumberSpawn = random.Next(1, 10 + 1);
                stationNumberOff = random.Next(1, 10 + 1);
                if (stationNumberSpawn != stationNumberOff)
                    same = false;
            }
            return (Program.stationList[stationNumberSpawn -1], Program.stationList[stationNumberOff -1]);
        }

        public static void AddPassenger(int numberOfPassangers)
        {
            for (int i = 1; i <= numberOfPassangers; i++)
            {
                Program.passengerList.Add(new Passenger());
            }
        }


    }
}

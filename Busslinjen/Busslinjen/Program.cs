using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Busslinjen
{
    class Program
    {
        public static List<Passenger> passengerList = new List<Passenger>();
        public static List<Station> stationList = new List<Station>();
        public static Bus bus = new Bus();


        static void Main(string[] args)
        {
            CreateStations();
            while (true)
            {

                PrintStationList(bus);
                Passenger.AddPassenger(20);
                bus.MoveBusOneStation();
                bus.PassengersLeaveBus();
                bus.PassengersEnterBus();
                Console.ReadKey(true);
                Console.Clear();
            }

        }

        static void CreateStations()
        {
            for (int i = 1; i <= 10; i++)
            {
                stationList.Add(new Station($"Station {i}"));
            }
        }

        public static void PrintStationList(Bus bus)
        {
            int poepleAtStation;
            foreach (Station station in stationList)
            {
                poepleAtStation = 0;
                if(bus.CurrentStation == station)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{station.Name}: Här är bussen och hämtar {bus.NumbersOfPassangersEnteringBus} och lämnar av {bus.NumbersOfPassengersLeavingBus} passagerare. Antal passagerare just nu {bus.NumberOfPassengers}.");
                    if(bus.NumberOfPassengers >= bus.MaxNumberOfPassengers)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Bussen är tyvärr full, {bus.NumberOfPassengersLeftOnStation} passagerare får vänta kvar vid hållplatsen på nästa buss.");
                    }
                    Console.ResetColor();
                    continue;
                }

                foreach (Passenger passenger in passengerList)
                {
                    if(passenger.StationToSpawnAt == station && passenger.CurrentOnBus == false)
                    {
                        poepleAtStation++;
                    }
                }
                Console.WriteLine($"{station.Name}: {poepleAtStation} passagerare väntar på bussen.");
            }
        }

        




    }
}

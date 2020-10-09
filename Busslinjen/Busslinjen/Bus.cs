using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Busslinjen
{
    class Bus
    {
        public int NumberOfPassengersLeftOnStation { get; set; }
        public int NumbersOfPassangersEnteringBus { get; set; }
        public int NumbersOfPassengersLeavingBus { get; set; }
        public int NumberOfPassengers { get; set; } = 0;
        public int MaxNumberOfPassengers { get; set; } = 30;
        static int CurrentStationNumber { get; set; } = -1;
        public Station CurrentStation { get; set; }

        public void MoveBusOneStation()
        {
            CurrentStationNumber += 1;
            if (CurrentStationNumber == 10)
                CurrentStationNumber = 0;
            CurrentStation = Program.stationList[CurrentStationNumber];
        }
        public void PassengersEnterBus()
        {
            NumberOfPassengersLeftOnStation = 0;
            NumbersOfPassangersEnteringBus = 0;
            foreach (Passenger passenger in Program.passengerList)
            {
                if (passenger.StationToSpawnAt == CurrentStation && passenger.CurrentOnBus == false)
                {
                    if (NumberOfPassengers >= MaxNumberOfPassengers)
                        NumberOfPassengersLeftOnStation++;
                    else
                    {
                        passenger.CurrentOnBus = true;
                        NumberOfPassengers++;
                        NumbersOfPassangersEnteringBus++;
                    }
                }
            }
        }
        public void PassengersLeaveBus()
        {
            NumbersOfPassengersLeavingBus = 0;
            foreach (Passenger passenger in Program.passengerList)
            {
                if (CurrentStation == passenger.StationToGetOffAt && passenger.ArrivedAtDestination == false && passenger.CurrentOnBus == true)
                {
                    NumberOfPassengers--;
                    NumbersOfPassengersLeavingBus++;
                    passenger.ArrivedAtDestination = true;
                }
            }
        }
    }


}

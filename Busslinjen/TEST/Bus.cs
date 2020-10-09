using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
    class Bus
    {
        public int MaxNumberOfPassengers { get; set; } = 30;
        static int CurrentStationNumber { get; set; } = 0;
        public Station CurrentStation { get; set; } = Program.stationList[CurrentStationNumber];

    }


}

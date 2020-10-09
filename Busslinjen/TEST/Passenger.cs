using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
    class Passenger
    {
        public Station StationToSpawnAt { get; set; }
        public Station StationToGetOffAt { get; set; }
        public bool CurrentOnBus { get; set; } = false;
        public bool ArrivedAtDestination { get; set; } = false;




    }
}

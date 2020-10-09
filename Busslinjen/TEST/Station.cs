using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
    class Station
    {
        public string Name { get; set; }

        public Station(string name)
        {
            Name = name;
            Program.stationList.Add(this);
        }



    }
}

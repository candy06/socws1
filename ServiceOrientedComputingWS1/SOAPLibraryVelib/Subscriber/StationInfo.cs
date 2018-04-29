using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLibraryVelib.Subscriber
{
    class StationInfo
    {
        public string StationName { get; set; }
        public string CityName { get; set; }

        public StationInfo (string stationName, string cityName)
        {
            StationName = stationName;
            CityName = cityName;
        }
    }
}

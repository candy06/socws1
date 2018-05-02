using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLibraryVelib.Subscriber
{
    /// <summary>
    /// Class that gather all the useful information to identify a station
    /// </summary>
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

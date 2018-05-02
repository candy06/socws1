using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientIWS
{
    class SubscribedStation
    {

        private StringManager sm = new StringManager();
        public string OriginalStationName { get; private set; }
        public string TruncatenateStationName { get; private set; }
        public string CityName { get; private set; }

        public SubscribedStation(string stationName, string cityName)
        {
            OriginalStationName = stationName;
            TruncatenateStationName = sm.Trunc(stationName, 15);
            CityName = cityName;
        }

        public override string ToString()
        {
            return TruncatenateStationName;
        }

    }
}

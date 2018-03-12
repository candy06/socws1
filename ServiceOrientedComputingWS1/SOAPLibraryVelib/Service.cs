using System;
using System.Collections.Generic;

namespace SOAPLibraryVelib
{
    class Service : IService
    {

        private RequestManager rm = new RequestManager();

        public int GetAvailableBikesForStation(string stationName, string cityName)
        {
            List<Station> stationsOfCity = rm.GetStationsForCity(cityName);
            foreach (Station s in stationsOfCity)
            {
                if (s.name.Equals(stationName)) return s.available_bikes;
            }
            return -1;
        }

        public List<string> GetCities()
        {
            List<City> cities = rm.GetCitiesRequest();
            List<string> result = new List<string>();
            foreach (City c in cities)
            {
                result.Add(c.name);
            }
            return result;
        }
       
        public List<string> GetStationsNameForCity(string name)
        {
            List<Station> stations = rm.GetStationsForCity(name);
            List<string> result = new List<string>();
            foreach (Station s in stations)
            {
                result.Add(s.name);
            }
            return result;
        }
    }
}

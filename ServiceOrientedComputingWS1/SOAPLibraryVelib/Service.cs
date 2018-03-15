using System.Collections.Generic;
using System.Threading.Tasks;

namespace SOAPLibraryVelib
{
    class Service : IService
    {

        private RequestManager rm = new RequestManager();

        public int GetAvailableBikesForStation(string stationName, string cityName)
        {
            List<Station> stationsOfCity = rm.GetStationsObjForCity(cityName);
            foreach (Station s in stationsOfCity)
            {
                if (s.Name.Equals(stationName)) return s.Available_bikes;
            }
            return -1;
        }

        public List<City> GetCities()
        {
            return rm.GetCitiesRequest();
        }

        public List<Station> GetStationsOf(string cityName)
        {
            return rm.GetStationsObjForCity(cityName);
        }
    }
}

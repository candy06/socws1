using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLibraryVelib
{
    class Service : IService
    {

        private RequestManager rm = new RequestManager();

        public List<City> GetCities()
        {
            return rm.GetCitiesRequest();
        }

        public Station GetStation(int station_number, string city_name)
        {
            throw new NotImplementedException();
        }

        public List<Station> GetStations()
        {
            throw new NotImplementedException();
        }

        public List<Station> GetStationsForCity(string city_name)
        {
            throw new NotImplementedException();
        }
    }
}

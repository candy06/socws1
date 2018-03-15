using System;
using System.Collections.Generic;
using System.Runtime.Caching;

namespace SOAPLibraryVelib
{
    class Service : IService
    {
        private const string citiesKey = "citiesKey";
        private const string stationsKey = "stationsKey";
        private const string availableBikesKey = "availableBikesKey";

        // By default, we don't use cache between IWS and Velib WS
        private bool useCache = true;
        private ObjectCache cache = MemoryCache.Default;

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
            if (useCache)
            {
                if (cache.Contains(citiesKey))
                    return (List<City>)cache.Get(citiesKey);
                else
                {
                    List<City> cities = rm.GetCitiesRequest();

                    // Store data in the cache
                    CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                    cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(5);
                    cache.Add(citiesKey, cities, cacheItemPolicy);

                    return cities;
                }
            }
            
            return rm.GetCitiesRequest();
        }

        public List<Station> GetStationsOf(string cityName)
        {
            return rm.GetStationsObjForCity(cityName);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.Caching;

namespace SOAPLibraryVelib
{
    class Service : IService
    {
        private const string citiesKey = "citiesKey";
        private const string stationsKey = "stationsKey";
        private const string availableBikeKey = "availableBikesKey";

        private ObjectCache cache = MemoryCache.Default;

        private RequestManager rm = new RequestManager();

        public int GetAvailableBikesForStation(string stationName, string cityName)
        {
            string keyForSpecifiedStation = availableBikeKey + "For" + stationName;
            if (cache.Contains(keyForSpecifiedStation))
                return (int)cache.Get(keyForSpecifiedStation);
            else
            {
                int availableBikes = rm.GetAvailableBikes(stationName, cityName);
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(5);
                cache.Add(keyForSpecifiedStation, availableBikes, cacheItemPolicy);
                return availableBikes;
            }
        }

        public List<City> GetCities()
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

        public List<Station> GetStationsOf(string cityName)
        {
            if (cache.Contains(stationsKey))
                return (List<Station>)cache.Get(stationsKey);
            else
            {
                List<Station> stations = rm.GetStationsObjForCity(cityName);
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(5);
                cache.Add(stationsKey, stations, cacheItemPolicy);
                return stations;
            }
        }

    }

}
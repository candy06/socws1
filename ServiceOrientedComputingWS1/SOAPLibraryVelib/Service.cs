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
        private const int accessCodeForMonitoring = 1234;

        private ObjectCache cache = MemoryCache.Default;

        private RequestManager rm = new RequestManager();

        // About velib services

        public int GetAvailableBikesForStation(string stationName, string cityName)
        {
            Monitor.AddClient();
            Monitor.AddClientRequest(ClientRequest.GetAvailableBikes);

            string keyForSpecifiedStation = availableBikeKey + "For" + stationName;

            int availableBikes;

            if (cache.Contains(keyForSpecifiedStation))
                availableBikes = (int) cache.Get(keyForSpecifiedStation);
            else
            {
                availableBikes = rm.GetAvailableBikes(stationName, cityName);
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(5);
                cache.Add(keyForSpecifiedStation, availableBikes, cacheItemPolicy);
            }

            Monitor.RemoveClient();
            return availableBikes;
        }

        public List<City> GetCities()
        {

            Monitor.AddClient();
            Monitor.AddClientRequest(ClientRequest.GetCities);

            List<City> cities;

            if (cache.Contains(citiesKey))
                cities = (List<City>) cache.Get(citiesKey);
            else
            {
                cities = rm.GetCitiesRequest();
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(5);
                cache.Add(citiesKey, cities, cacheItemPolicy);
            }

            Monitor.RemoveClient();
            return cities;
        }

        public List<Station> GetStationsOf(string cityName)
        {

            Monitor.AddClient();
            Monitor.AddClientRequest(ClientRequest.GetStationsForCity);

            List<Station> stations;

            string keyForSpecifiedCity = $"{stationsKey} For {cityName}";

            if (cache.Contains(keyForSpecifiedCity))
                stations = (List<Station>) cache.Get(keyForSpecifiedCity);
            else
            {
                stations = rm.GetStationsObjForCity(cityName);
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(5);
                cache.Add(keyForSpecifiedCity, stations, cacheItemPolicy);
            }

            Monitor.RemoveClient();
            return stations;
        }

    }

}
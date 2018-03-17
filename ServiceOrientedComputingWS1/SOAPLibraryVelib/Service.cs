using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        // About monitoring

        public int GetConnectedClients(int _accessCode)
        {
            if (_accessCode == accessCodeForMonitoring)
                return rm.GetConnectedClient();
            else return -1;
        }

        // About velib services

        public int GetAvailableBikesForStation(string stationName, string cityName)
        {
            Trace.WriteLine($"{System.Threading.Thread.CurrentThread.ManagedThreadId}->GetAvailableBikesForStation");
            Monitor.AddClient();

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

            return availableBikes;
        }

        public List<City> GetCities()
        {
            Trace.WriteLine($"{System.Threading.Thread.CurrentThread.ManagedThreadId}->GetCities");
            Monitor.AddClient();

            if (cache.Contains(citiesKey))
                return (List<City>)cache.Get(citiesKey);
            else
            {
                List<City> cities = rm.GetCitiesRequest();
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(5);
                cache.Add(citiesKey, cities, cacheItemPolicy);

                return cities;
            }
        }

        public List<Station> GetStationsOf(string cityName)
        {
            Monitor.AddClient();
            string keyForSpecifiedCity = $"{stationsKey} For {cityName}";
            if (cache.Contains(keyForSpecifiedCity))
                return (List<Station>)cache.Get(keyForSpecifiedCity);
            else
            {
                List<Station> stations = rm.GetStationsObjForCity(cityName);
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(5);
                cache.Add(keyForSpecifiedCity, stations, cacheItemPolicy);
                return stations;
            }
        }

    }

}
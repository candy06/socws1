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

        private ObjectCache cache = MemoryCache.Default;

        private RequestManager rm = new RequestManager();

        public List<Station> GetAllStations()
        {
            return rm.GetAllStations();
        }

        public int GetAvailableBikesForStation(string stationName, string cityName)
        {
            // Start counting the execution time of the function
            Stopwatch stopwatch = Stopwatch.StartNew();
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

            stopwatch.Stop();
            Monitor.AddExecutionTime(ClientRequest.GetAvailableBikes, stopwatch.ElapsedMilliseconds);
            return availableBikes;
        }

        public List<City> GetCities()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
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

            stopwatch.Stop();
            Monitor.AddExecutionTime(ClientRequest.GetCities, stopwatch.ElapsedMilliseconds);
            return cities;
        }

        public Station GetInformations(int stationNumber, string city)
        {
            return rm.GetInformations(stationNumber, city);
        }

        public List<Station> GetStationsOf(string cityName)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
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

            stopwatch.Stop();
            Monitor.AddExecutionTime(ClientRequest.GetStationsForCity, stopwatch.ElapsedMilliseconds);
            return stations;
        }

    }

}
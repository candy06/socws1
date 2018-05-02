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
        private const string informationKey = "informationKey";

        private ObjectCache _cache = MemoryCache.Default;

        private RequestManager _requestManager = new RequestManager();

        public List<Station> GetAllStations()
        {
            return _requestManager.GetAllStations();
        }

        public int GetAvailableBikesForStation(string stationName, string cityName)
        {
            // Start counting the execution time of the function
            Stopwatch stopwatch = Stopwatch.StartNew();
            Monitor.AddClient();
            Monitor.AddClientRequest(ClientRequest.GetAvailableBikes);
            
            

            string keyForSpecifiedStation = availableBikeKey + "For" + stationName;

            int availableBikes;

            if (_cache.Contains(keyForSpecifiedStation))
                availableBikes = (int) _cache.Get(keyForSpecifiedStation);
            else
            {
                availableBikes = _requestManager.GetAvailableBikes(stationName, cityName);
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(5);
                _cache.Add(keyForSpecifiedStation, availableBikes, cacheItemPolicy);
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

            if (_cache.Contains(citiesKey))
                cities = (List<City>) _cache.Get(citiesKey);
            else
            {
                cities = _requestManager.GetCitiesRequest();
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(5);
                _cache.Add(citiesKey, cities, cacheItemPolicy);
            }

            Monitor.RemoveClient();

            stopwatch.Stop();
            Monitor.AddExecutionTime(ClientRequest.GetCities, stopwatch.ElapsedMilliseconds);
            return cities;
        }

        public string GetInformations(int stationNumber, string city)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Monitor.AddClient();
            Monitor.AddClientRequest(ClientRequest.GetInformations);

            string information;
            string key = informationKey + city + "no" + stationNumber;

            if (_cache.Contains(key))
                information = (string)_cache.Get(key);
            else
            {
                Station s = _requestManager.GetInformations(stationNumber, city);
                information = $"Name: {s.Name}\n" +
                    $"City:{s.Contract_name}\n" +
                    $"Number: {s.Number}\n" +
                    $"Address: {s.Address}\n" +
                    $"Position: ({s.Position.Lat}, {s.Position.Lng})\n" +
                    $"Banking: {s.Banking}\n" +
                    $"Status: {s.Status}\n" +
                    $"Bike stands: {s.Bike_stands}\n" +
                    $"Available bike stands: {s.Available_bike_stands}\n" +
                    $"Available bikes: {s.Available_bikes}\n";
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(5);
                _cache.Add(key, information, cacheItemPolicy);
            }

            Monitor.RemoveClient();
            stopwatch.Stop();
            Monitor.AddExecutionTime(ClientRequest.GetInformations, stopwatch.ElapsedMilliseconds);
            return information;
            
        }

        public List<Station> GetStationsOf(string cityName)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Monitor.AddClient();
            Monitor.AddClientRequest(ClientRequest.GetStationsForCity);

            List<Station> stations;

            string keyForSpecifiedCity = $"{stationsKey} For {cityName}";

            if (_cache.Contains(keyForSpecifiedCity))
                stations = (List<Station>) _cache.Get(keyForSpecifiedCity);
            else
            {
                stations = _requestManager.GetStationsForCity(cityName);
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(5);
                _cache.Add(keyForSpecifiedCity, stations, cacheItemPolicy);
            }

            Monitor.RemoveClient();

            stopwatch.Stop();
            Monitor.AddExecutionTime(ClientRequest.GetStationsForCity, stopwatch.ElapsedMilliseconds);
            return stations;
        }

    }

}
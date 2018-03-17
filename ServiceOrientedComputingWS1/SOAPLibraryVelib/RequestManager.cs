﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace SOAPLibraryVelib
{
    class RequestManager
    {

        private const string apiKey = "673d9eadb6a73d453e63b3908acb43dd4f05775b";
        private URIBuilder uriBuilder = new URIBuilder();

        public Station GetInformations(int stationNumber, string cityName)
        {
            Monitor.AddServerRequest(ServerRequest.GetStationInformationRequest);
            string responseFromServer = GetResponseFromServer(ServerRequest.GetStationInformationRequest, cityName, stationNumber);
            Station station = JsonConvert.DeserializeObject<Station>(responseFromServer);
            return station;
        }

        public List<Station> GetAllStations()
        {
            Monitor.AddServerRequest(ServerRequest.GetStationsRequest);
            string responseFromServer = GetResponseFromServer(ServerRequest.GetStationsRequest);
            List<Station> stations = JsonConvert.DeserializeObject<List<Station>>(responseFromServer);
            return stations;
        }
 
        public List<City> GetCitiesRequest()
        {
            Monitor.AddServerRequest(ServerRequest.GetCitiesRequest);
            string responseFromServer = GetResponseFromServer(ServerRequest.GetCitiesRequest);
            List<City> cities = JsonConvert.DeserializeObject<List<City>>(responseFromServer);
            return cities;
        }

        public int GetAvailableBikes(string stationName, string cityName)
        {
            Monitor.AddServerRequest(ServerRequest.GetStationsOfCityRequest);
            string responseFromServer = GetResponseFromServer(ServerRequest.GetStationsOfCityRequest, cityName);
            List<Station> stationsOfCity = JsonConvert.DeserializeObject<List<Station>>(responseFromServer);
            foreach (Station s in stationsOfCity)
            {
                if (s.Name.Equals(stationName)) return s.Available_bikes;
            }
            return -1;
        }

        public List<Station> GetStationsObjForCity(string cityName)
        {
            Monitor.AddServerRequest(ServerRequest.GetStationsOfCityRequest);
            string responseFromServer = GetResponseFromServer(ServerRequest.GetStationsOfCityRequest, cityName);
            List<Station> stations = JsonConvert.DeserializeObject<List<Station>>(responseFromServer);
            return stations;
        }

        private string GetResponseFromServer(ServerRequest requestType, string cityName = "", int stationNumber = 0)
        {
            WebRequest request = null;
            switch (requestType)
            {
                case ServerRequest.GetCitiesRequest:
                    request = WebRequest.Create(uriBuilder.GenerateURI(URIType.GetCitiesURI, apiKey));
                    break;
                case ServerRequest.GetStationsOfCityRequest:
                    request = WebRequest.Create(uriBuilder.GenerateURI(URIType.GetStationsOfCityURI, apiKey, cityName));
                    break;
                case ServerRequest.GetStationsRequest:
                    request = WebRequest.Create(uriBuilder.GenerateURI(URIType.GetStationsURI, apiKey));
                    break;
                case ServerRequest.GetStationInformationRequest:
                    request = WebRequest.Create(uriBuilder.GenerateURI(URIType.GetStationInformationURI, apiKey, cityName, stationNumber));
                    break;
                default:
                    break;
            }
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            return reader.ReadToEnd();
        }

        public int GetConnectedClient()
        {
            return Monitor.ConnectedClients;
        }

        public int GetNumberOfClientRequest(ClientRequest clientRequest)
        {
            return Monitor.HowMany(clientRequest);
        }

        public int GetNumberOfServerRequest(ServerRequest serverRequest)
        {
            return Monitor.HowMany(serverRequest);
        }

    }

    enum ServerRequest
    {
        GetCitiesRequest,
        GetStationInformationRequest,
        GetStationsRequest,
        GetStationsOfCityRequest
    };

}

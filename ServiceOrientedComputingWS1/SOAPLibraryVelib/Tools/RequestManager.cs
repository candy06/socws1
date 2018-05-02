using Newtonsoft.Json;
using SOAPLibraryVelib.Tools;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace SOAPLibraryVelib
{
    class RequestManager
    {
        // The API Key used to interract with the Vélib Service (JCDécaux)
        private const string _APIKey = "673d9eadb6a73d453e63b3908acb43dd4f05775b";
        // Object used to build URI that will be used to make our requests
        private URIBuilder _URIBuilder = new URIBuilder();

        /// <summary>
        /// Get more information of a given station 
        /// </summary>
        /// <param name="stationNumber"> the station ID </param>
        /// <param name="cityName"> the city name </param>
        /// <returns> Station object with all information we need </returns>
        public Station GetInformations(int stationNumber, string cityName)
        {
            // Inform the monitor that we've done a request to Vélib Service
            Monitor.AddServerRequest(ServerRequest.GetStationInformationRequest);
            // Get the response from the server (string)
            string responseFromServer = GetResponseFromServer(ServerRequest.GetStationInformationRequest, cityName, stationNumber);
            // Deserialize the response in a Station object
            Station station = JsonConvert.DeserializeObject<Station>(responseFromServer);
            return station;
        }

        /// <summary>
        /// Get the list of all stations in the Vélib Service
        /// </summary>
        /// <returns> the list of stations </returns>
        public List<Station> GetAllStations()
        {
            Monitor.AddServerRequest(ServerRequest.GetStationsRequest);
            string responseFromServer = GetResponseFromServer(ServerRequest.GetStationsRequest);
            List<Station> stations = JsonConvert.DeserializeObject<List<Station>>(responseFromServer);
            return stations;
        }
 
        /// <summary>
        /// Get the list of all cities in the Vélib Service
        /// </summary>
        /// <returns> the list of cities </returns>
        public List<City> GetCitiesRequest()
        {
            Monitor.AddServerRequest(ServerRequest.GetCitiesRequest);
            string responseFromServer = GetResponseFromServer(ServerRequest.GetCitiesRequest);
            List<City> cities = JsonConvert.DeserializeObject<List<City>>(responseFromServer);
            return cities;
        }

        /// <summary>
        /// Get the number of available bikes for a given station
        /// </summary>
        /// <param name="stationName"> the station name </param>
        /// <param name="cityName"> the city name </param>
        /// <returns> the number of available bikes </returns>
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

        /// <summary>
        /// Get the list of stations for a given city
        /// </summary>
        /// <param name="cityName"> the city name </param>
        /// <returns> the list of stations for the city </returns>
        public List<Station> GetStationsForCity(string cityName)
        {
            Monitor.AddServerRequest(ServerRequest.GetStationsOfCityRequest);
            string responseFromServer = GetResponseFromServer(ServerRequest.GetStationsOfCityRequest, cityName);
            List<Station> stations = JsonConvert.DeserializeObject<List<Station>>(responseFromServer);
            return stations;
        }

        /// <summary>
        /// Make a request to the Vélib Service by specifying the type of request
        /// </summary>
        /// <param name="requestType"> the server request </param>
        /// <param name="cityName"> the city name </param>
        /// <param name="stationNumber"> the station name </param>
        /// <returns> the string (response) sent by the Service </returns>
        private string GetResponseFromServer(ServerRequest requestType, string cityName = "", int stationNumber = 0)
        {
            WebRequest request = null;
            switch (requestType)
            {
                case ServerRequest.GetCitiesRequest:
                    request = WebRequest.Create(_URIBuilder.GenerateURI(ServerRequest.GetCitiesRequest, _APIKey));
                    break;
                case ServerRequest.GetStationsOfCityRequest:
                    request = WebRequest.Create(_URIBuilder.GenerateURI(ServerRequest.GetStationsOfCityRequest, _APIKey, cityName));
                    break;
                case ServerRequest.GetStationsRequest:
                    request = WebRequest.Create(_URIBuilder.GenerateURI(ServerRequest.GetStationsRequest, _APIKey));
                    break;
                case ServerRequest.GetStationInformationRequest:
                    request = WebRequest.Create(_URIBuilder.GenerateURI(ServerRequest.GetStationInformationRequest, _APIKey, cityName, stationNumber));
                    break;
                default:
                    break;
            }
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            return reader.ReadToEnd();
        }

        /// <summary>
        /// Get the average execution time of a given client request
        /// </summary>
        /// <param name="clientRequest"> the client request </param>
        /// <returns> the average execution time (in ms) </returns>
        public long GetAverageExecutionTimeOf(ClientRequest clientRequest)
        {
            return Monitor.GetAverageResponseDelay(clientRequest);
        }

        /// <summary>
        /// Get the number of connected clients
        /// </summary>
        /// <returns> the number of connected clients </returns>
        public int GetConnectedClient()
        {
            return Monitor.ConnectedClients;
        }

        /// <summary>
        /// Get the number of client requests done
        /// </summary>
        /// <param name="clientRequest"> the client request </param>
        /// <returns> the number of requests </returns>
        public int GetNumberOfClientRequest(ClientRequest clientRequest)
        {
            return Monitor.HowMany(clientRequest);
        }

        /// <summary>
        /// Get the number of server requests done
        /// </summary>
        /// <param name="clientRequest"> the server request </param>
        /// <returns> the number of requests </returns>
        public int GetNumberOfServerRequest(ServerRequest serverRequest)
        {
            return Monitor.HowMany(serverRequest);
        }

    }

}

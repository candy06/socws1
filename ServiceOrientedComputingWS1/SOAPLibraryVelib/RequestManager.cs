using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace SOAPLibraryVelib
{
    class RequestManager
    {

        private const string apiKey = "673d9eadb6a73d453e63b3908acb43dd4f05775b";
        private URIBuilder uriBuilder = new URIBuilder();

        public List<City> GetCitiesRequest()
        {
            string responseFromServer = GetResponseFromServer(RequestType.GetCitiesRequest);
            List<City> cities = JsonConvert.DeserializeObject<List<City>>(responseFromServer);
            return cities;
        }

        internal List<Station> GetStationsObjForCity(string cityName)
        {
            string responseFromServer = GetResponseFromServer(RequestType.GetStationsOfCityRequest, cityName);
            List<Station> stations = JsonConvert.DeserializeObject<List<Station>>(responseFromServer);
            return stations;
        }

        private string GetResponseFromServer(RequestType requestType, string cityName = "")
        {
            WebRequest request = null;
            switch (requestType)
            {
                case RequestType.GetCitiesRequest:
                    request = WebRequest.Create(uriBuilder.GenerateURI(URIType.GetCitiesURI, apiKey));
                    break;
                case RequestType.GetStationsOfCityRequest:
                    request = WebRequest.Create(uriBuilder.GenerateURI(URIType.GetStationsOfCityURI, apiKey, cityName));
                    break;
                default:
                    break;
            }
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            return reader.ReadToEnd();
        }
    }

    enum RequestType
    {
        GetCitiesRequest,
        GetStationInformationRequest,
        GetStationsRequest,
        GetStationsOfCityRequest
    };

}

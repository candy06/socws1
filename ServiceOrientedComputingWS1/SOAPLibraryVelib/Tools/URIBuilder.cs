using SOAPLibraryVelib.Tools;
using System;

namespace SOAPLibraryVelib
{
    class URIBuilder
    {
        /// <summary>
        /// Generate the correct URI that will be needed for a given request
        /// </summary>
        /// <param name="serverRequest"> the request </param>
        /// <param name="apiKey"> the API Key </param>
        /// <param name="cityName"> the city name </param>
        /// <param name="stationNumber"> the station name </param>
        /// <returns> the correct URI </returns>
        public string GenerateURI(ServerRequest serverRequest, string apiKey, string cityName = "", int stationNumber = 0)
        {
            switch (serverRequest)
            {
                case ServerRequest.GetCitiesRequest:
                    return GetCitiesURI(apiKey);
                case ServerRequest.GetStationsOfCityRequest:
                    return GetStationsOfCity(apiKey, cityName);
                case ServerRequest.GetStationsRequest:
                    return GetStations(apiKey);
                case ServerRequest.GetStationInformationRequest:
                    return GetStationInformation(apiKey, stationNumber, cityName);
                default:
                    return "";
            }
        }

        private string GetStationInformation(string apiKey, int stationNumber, string cityName)
        {
            return "https://api.jcdecaux.com/vls/v1/stations/" + stationNumber + "?contract=" + cityName + "&apiKey=" + apiKey;
        }

        private string GetStations(string apiKey)
        {
            return "https://api.jcdecaux.com/vls/v1/stations?apiKey=" + apiKey;
        }

        private string GetStationsOfCity(string apiKey, string cityName)
        {
            return "https://api.jcdecaux.com/vls/v1/stations?contract=" + cityName + "&apiKey=" + apiKey;
        }

        private string GetCitiesURI(string apiKey)
        {
            return "https://api.jcdecaux.com/vls/v1/contracts?apiKey=" + apiKey;
        }
    }

}

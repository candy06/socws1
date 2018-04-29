using System;

namespace SOAPLibraryVelib
{
    class URIBuilder
    {
        public string GenerateURI(URIType uri, string apiKey, string cityName = "", int stationNumber = 0)
        {
            switch (uri)
            {
                case URIType.GetCitiesURI:
                    return GetCitiesURI(apiKey);
                case URIType.GetStationsOfCityURI:
                    return GetStationsOfCity(apiKey, cityName);
                case URIType.GetStationsURI:
                    return GetStations(apiKey);
                case URIType.GetStationInformationURI:
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

    enum URIType
    {
        GetCitiesURI,
        GetStationInformationURI,
        GetStationsURI,
        GetStationsOfCityURI
    };
}

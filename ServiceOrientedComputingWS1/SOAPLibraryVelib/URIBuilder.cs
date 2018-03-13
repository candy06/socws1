using System;

namespace SOAPLibraryVelib
{
    class URIBuilder
    {
        public string GenerateURI(URIType uri, string apiKey, string cityName = "")
        {
            switch (uri)
            {
                case URIType.GetCitiesURI:
                    return GetCitiesURI(apiKey);
                case URIType.GetStationsOfCityURI:
                    return GetStationsOfCity(apiKey, cityName);
                default:
                    return "";
            }
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


namespace SOAPLibraryVelib
{
    /// <summary>
    /// All the client requests recensed. A client can ask for...
    /// </summary>
    enum ClientRequest
    {
        // the list of cities
        GetCities,
        // the number of available bikes for a station
        GetAvailableBikes,
        // the list of stations for a given city
        GetStationsForCity,
        // more information about the selected station
        GetInformations
    }
}

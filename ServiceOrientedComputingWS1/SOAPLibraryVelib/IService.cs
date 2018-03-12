using System.Collections.Generic;
using System.ServiceModel;

namespace SOAPLibraryVelib
{
    [ServiceContract]
    interface IService
    {
        [OperationContract]
        List<string> GetCities();

        [OperationContract]
        List<string> GetStationsNameForCity(string name);

        [OperationContract]
        int GetAvailableBikesForStation(string stationName, string cityName);
    }
}

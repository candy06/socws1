using System.Collections.Generic;
using System.ServiceModel;

namespace SOAPLibraryVelib
{
    [ServiceContract]
    interface IService
    {
        [OperationContract]
        List<City> GetCities();

        [OperationContract]
        Station GetStation(int station_number, string city_name);

        [OperationContract]
        List<Station> GetStations();

        [OperationContract]
        List<Station> GetStationsForCity(string city_name);
    }
}

using System.Collections.Generic;
using System.Runtime.Serialization;
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

    [DataContract]
    public class Position
    {
        [DataMember]
        public double lat { get; set; }
        [DataMember]
        public double lng { get; set; }
    }
}

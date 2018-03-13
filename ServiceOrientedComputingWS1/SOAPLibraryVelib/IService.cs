using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SOAPLibraryVelib
{
    [ServiceContract]
    interface IService
    {
        [OperationContract]
        List<string> GetStationsNameForCity(string name);

        [OperationContract]
        int GetAvailableBikesForStation(string stationName, string cityName);

        [OperationContract]
        List<City> GetCities();
    }

    [DataContract]
    public class City
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Commercial_name { get; set; }
        [DataMember]
        public List<string> Cities { get; set; }
        [DataMember]
        public string Country_code { get; set; }
    }
}

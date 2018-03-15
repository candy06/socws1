using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;

namespace SOAPLibraryVelib
{
    [ServiceContract]
    interface IService
    {
        [OperationContract]
        int GetAvailableBikesForStation(string stationName, string cityName);

        [OperationContract]
        List<City> GetCities();

        [OperationContract]
        List<Station> GetStationsOf(string cityName);
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

    [DataContract]
    public class Station
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public int Available_bikes { get; set; }
    }
}

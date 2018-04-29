using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

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

        [OperationContract]
        List<Station> GetAllStations();

        [OperationContract]
        string GetInformations(int stationNumber, string city);
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
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public Position Position { get; set; }
        [DataMember]
        public bool Banking { get; set; }
        [DataMember]
        public bool Bonus { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Contract_name { get; set; }
        [DataMember]
        public int Bike_stands { get; set; }
        [DataMember]
        public int Available_bike_stands { get; set; }
    }

    [DataContract]
    public class Position
    {
        [DataMember]
        public double Lat { get; set; }
        [DataMember]
        public double Lng { get; set; }
    }
}

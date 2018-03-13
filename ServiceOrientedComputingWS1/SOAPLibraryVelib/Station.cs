namespace SOAPLibraryVelib
{
    public class Station
    {
        public int number { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public bool banking { get; set; }
        public bool bonus { get; set; }
        public string status { get; set; }
        public string contract_name { get; set; }
        public int bike_stands { get; set; }
        public int available_bike_stands { get; set; }
        public int available_bikes { get; set; }
        public object last_update { get; set; }

        public class Position
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }
    }
}
using System.Collections.Generic;

namespace SOAPLibraryVelib
{
    public class City
    {
        public string name { get; set; }
        public List<string> cities { get; set; }
        public string commercial_name { get; set; }
        public string country_code { get; set; }
    }
}
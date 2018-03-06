using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace SOAPLibraryVelib
{
    class RequestManager
    {

        private const string apiKey = "673d9eadb6a73d453e63b3908acb43dd4f05775b";

        public List<City> GetCitiesRequest()
        {
            WebRequest request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/contracts?apiKey=" + apiKey);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            List<City> cities = JsonConvert.DeserializeObject<List<City>>(responseFromServer);
            return cities;
        }
    }
}

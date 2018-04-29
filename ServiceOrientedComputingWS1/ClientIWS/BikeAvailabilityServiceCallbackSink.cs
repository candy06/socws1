using ClientIWS.BikeAvailabilityEvent;
using System.Diagnostics;

namespace ClientIWS
{
    class BikeAvailabilityServiceCallbackSink : ISubscriberServiceCallback
    {
        public void BikeAvailabilityUpdate(string city, string station, double nbAvailableBikes)
        {
            Debug.WriteLine($"{city} {station} {nbAvailableBikes}");
        }

        
    }
}

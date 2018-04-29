using ClientIWS.BikeAvailabilityEvent;
using System.Diagnostics;

namespace ClientIWS
{
    class BikeAvailabilityServiceCallbackSink : ISubscriberServiceCallback
    {
        public void BikeAvailabilityUpdate(string city, string station, double nbAvailableBikes)
        {
            Debug.WriteLine($"Available bikes for station {station} ({city}) is {nbAvailableBikes}.");
        }

        
    }
}

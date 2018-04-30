using ClientIWS.BikeAvailabilityEvent;
using System.Diagnostics;

namespace ClientIWS
{
    class BikeAvailabilityServiceCallbackSink : ISubscriberServiceCallback
    {

        public BikeAvailabilityServiceCallbackSink(Form1 form)
        {
            Form = form;
        }

        public Form1 Form { get; private set; }

        public void BikeAvailabilityUpdate(string city, string station, double nbAvailableBikes)
        {
            Form.UpdateAvailableBikesNotification(city, station, nbAvailableBikes);
            Debug.WriteLine($"Available bikes for station {station} ({city}) is {nbAvailableBikes}.");
        }

        
    }
}

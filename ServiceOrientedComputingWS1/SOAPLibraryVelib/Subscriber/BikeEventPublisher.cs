using EventsLib;
using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Timers;

namespace SOAPLibraryVelib.Subscriber
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class BikeEventPublisher : ISubscriberService
    {

        private Timer refreshTimer = new Timer();
        private RequestManager rm = new RequestManager();

        public BikeEventPublisher()
        {
            refreshTimer.Elapsed += refreshTimerElapsed;
            refreshTimer.Interval = 10000; // 10 seconds
            refreshTimer.Start();
        }

        private void refreshTimerElapsed(object sender, ElapsedEventArgs e)
        {
            bikeAvailabilityUpdate("toto", "tata", 20);
        }

        static Action<string, string, double> bikeAvailabilityUpdate = delegate { };

        public void Subscribe(string city, string station, int refresh)
        {
            IBikeEvent subscriber = OperationContext.Current.GetCallbackChannel<IBikeEvent>();
            bikeAvailabilityUpdate += subscriber.BikeAvailabilityUpdate;
            Debug.WriteLine($"Client subscribes to {city} / {station} every {refresh} seconds.");
        }
    }
}

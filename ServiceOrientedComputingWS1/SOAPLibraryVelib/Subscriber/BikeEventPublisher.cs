using EventsLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel;
using System.Timers;

namespace SOAPLibraryVelib.Subscriber
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class BikeEventPublisher : ISubscriberService
    {
        private List<StationInfo> stationInfos = new List<StationInfo>();

        private Timer refreshTimer = new Timer();
        private RequestManager rm = new RequestManager();

        public BikeEventPublisher()
        {
            refreshTimer.Elapsed += RefreshTimerElapsed;
            refreshTimer.Interval = 20000; // 20 seconds
            refreshTimer.Start();
        }

        private void RefreshTimerElapsed(object sender, ElapsedEventArgs e)
        {
            foreach (StationInfo si in stationInfos)
            {
                double nbAvailableBikes = rm.GetAvailableBikes(si.StationName, si.CityName);
                bikeAvailabilityUpdate(si.StationName, si.CityName, nbAvailableBikes);
            }
        }

        static Action<string, string, double> bikeAvailabilityUpdate = delegate { };

        public void Subscribe(string city, string station, int refresh)
        {
            IBikeEvent subscriber = OperationContext.Current.GetCallbackChannel<IBikeEvent>();
            bikeAvailabilityUpdate += subscriber.BikeAvailabilityUpdate;
            stationInfos.Add(new StationInfo(station, city));
            Debug.WriteLine($"Client subscribes to {city} / {station} every {refresh} seconds.");
        }
    }
}

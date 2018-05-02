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
        private List<StationInfo> _stationInformation = new List<StationInfo>();

        private Timer _refreshTimer = new Timer();
        private RequestManager _requestManager = new RequestManager();

        /// <summary>
        /// Constructor to initialize the timer, the action that needs to be
        /// done and the rate (here it's 20 seconds). Every 20 seconds, the 
        /// service will do a request to have the number of available bikes
        /// for every subscribed stations
        /// </summary>
        public BikeEventPublisher()
        {
            _refreshTimer.Elapsed += RefreshTimerElapsed;
            _refreshTimer.Interval = 20000; // 20 seconds
            _refreshTimer.Start();
        }

        /// <summary>
        /// The action that needs to be done every 20 seconds.
        /// A request to the Vélib service will be done to know the number
        /// of available bikes and we will update the client (callback)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshTimerElapsed(object sender, ElapsedEventArgs e)
        {
            foreach (StationInfo si in _stationInformation)
            {
                double nbAvailableBikes = _requestManager.GetAvailableBikes(si.StationName, si.CityName);
                bikeAvailabilityUpdate(si.StationName, si.CityName, nbAvailableBikes);
            }
        }

        /// <summary>
        /// Action that will be done in the client side everytime we need
        /// </summary>
        static Action<string, string, double> bikeAvailabilityUpdate = delegate { };

        /// <summary>
        /// The exposed method to subscribe to a station
        /// </summary>
        /// <param name="city"> the city name </param>
        /// <param name="station"> the station name </param>
        /// <param name="refresh"> the refresh time (in ms) </param>
        public void Subscribe(string city, string station, int refresh)
        {
            IBikeEvent subscriber = OperationContext.Current.GetCallbackChannel<IBikeEvent>();
            bikeAvailabilityUpdate += subscriber.BikeAvailabilityUpdate;
            _stationInformation.Add(new StationInfo(station, city));
            Debug.WriteLine($"Client subscribes to {city} / {station} every {refresh} seconds.");
        }
    }
}

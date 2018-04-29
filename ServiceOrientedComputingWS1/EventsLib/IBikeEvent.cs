using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib
{
    public interface IBikeEvent
    {
        [OperationContract(IsOneWay = true)]
        void BikeAvailabilityUpdate(string city, string station, double nbAvailableBikes);
    }
}

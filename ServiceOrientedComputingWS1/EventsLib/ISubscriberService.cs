using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib
{
    [ServiceContract(CallbackContract = typeof(IBikeEvent))]
    public interface ISubscriberService
    {
        [OperationContract]
        void Subscribe(string city, string station, int refresh);
    }
}

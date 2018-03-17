using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SOAPLibraryVelib
{
    [ServiceContract]
    interface IMonitorService
    {

        [OperationContract]
        int GetConnectedClients();
    }


}

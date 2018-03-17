﻿using System.ServiceModel;

namespace SOAPLibraryVelib
{
    [ServiceContract]
    interface IMonitorService
    {
        [OperationContract]
        int GetConnectedClients();

        [OperationContract]
        int GetNumberOfClientRequests(ClientRequest request);

        [OperationContract]
        int GetNumberOfServerRequestsToVelibWS(ServerRequest request);
    }


}

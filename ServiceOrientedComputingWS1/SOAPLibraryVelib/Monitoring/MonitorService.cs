
namespace SOAPLibraryVelib
{
    class MonitorService : IMonitorService
    {
        private RequestManager rm = new RequestManager();

        public long GetAverageExecutionTime(ClientRequest request)
        {
            return rm.GetAverageExecutionTimeOf(request);
        }

        public int GetConnectedClients()
        {
            return rm.GetConnectedClient();
        }

        public int GetNumberOfClientRequests(ClientRequest request)
        {
            return rm.GetNumberOfClientRequest(request);
        }

        public int GetNumberOfServerRequestsToVelibWS(ServerRequest request)
        {
            return rm.GetNumberOfServerRequest(request);
        }
    }

}

using SOAPLibraryVelib.Tools;

namespace SOAPLibraryVelib
{
    class MonitorService : IMonitorService
    {
        private RequestManager _requestManager = new RequestManager();

        /// <summary>
        /// Get the average execution time for a given client request
        /// </summary>
        /// <param name="request"> the client request </param>
        /// <returns> the average execution time (in ms) </returns>
        public long GetAverageExecutionTime(ClientRequest request)
        {
            return _requestManager.GetAverageExecutionTimeOf(request);
        }

        /// <summary>
        /// Get the number of connected clients
        /// </summary>
        /// <returns> the number of connected clients </returns>
        public int GetConnectedClients()
        {
            return _requestManager.GetConnectedClient();
        }

        /// <summary>
        /// Get the number of client requests done
        /// </summary>
        /// <param name="request"> the client request </param>
        /// <returns> the number of time the request has been used </returns>
        public int GetNumberOfClientRequests(ClientRequest request)
        {
            return _requestManager.GetNumberOfClientRequest(request);
        }

        /// <summary>
        /// Get the number of requests done to the Vélib Service
        /// </summary>
        /// <param name="request"> the server request </param>
        /// <returns> the number of time the request has been used </returns>
        public int GetNumberOfServerRequestsToVelibWS(ServerRequest request)
        {
            return _requestManager.GetNumberOfServerRequest(request);
        }
    }

}
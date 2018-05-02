using SOAPLibraryVelib.Tools;
using System.Collections.Generic;

namespace SOAPLibraryVelib
{
    static class Monitor
    {
        // Used to store the number of connected clients
        public static int ConnectedClients { get; private set; }
        // Used to store a counter for every client request
        public static Dictionary<ClientRequest, int> clientRequestCounter = new Dictionary<ClientRequest, int>();
        // Used to store a counter for every server request
        public static Dictionary<ServerRequest, int> serverRequestCounter = new Dictionary<ServerRequest, int>();
        // Used to store all the execution times for every client request
        public static Dictionary<ClientRequest, List<long>> responseDelays = new Dictionary<ClientRequest, List<long>>();

        /// <summary>
        /// Store the execution time of a given client request into the dictionnary
        /// The idea is to store every execution times and then compute the average of each client request
        /// </summary>
        /// <param name="request"> the client request </param>
        /// <param name="executionTime"> the calculated execution time (in ms) </param>
        public static void AddExecutionTime(ClientRequest request, long executionTime)
        {
            // Check if we have already stored execution times for the given request
            if (responseDelays.ContainsKey(request))
                responseDelays[request].Add(executionTime);
            else
            {
                var list = new List<long>
                {
                    executionTime
                };
                responseDelays.Add(request, list);
            }
        }

        /// <summary>
        /// Compute the average execution time for a given client request.
        /// </summary>
        /// <param name="request"> the client request </param>
        /// <returns> the average execution time (in ms) </returns>
        public static long GetAverageResponseDelay(ClientRequest request)
        {
            if (!responseDelays.ContainsKey(request))
                return 0;
            else
            {
                long sumOfExecutionTimes = 0;
                foreach (int i in responseDelays[request])
                {
                    sumOfExecutionTimes += i;
                }
                return sumOfExecutionTimes / responseDelays[request].Count;
            }
        }

        /// <summary>
        /// Increment the counter that counts the number of client requests
        /// </summary>
        /// <param name="request"> the client request </param>
        public static void AddClientRequest(ClientRequest request)
        {
            if (clientRequestCounter.ContainsKey(request))
                clientRequestCounter[request]++;
            else
                clientRequestCounter.Add(request, 1);
        }

        /// <summary>
        /// Increment the counter that counts the number of server requests
        /// </summary>
        /// <param name="request"> the server request </param>
        public static void AddServerRequest(ServerRequest request)
        {
            if (serverRequestCounter.ContainsKey(request))
                serverRequestCounter[request]++;
            else
                serverRequestCounter.Add(request, 1);
        }

        /// <summary>
        /// Get the number of client requests done 
        /// </summary>
        /// <param name="request"> the client request </param>
        /// <returns> the number of time a client request has been used </returns>
        public static int HowMany(ClientRequest request)
        {
            if (!clientRequestCounter.ContainsKey(request))
                return 0;
            return clientRequestCounter[request];
        }

        /// <summary>
        /// Get the number of server requests done 
        /// </summary>
        /// <param name="request"> the server request </param>
        /// <returns> the number of time a server request has been used </returns>
        public static int HowMany(ServerRequest request)
        {
            if (!serverRequestCounter.ContainsKey(request))
                return 0;
            return serverRequestCounter[request];
        }

        /// <summary>
        /// Add a client
        /// </summary>
        public static void AddClient()
        {
            ConnectedClients++;
        }

        /// <summary>
        /// Remove a client
        /// </summary>
        public static void RemoveClient()
        {
            ConnectedClients--;
        }

    }
}

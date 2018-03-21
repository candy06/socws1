using System.Collections.Generic;

namespace SOAPLibraryVelib
{
    static class Monitor
    {

        public static int ConnectedClients { get; private set; }
        public static Dictionary<ClientRequest, int> clientRequestCounter = new Dictionary<ClientRequest, int>();
        public static Dictionary<ServerRequest, int> serverRequestCounter = new Dictionary<ServerRequest, int>();
        public static Dictionary<ClientRequest, List<long>> responseDelays = new Dictionary<ClientRequest, List<long>>();

        public static void AddExecutionTime(ClientRequest request, long executionTime)
        {
            if (responseDelays.ContainsKey(request))
                responseDelays[request].Add(executionTime);
            else
            {
                List<long> list = new List<long>();
                list.Add(executionTime);
                responseDelays.Add(request, list);
            }
        }

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

        public static void AddClientRequest(ClientRequest request)
        {
            if (clientRequestCounter.ContainsKey(request))
                clientRequestCounter[request]++;
            else
                clientRequestCounter.Add(request, 1);
        }

        public static void AddServerRequest(ServerRequest request)
        {
            if (serverRequestCounter.ContainsKey(request))
                serverRequestCounter[request]++;
            else
                serverRequestCounter.Add(request, 1);
        }

        public static int HowMany(ClientRequest request)
        {
            if (!clientRequestCounter.ContainsKey(request))
                return 0;
            return clientRequestCounter[request];
        }

        public static int HowMany(ServerRequest request)
        {
            if (!serverRequestCounter.ContainsKey(request))
                return 0;
            return serverRequestCounter[request];
        }

        public static void AddClient()
        {
            ConnectedClients++;
        }

        public static void RemoveClient()
        {
            ConnectedClients--;
        }

    }
}

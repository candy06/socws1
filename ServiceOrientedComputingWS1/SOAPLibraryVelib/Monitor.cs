using System.Collections.Generic;

namespace SOAPLibraryVelib
{
    static class Monitor
    {

        public static int ConnectedClients { get; private set; }
        public static Dictionary<ClientRequest, int> clientRequestCounter = new Dictionary<ClientRequest, int>();
        public static Dictionary<ServerRequest, int> serverRequestCounter = new Dictionary<ServerRequest, int>();

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

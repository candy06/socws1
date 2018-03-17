namespace SOAPLibraryVelib
{
    static class Monitor
    {

        public static int ConnectedClients { get; private set; }

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

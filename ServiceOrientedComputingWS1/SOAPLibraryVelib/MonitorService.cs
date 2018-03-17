
namespace SOAPLibraryVelib
{
    class MonitorService : IMonitorService
    {
        private RequestManager rm = new RequestManager();

        // About monitoring

        public int GetConnectedClients()
        {
            return rm.GetConnectedClient();
        }



    }

}
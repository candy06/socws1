using System;
using System.Windows.Forms;
using MonitoringClient.MonitorService;

namespace MonitoringClient
{
    public partial class Form1 : Form
    {

        private MonitorServiceClient client = new MonitorServiceClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOfConnectedClients = client.GetConnectedClients();
            label2.Text = "Connected clients: " + numberOfConnectedClients;
            label2.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clientRequestSelected = listBox1.SelectedItem.ToString();
            int n;
            switch (clientRequestSelected)
            {
                case "GetCities":
                    n = client.GetNumberOfClientRequests(ClientRequest.GetCities);
                    break;
                case "GetStations":
                    n = client.GetNumberOfClientRequests(ClientRequest.GetStationsForCity);
                    break;
                case "GetAvailableBikes":
                    n = client.GetNumberOfClientRequests(ClientRequest.GetAvailableBikes);
                    break;
                default:
                    n = -1;
                    break;

            }
            if (n == -1)
                label3.Text = "Error...";
            else
                label3.Text = clientRequestSelected + " called " + n + " times.";
            label3.Visible = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serverRequestSelected = listBox2.SelectedItem.ToString();
            int n;
            switch (serverRequestSelected)
            {
                case "StationInfo":
                    n = client.GetNumberOfServerRequestsToVelibWS(ServerRequest.GetStationInformationRequest);
                    break;
                case "StationsList":
                    n = client.GetNumberOfServerRequestsToVelibWS(ServerRequest.GetStationsRequest);
                    break;
                case "StationsOfGivenCity":
                    n = client.GetNumberOfServerRequestsToVelibWS(ServerRequest.GetStationsOfCityRequest);
                    break;
                case "CitiesList":
                    n = client.GetNumberOfServerRequestsToVelibWS(ServerRequest.GetCitiesRequest);
                    break;
                default:
                    n = -1;
                    break;

            }
            if (n == -1)
                label4.Text = "Error...";
            else
                label4.Text = serverRequestSelected + " called " + n + " times.";
            label4.Visible = true;
        }
    }
}

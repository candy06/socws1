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

        private void button2_Click(object sender, EventArgs e)
        {
            updateCharts();
        }

        private void updateCharts()
        {
            // Fill the fist chart with client requests
            chart1.Series["GetCities"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetNumberOfClientRequests(ClientRequest.GetCities));
            chart1.Series["GetStations"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetNumberOfClientRequests(ClientRequest.GetStationsForCity));
            chart1.Series["GetAvailableBikes"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetNumberOfClientRequests(ClientRequest.GetAvailableBikes));
            // Fill the second chart with requests to Velib WS
            chart2.Series["StationInfo"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetNumberOfServerRequestsToVelibWS(ServerRequest.GetStationInformationRequest));
            chart2.Series["StationsList"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetNumberOfServerRequestsToVelibWS(ServerRequest.GetStationsRequest));
            chart2.Series["StationsOfCity"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetNumberOfServerRequestsToVelibWS(ServerRequest.GetStationsOfCityRequest));
            chart2.Series["CitiesList"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetNumberOfServerRequestsToVelibWS(ServerRequest.GetCitiesRequest));
            // Fill the third chart with average execution times
            chart3.Series["GetCities"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetAverageExecutionTime(ClientRequest.GetCities));
            chart3.Series["GetStations"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetAverageExecutionTime(ClientRequest.GetStationsForCity));
            chart3.Series["GetAvailableBikes"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetAverageExecutionTime(ClientRequest.GetAvailableBikes));
            // Fill the fourth chart with the number of client connected
            chart4.Series["Connected clients"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetConnectedClients());
        }
    }
}

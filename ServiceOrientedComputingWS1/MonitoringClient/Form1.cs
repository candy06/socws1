using System;
using System.Windows.Forms;
using MonitoringClient.MonitorService;

namespace MonitoringClient
{
    public partial class Form1 : Form
    {
        private Timer _autoRefreshTimer = new Timer();
        private MonitorServiceClient client = new MonitorServiceClient();

        public Form1()
        {
            InitializeComponent();
            _autoRefreshTimer.Interval = 5000; // in ms
            _autoRefreshTimer.Enabled = false;
            _autoRefreshTimer.Tick += _autoRefreshTimer_Tick;
        }

        private void _autoRefreshTimer_Tick(object sender, EventArgs e)
        {
            updateCharts();
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
            chart1.Series["GetInformations"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetNumberOfClientRequests(ClientRequest.GetInformations));
            // Fill the second chart with requests to Velib WS
            chart2.Series["StationInfo"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetNumberOfServerRequestsToVelibWS(ServerRequest.GetStationInformationRequest));
            chart2.Series["StationsList"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetNumberOfServerRequestsToVelibWS(ServerRequest.GetStationsRequest));
            chart2.Series["StationsOfCity"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetNumberOfServerRequestsToVelibWS(ServerRequest.GetStationsOfCityRequest));
            chart2.Series["CitiesList"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetNumberOfServerRequestsToVelibWS(ServerRequest.GetCitiesRequest));
            // Fill the third chart with average execution times
            chart3.Series["GetCities"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetAverageExecutionTime(ClientRequest.GetCities));
            chart3.Series["GetStations"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetAverageExecutionTime(ClientRequest.GetStationsForCity));
            chart3.Series["GetAvailableBikes"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetAverageExecutionTime(ClientRequest.GetAvailableBikes));
            chart3.Series["GetInformations"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetAverageExecutionTime(ClientRequest.GetInformations));
            // Fill the fourth chart with the number of client connected
            chart4.Series["Connected clients"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), client.GetConnectedClients());

            button2.Text = "Update charts";
        }

        private void uxAutoRefreshField_CheckedChanged(object sender, EventArgs e)
        {
            _autoRefreshTimer.Enabled = (uxAutoRefreshField.Checked);
            button2.Enabled = (!uxAutoRefreshField.Checked);
        }
    }
}

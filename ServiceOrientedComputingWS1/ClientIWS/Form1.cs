using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel;
using System.Windows.Forms;
using ClientIWS.BikeAvailabilityEvent;
using ClientIWS.IWSVelibService;
using GMap.NET;
using GMap.NET.MapProviders;

namespace ClientIWS
{
    public partial class Form1 : Form
    {

        private ServiceClient client = new ServiceClient();
        private SubscriberServiceClient subscriberClient;
        private string selectedCity = "None";
        private string selectedStation = "None";
        private List<Station> stationsList = new List<Station>();


        public Form1()
        {
            InitializeComponent();
            var objsink = new BikeAvailabilityServiceCallbackSink(this);
            var iCntxt = new InstanceContext(objsink);
            subscriberClient = new SubscriberServiceClient(iCntxt);
        }

        public void UpdateAvailableBikesNotification(string city, string station, double nbAvailableBikes)
        {
            Invoke(new Action(() =>
           {
               labelUpdateAvailableBikes.Text = $"{DateTime.Now.ToShortTimeString()}: {nbAvailableBikes} bike(s) for station {station}/{city}.";
           }));
                
        }

        // Display or update the execution time
        private void UpdateAndDisplayExecutionTimeClientSide(long executionTime)
        {
            labelExecutionTime.Text = $"Execution time: {executionTime} ms";
            labelExecutionTime.Visible = true;
        }

        // Find the station object
        private Station GetSelectedStation()
        {
            foreach (Station s in stationsList)
            {
                if (s.Name.Equals(selectedStation))
                    return s;
            }
            return null;
        }

        // This method move the side bar when we click on a button
        private void UpdateLeftBar(Button button)
        {
            panelLeft.Visible = true;
            panelLeft.Height = button.Height;
            panelLeft.Top = button.Top;
        }

        // This method update the label title
        private void UpdateTitleLabel(string title)
        {
            labelTitle.Text = title;
            labelTitle.Visible = true;
        }

        // This method display the error message when its needed
        private void DisplayErrorMessage(string errorMessage)
        {
            labelError.Text = errorMessage;
            labelError.Visible = true;
        }

        private void ButtonCities_Click(object sender, EventArgs e)
        {
            UpdateLeftBar(buttonCities);
            UpdateTitleLabel("Cities list");

            // Set invisible other elements of main frame
            listBoxStations.Visible = false;
            labelError.Visible = false;
            labelAvailableBikes.Visible = false;
            labelMoreInformation.Visible = false;

            // Update execution time client-side
            Stopwatch stopwatch = Stopwatch.StartNew();
            City[] cities = client.GetCities();
            stopwatch.Stop();
            UpdateAndDisplayExecutionTimeClientSide(stopwatch.ElapsedMilliseconds);

            for (int i = 0; i < cities.Length; i++)
            {
                listBoxCities.Items.Add(cities[i].Name);
            }

            // Set visible what concerns the city things
            listBoxCities.Visible = true;

            if (!selectedCity.Equals("None"))
                buttonSelectCity.Visible = true;

            SelectNewCity();

        }

        private void ButtonStations_Click(object sender, EventArgs e)
        {
            // Update position of side bar
            UpdateLeftBar(buttonStations);

            // Set invisible other elements of main frame
            listBoxCities.Visible = false;
            buttonSelectCity.Visible = false;
            labelTitle.Visible = false;
            labelAvailableBikes.Visible = false;
            labelError.Visible = false;
            labelMoreInformation.Visible = false;

            if (selectedCity.Equals("None"))
            {
                DisplayErrorMessage("Error: please, select a city!");
                labelExecutionTime.Visible = false;
                return;
            }

            /** from this point we know that a city is selected **/

            UpdateTitleLabel("Stations list");
            
            listBoxStations.Items.Clear();
            Stopwatch stopwatch = Stopwatch.StartNew();
            Station[] stations = client.GetStationsOf(selectedCity);
            stopwatch.Stop();
            UpdateAndDisplayExecutionTimeClientSide(stopwatch.ElapsedMilliseconds);
            for (int i = 0; i < stations.Length; i++)
            {
                listBoxStations.Items.Add(stations[i].Name);
                stationsList.Add(stations[i]);
            }

            // Set visible what concerns the city things
            listBoxStations.Visible = true;

            SelectNewStation();
        }

        private void ButtonBikes_Click(object sender, EventArgs e)
        {
            GetAvailableBikes();
        }

        private void GetAvailableBikes()
        {
            UpdateLeftBar(buttonBikes);

            // Set invisible other elements of main frame
            listBoxCities.Visible = false;
            listBoxStations.Visible = false;
            labelTitle.Visible = false;
            buttonSelectCity.Visible = false;
            labelError.Visible = false;
            labelMoreInformation.Visible = false;

            if (selectedCity.Equals("None") || selectedStation.Equals("None"))
            {
                DisplayErrorMessage("Error: please, select a city and a station!");
                labelExecutionTime.Visible = false;
                return;
            }

            /** from this point we know that a city and a station are selected **/

            UpdateTitleLabel("Available bikes");

            Stopwatch stopwatch = Stopwatch.StartNew();
            int availableBikes = client.GetAvailableBikesForStation(selectedStation, selectedCity);
            stopwatch.Stop();
            UpdateAndDisplayExecutionTimeClientSide(stopwatch.ElapsedMilliseconds);
            labelAvailableBikes.Text = "" + availableBikes;
            labelAvailableBikes.Visible = true;

            // Display the map
            Station station = GetSelectedStation();
            map.Visible = true;
            map.MapProvider = GMapProviders.GoogleMap;
            double lat = station.Position.Lat;
            double lng = station.Position.Lng;
            map.Position = new PointLatLng(lat, lng);
        }

        private void ButtonMoreInformation_Click(object sender, EventArgs e)
        {
            GetMoreInfo();
        }

        private void GetMoreInfo()
        {
            UpdateLeftBar(buttonMoreInformation);

            // Set invisible other elements of main frame
            listBoxCities.Visible = false;
            listBoxStations.Visible = false;
            labelTitle.Visible = false;
            buttonSelectCity.Visible = false;
            labelAvailableBikes.Visible = false;
            labelError.Visible = false;

            if (selectedStation.Equals("None") || selectedCity.Equals("None"))
            {
                DisplayErrorMessage("Error: please, select a city and a station!");
                labelExecutionTime.Visible = false;
                return;
            }

            /** from this point we know that a station is selected **/

            UpdateTitleLabel("More information");

            Station station = GetSelectedStation();
            Stopwatch stopwatch = Stopwatch.StartNew();
            string informations = client.GetInformations(station.Number, selectedCity);
            stopwatch.Stop();
            UpdateAndDisplayExecutionTimeClientSide(stopwatch.ElapsedMilliseconds);
            labelMoreInformation.Text = informations;
            labelMoreInformation.Visible = true;
        }

        // About city selection
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCity = (string)listBoxCities.SelectedItem;
            labelSelectedCity.Text = selectedCity;
            listBoxCities.Enabled = false;
            buttonSelectCity.Visible = true;

            // Update stations list box
            listBoxStations.Items.Clear();
            listBoxStations.Enabled = true;

            // Update selected station to none
            selectedStation = "None";
            labelSelectedStation.Text = selectedStation;
        }

        private void ButtonSelectCity_Click(object sender, EventArgs e)
        {
            SelectNewCity();
        }

        private void SelectNewCity()
        {
            selectedCity = "None";
            listBoxCities.Enabled = true;
            buttonSelectCity.Visible = false;
            labelSelectedCity.Text = selectedCity;
            map.Visible = false;
        }

        // About station selection
        private void ListBoxStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStation = (string)listBoxStations.SelectedItem;
            labelSelectedStation.Text = selectedStation;
            listBoxStations.Enabled = false;
            GetAvailableBikes();
        }

        private void ButtonSelectStation_Click(object sender, EventArgs e)
        {
            SelectNewStation();
        }

        private void SelectNewStation()
        {
            selectedStation = "None";
            listBoxStations.Enabled = true;
            labelSelectedStation.Text = selectedStation;
            map.Visible = false;
        }

        private void SubscribeButton_Click(object sender, EventArgs e)
        {
            subscriberClient.Subscribe(selectedCity, selectedStation, 10);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientIWS.IWSVelibService;

namespace ClientIWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ServiceClient client = new ServiceClient();
        private string selectedCity = "None";
        private string selectedStation = "None";
        private List<Station> stationsList = new List<Station>();

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
            buttonSelectStation.Visible = false;
            labelAvailableBikes.Visible = false;
            labelMoreInformation.Visible = false;

            City[] cities = client.GetCities();
            for (int i = 0; i < cities.Length; i++)
            {
                listBoxCities.Items.Add(cities[i].Name);
            }

            // Set visible what concerns the city things
            listBoxCities.Visible = true;

            if (!selectedCity.Equals("None"))
                buttonSelectCity.Visible = true;

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
                return;
            }

            /** from this point we know that a city is selected **/

            UpdateTitleLabel("Stations list");
            
            listBoxStations.Items.Clear();
            Station[] stations = client.GetStationsOf(selectedCity);
            for (int i = 0; i < stations.Length; i++)
            {
                listBoxStations.Items.Add(stations[i].Name);
                stationsList.Add(stations[i]);
            }

            // Set visible what concerns the city things
            listBoxStations.Visible = true;

            if (!selectedStation.Equals("None"))
                buttonSelectStation.Visible = true;
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
            buttonSelectStation.Visible = false;
            buttonSelectCity.Visible = false;
            labelError.Visible = false;
            labelMoreInformation.Visible = false;

            if (selectedCity.Equals("None") || selectedStation.Equals("None"))
            {
                DisplayErrorMessage("Error: please, select a city and a station!");
                return;
            }

            /** from this point we know that a city and a station are selected **/

            UpdateTitleLabel("Available bikes");

            int availableBikes = client.GetAvailableBikesForStation(selectedStation, selectedCity);
            labelAvailableBikes.Text = "" + availableBikes;
            labelAvailableBikes.Visible = true;
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
            buttonSelectStation.Visible = false;
            buttonSelectCity.Visible = false;
            labelAvailableBikes.Visible = false;
            labelError.Visible = false;

            if (selectedStation.Equals("None") || selectedCity.Equals("None"))
            {
                DisplayErrorMessage("Error: please, select a city and a station!");
                return;
            }

            /** from this point we know that a station is selected **/

            UpdateTitleLabel("More information");

            Station station = GetSelectedStation();
            string informations = client.GetInformations(station.Number, selectedCity);
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
            selectedCity = "None";
            listBoxCities.Enabled = true;
            buttonSelectCity.Visible = false;
            labelSelectedCity.Text = selectedCity;
        }

        // About station selection
        private void ListBoxStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStation = (string)listBoxStations.SelectedItem;
            labelSelectedStation.Text = selectedStation;
            listBoxStations.Enabled = false;
            buttonSelectStation.Visible = true;
            GetAvailableBikes();
        }

        private void ButtonSelectStation_Click(object sender, EventArgs e)
        {
            selectedStation = "None";
            listBoxStations.Enabled = true;
            buttonSelectStation.Visible = false;
            labelSelectedStation.Text = selectedStation;
        }
    }
}

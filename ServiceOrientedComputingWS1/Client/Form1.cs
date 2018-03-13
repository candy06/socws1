using Client.MyVelibService;
using System;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {

        private ServiceClient client = new ServiceClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cities = client.GetCities();
            for (int i = 0; i < cities.Length; i++)
            {
                citiesList.Items.Add(cities[i]);
            }
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stationsList.Items.Clear();
            string citySelectedName = (string) citiesList.SelectedItem;
            string[] stationsNames = client.GetStationsNameForCity(citySelectedName);
            for (int i = 0; i < stationsNames.Length; i++)
            {
                stationsList.Items.Add(stationsNames[i]);
            }
            button2.Enabled = false;
            stationsList.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string city = (string) citiesList.SelectedItem;
            string station = (string)stationsList.SelectedItem;
            int availableBikes = client.GetAvailableBikesForStation(station, city);
            label1.Text = "Available bikes: " + availableBikes;
            label1.Visible = true;
        }

        private void citiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            citiesList.Enabled = false;
            selectNewCityButton.Enabled = true;

            stationsList.Items.Clear();

            button2.Enabled = true;

        }

        private void selectNewCityButton_Click(object sender, EventArgs e)
        {
            citiesList.Enabled = true;
            selectNewCityButton.Enabled = false;

            label1.Visible = false;
        }

        private void stationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            stationsList.Enabled = false;
            selectNewStationButton.Enabled = true;

            button3.Enabled = true;
        }

        private void selectNewStationButton_Click(object sender, EventArgs e)
        {
            stationsList.Enabled = true;
            selectNewStationButton.Enabled = false;

            button3.Enabled = false;

            label1.Visible = false;
        }
    }
}

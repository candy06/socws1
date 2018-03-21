using Client.MyVelibService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Client
{

    public partial class Form1 : Form
    {

        private ServiceClient client = new ServiceClient();
        private List<Station> selectedStations = new List<Station>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            citiesList.Items.Clear();

            Stopwatch stopwatch = Stopwatch.StartNew();
            City[] cityObjects = client.GetCities();
            stopwatch.Stop();
            int s = cityObjects.Length;
            for (int i = 0; i < s; i++)
            {
                citiesList.Items.Add(cityObjects[i].Name);
            }

            label1.Visible = false;

            label3.Text = "Execution time of GetCities: " + stopwatch.ElapsedMilliseconds + "ms";
            label3.Visible = true;

            citiesList.Enabled = true;

            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stationsList.Items.Clear();
            selectedStations.Clear();
            Stopwatch stopwatch = Stopwatch.StartNew();
            Station[] stations = client.GetStationsOf((string)citiesList.SelectedItem);
            stopwatch.Stop();
            int s = stations.Length;
            for (int i = 0; i < s; i++)
            {
                stationsList.Items.Add(stations[i].Name);
                selectedStations.Add(stations[i]);
            }

            selectNewStationButton.Enabled = false;

            label4.Text = "Execution time of GetStationsOf: " + stopwatch.ElapsedMilliseconds + "ms";
            label4.Visible = true;

            button2.Enabled = false;
            stationsList.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string city = (string) citiesList.SelectedItem;
            string station = (string) stationsList.SelectedItem;

            Stopwatch stopwatch = Stopwatch.StartNew();
            int availableBikes = client.GetAvailableBikesForStation(station, city);
            stopwatch.Stop();

            label5.Text = "Execution time of GetAvailableBikes: " + stopwatch.ElapsedMilliseconds + "ms";
            label5.Visible = true;

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

            button2.Enabled = false;
            button3.Enabled = false;
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

        private Station findSelectedStation(string stationName)
        {
            foreach (Station s in selectedStations)
            {
                if (s.Name.Equals(stationName))
                    return s;
            }
            return null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string station = (string)stationsList.SelectedItem;
            string city = (string)citiesList.SelectedItem;
            Station selectedStation = findSelectedStation(station);
            Stopwatch stopwatch = Stopwatch.StartNew();
            string informations = client.GetInformations(selectedStation.Number, city);
            stopwatch.Stop();
            label8.Text = "Execution time of GetInformations: " + stopwatch.ElapsedMilliseconds + "ms";
            label8.Visible = true;
            label7.Text = informations;
        }
    }
}

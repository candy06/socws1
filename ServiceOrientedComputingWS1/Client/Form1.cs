using Client.MyVelibService;
using System;
using System.Diagnostics;
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
            citiesList.Items.Clear();

            Stopwatch stopwatch = Stopwatch.StartNew();
            City[] cityObjects = client.GetCities();
            int s = cityObjects.Length;
            for (int i = 0; i < s; i++)
            {
                citiesList.Items.Add(cityObjects[i].Name);
            }
            stopwatch.Stop();

            label3.Text = "Execution time: " + stopwatch.ElapsedMilliseconds + "ms";
            label3.Visible = true;

            //button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stationsList.Items.Clear();
            Station[] stationObjs = client.GetStationsOf((string)citiesList.SelectedItem);
            int s = stationObjs.Length;
            for (int i = 0; i < s; i++)
            {
                stationsList.Items.Add(stationObjs[i].Name);
            }
            button2.Enabled = false;
            stationsList.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string city = (string) citiesList.SelectedItem;
            string station = (string) stationsList.SelectedItem;
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

        private void button4_Click(object sender, EventArgs e)
        {
            citiesList.Items.Clear();
            label3.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.VelibSOAPService;

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
            City[] cities = client.GetCities();
            for (int i = 0; i < cities.Length; i++)
            {
                citiesList.Items.Add(cities[i].name);
            }
        }
    }
}

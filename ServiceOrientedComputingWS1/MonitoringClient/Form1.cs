using System;
using System.Windows.Forms;
using MonitoringClient.MonitorService;

namespace MonitoringClient
{
    public partial class Form1 : Form
    {

        private MonitorServiceClient _client = new MonitorServiceClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOfConnectedClients = _client.GetConnectedClients();
            label2.Text = "Connected clients: " + numberOfConnectedClients;
            label2.Visible = true;
        }
    }
}

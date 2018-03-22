using System;
using System.Windows.Forms;

namespace CalculatorClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private CalculatorService.CalculatorClient clientEndpoint1 = new CalculatorService.CalculatorClient("Endpoint1");
        private CalculatorService.CalculatorClient clientEndpoint2 = new CalculatorService.CalculatorClient("Endpoint2");

        // Update result field
        private void UpdateResult(int result)
        {
            labelResult.Text = $"Result: {result}";
        }

        private void buttonSumEP1_Click(object sender, EventArgs e)
        {
            UpdateResult(clientEndpoint1.Sum(Int32.Parse(textBoxA.Text), Int32.Parse(textBoxB.Text)));
        }

        private void buttonSubEP1_Click(object sender, EventArgs e)
        {
            UpdateResult(clientEndpoint1.Substraction(Int32.Parse(textBoxA.Text), Int32.Parse(textBoxB.Text)));
        }

        private void buttonSumEP2_Click(object sender, EventArgs e)
        {
            UpdateResult(clientEndpoint2.Sum(Int32.Parse(textBoxA.Text), Int32.Parse(textBoxB.Text)));
        }

        private void buttonSubEP2_Click(object sender, EventArgs e)
        {
            UpdateResult(clientEndpoint2.Substraction(Int32.Parse(textBoxA.Text), Int32.Parse(textBoxB.Text)));
        }
    }
}

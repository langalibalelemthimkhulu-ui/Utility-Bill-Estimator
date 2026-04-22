using System;
using System.Windows.Forms;

namespace Utility_Bill_Estimator
{
    public partial class Form1 : Form
    {
        // Constructor – this MUST call InitializeComponent
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate Bill button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double usageKwh, ratePerKwh, total;

            if (!double.TryParse(txtUsageKwh.Text, out usageKwh) || usageKwh < 0)
            {
                MessageBox.Show("Enter a valid electricity usage in kWh");
                return;
            }

            if (!double.TryParse(txtRatePerKwh.Text, out ratePerKwh) || ratePerKwh < 0)
            {
                MessageBox.Show("Enter a valid cost per kWh");
                return;
            }

            total = usageKwh * ratePerKwh;
            lblTotal.Text = total.ToString("R0.00");
        }

        // Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsageKwh.Clear();
            txtRatePerKwh.Clear();
            lblTotal.Text = "R0.00";
        }
    }
}
using System;
using System.Windows.Forms;

namespace BMI_with_interface
{
    public partial class Metric : Form
    {
        public Metric()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TBBMImet.Clear();
            TBCatmet.Clear();
            NudFeet.Value = 0;
            NudStones.Value = 0;
            MessageBox.Show("All Clear");
        }
    }
}

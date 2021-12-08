using System;
using System.Windows.Forms;

namespace BMI_with_interface
{
    public partial class Metric : Form
    {
        public int bmimet;
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
            bmiTextMet.Clear();
            CatMet.Clear();
            NudFeet.Value = 0;
            NudStones.Value = 0;
            MessageBox.Show("All Clear");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int heightfeet = (int)NudFeet.Value;
            int weightstone = (int)NudStones.Value;
            bmimet = weightstone / heightfeet * 703;
            if (heightfeet > 0)
            {
                if (weightstone > 0)
                {
                    bmiTextMet.Text = Convert.ToString(bmimet);
                    if (bmimet < 18)
                    {
                        CatMet.Text = ("Underweight");
                    }
                    else if (bmimet >= 18 && bmimet <= 25)
                    {
                        CatMet.Text = ("Normal");
                    }
                    else if (bmimet >= 25 && bmimet <= 30)
                    {
                        CatMet.Text = ("Overweight");
                    }
                    else if (bmimet > 30)
                    {
                        CatMet.Text = ("Obese");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error!!! Please enter a value for each option in the metric Standard!!!");
            }
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

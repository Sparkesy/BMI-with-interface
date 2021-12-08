using System;
using System.Windows.Forms;

namespace BMI_with_interface
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Imperial().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Metric().Show();
            this.Hide();
        }
    }
}

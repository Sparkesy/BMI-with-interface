using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_with_interface
{
    public static int bmimet;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NudStones_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NudInch_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int heightinch = (int)NudInch.Value;
            int weightpound = (int)NudPounds.Value;
            int heightfeet = (int)NudFeet.Value;
            int weightstone = (int)NudStones.Value;
            if(NudStones.Value > 0)
            {
                if (NudFeet.Value > 0)
                {
                    int bmiimp = weightpound / heightinch * 703;
                }
            }
            if (NudPounds.Value > 0)
            {
                if (NudInch.Value > 0)
                {
                    int bmimet = weightstone / heightfeet * 703;
                }
            }
            int bmimet = weightstone / heightfeet * 703;
            if (heightinch > 0)
            {
                if (weightpound > 0)
                {
                    TBBMI.Text = Convert.ToString(bmiimp);
                }
            }
            else if (heightfeet > 0)
            {
                if (weightstone > 0)
                {
                    TBBMI.Text = Convert.ToString(bmimet);
                    if (bmimet < 18)
                    {
                        TBCat.Text = ("Underweight");
                    }
                    else if (bmimet >= 18 && bmimet <= 25)
                    {
                        TBCat.Text = ("Normal");
                    }
                    else if (bmimet >= 25 && bmimet <= 30)
                    {
                        TBCat.Text = ("Overweight");
                    }
                    else if (bmimet > 30)
                    {
                        TBCat.Text = ("Obese");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error!!! Please enter a value for each option in either the metric or imperial sides.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TBBMI.Clear();
            TBCat.Clear();
            NudPounds.Value = 0;
            NudInch.Value = 0;
            NudFeet.Value = 0;
            NudStones.Value = 0;
            MessageBox.Show("All Clear");
        }
    }
}

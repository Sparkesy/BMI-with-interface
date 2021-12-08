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
    public partial class Imperial : Form
    {
        public static int bmiimp;
        public Imperial()
        {
            InitializeComponent();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bmiTextimp.Clear();
            Catimp.Clear();
            NudFeet.Value = 0;
            NuDInch.Value = 0;
            NUDPoundImp.Value = 0;
            NudStones.Value = 0;
            MessageBox.Show("All Clear");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int impheight = (int)NudFeet.Value / 12 + (int)NuDInch.Value;
            int weightimp = (int)NudStones.Value / 14 + (int)NUDPoundImp.Value;
            bmiimp = weightimp / impheight / impheight * 703;
            if (NudStones.Value > 0)
            {
                if (NudFeet.Value > 0)
                {
                    bmiTextimp.Text = Convert.ToString(bmiimp);
                    if (bmiimp < 18)
                    {
                        Catimp.Text = ("Underweight");
                    }
                    else if (bmiimp >= 18 && bmiimp <= 25)
                    {
                        Catimp.Text = ("Normal");
                    }
                    else if (bmiimp >= 25 && bmiimp <= 30)
                    {
                        Catimp.Text = ("Overweight");
                    }
                    else if (bmiimp > 30)
                    {
                        Catimp.Text = ("Obese");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error!!! Please enter a value for each box!!!");
            }
        }
    }
}

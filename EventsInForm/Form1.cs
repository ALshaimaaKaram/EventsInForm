using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsInForm
{
    public partial class converter : Form
    {
        public converter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "")
            {
                float val = float.Parse(txtValue.Text);
                if (radMetrToKilo.Checked)
                {
                    txtResult.Text = (val / 1000).ToString();
                }
                else if(radMToMile.Checked)
                {
                    txtResult.Text = (val / 1609.344).ToString();
                }
                else if(radMileToM.Checked)
                {
                    txtResult.Text = (val * 1609.344).ToString();
                }
            }
            else
            {
                txtResult.Text = "Enter Value";
            }
        }

    }
}


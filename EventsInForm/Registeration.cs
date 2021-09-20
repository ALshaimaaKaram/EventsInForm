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
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //if(txtName.Text.Length < 5)
            //{
            //    //Label label = new Label();
            //    //label.Text = "Name must contain at least 5 Character";
            //    //label.Location = new Point(302, 46);
            //    //Controls.Add(label);
            //    lblNameError.Visible = true;
            //}
            //if(!txtEmail.Text.Contains("@"))
            //{
            //    lblEmailError.Visible = true;
            //}
            //if(!(ckbFootball.Checked || ckbSwimming.Checked || ckbTennis.Checked))
            //{
            //    lblHoppiesError.Visible = true;
            //}
            //if (!(lblNameError.Visible || lblEmailError.Visible || lblHoppiesError.Visible))
            //{
            //    lblRegist.Visible = true;
            //}

            lblEmailError.Visible = !txtEmail.Text.Contains("@");
            lblNameError.Visible = txtName.Text.Length < 5;
            lblHoppiesError.Visible = !(ckbFootball.Checked || ckbSwimming.Checked || ckbTennis.Checked);

            lblRegist.Visible = !(lblNameError.Visible || lblEmailError.Visible || lblHoppiesError.Visible);
        }
    }
}

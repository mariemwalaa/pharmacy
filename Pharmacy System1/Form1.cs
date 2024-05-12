using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy_System1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text =="btechdays" &&  txtPassword.Text =="pass")
            {
                Adminstraitor am = new Adminstraitor();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

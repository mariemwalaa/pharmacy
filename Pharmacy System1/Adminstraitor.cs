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
    public partial class Adminstraitor : Form
    {
        public Adminstraitor()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();    
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = true;
            uC_Dashbord1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Adminstraitor_Load(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = false;
            uC_AddUser1.Visible = false;
            btnDashbord.PerformClick();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible=true;
            uC_AddUser1.BringToFront();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy_System1.AdminstraitorUC
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String DOB = txtDOB.Text;
            Int64 mobile = Int64.Parse(txtMobileNumber.Text);
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            try
            {
                query = "insert into users()";
            }
            catch(Exception ex)
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy_System1
{
    internal class function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-8C4RN6S;database=Pharmacy System;integrates security=True";
            return conn;
        }

        public DataSet getData(String query)
        {
            SqlConnection con= GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(string query,string Msg)
        {
            SqlConnection con= GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(Msg,"information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

    }
}

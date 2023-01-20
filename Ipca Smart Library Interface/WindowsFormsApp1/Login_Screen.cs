using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class sql
    {
        public static SqlConnection con;
    }

    public partial class Login_Screen : Form
    {

        public Login_Screen()
        {
            InitializeComponent();
        }

        private void login_user_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = login_user_input.Text;
            password = login_password_input.Text;
            string connectionString = $@"Data Source=JOTAPC\AULAS;Initial Catalog=IPCA_SMART_LIBRARY;User ID={username};Password={password}";
            //modifiedConnectionString = connectionString.Insert(68,username); deprecated
            //finalConnectionString = modifiedConnectionString.Insert(80, password); deprecated
            try
            {
                sql.con = new SqlConnection(connectionString);
                sql.con.Open();
                MessageBox.Show("Login Successful!");
                new Form1().Show();
                this.Hide();
            }
            catch(Exception name)
            {
                MessageBox.Show("Login failed due to: " + name.Message);
            }
        }
    }
}

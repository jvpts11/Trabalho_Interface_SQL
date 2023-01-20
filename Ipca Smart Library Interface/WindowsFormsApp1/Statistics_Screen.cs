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
    public partial class Statistics_Screen : Form
    {
        public Statistics_Screen()
        {
            InitializeComponent();
        }

        private void statistics_students_service_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select distinct count(STUNumber) from Student", sql.con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not do the action due: " + ex.Message);
            }
        }

        private void statistics_students_app_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand command = new SqlCommand("Select Count ([AppAccount].StudentEmail) from AppAccount join Student on AppAccount.StudentEmail = Student.StudentEmail", sql.con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not do the action due: " + ex.Message);
            }
        }

        private void statistics_return_extension_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet Implemented, use the custom query window to do this");
        }

        private void statistics_return_delays_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet Implemented, use the custom query window to do this");
        }

        private void statistics_returned_books_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet Implemented, use the custom query window to do this");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from Student", sql.con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not add student due to: " + ex.Message);
            }
        }
    }
}

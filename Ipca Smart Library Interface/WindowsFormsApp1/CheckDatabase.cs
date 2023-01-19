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
    public partial class CheckDatabase : Form
    {
        public CheckDatabase()
        {
            InitializeComponent();
        }

        private void showEditors_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from Editor", sql.con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not make it due to: " + ex.Message);
            }
        }

        private void showBookTypes_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from BookType", sql.con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not make it due to: " + ex.Message);
            }
        }

        private void showOrders_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from Order", sql.con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not make it due to: " + ex.Message);
            }
        }

        private void showDigitalBookTypes_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from DigitalBookType", sql.con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not make it due to: " + ex.Message);
            }
        }

        private void showBookOrders_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from BooksBuyOrder", sql.con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not make it due to: " + ex.Message);
            }
        }
    }
}

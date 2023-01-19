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
    public partial class SpecialQueryScreen : Form
    {
        public SpecialQueryScreen()
        {
            InitializeComponent();
        }

        private void custom_query_execute_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand($"{query_input.Text}",sql.con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Sucess!");
            } catch(Exception ex)
            {
                MessageBox.Show("Could not do it due to: " + ex.Message);
            }
        }
    }
}

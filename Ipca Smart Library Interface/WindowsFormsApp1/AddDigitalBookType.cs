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
    public partial class AddDigitalBookType : Form
    {
        public AddDigitalBookType()
        {
            InitializeComponent();
        }

        private void db_type_insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into dbo.DigitalBookType values(@DBTypeId,@TypeDesc)", sql.con);
                command.Parameters.AddWithValue("@DBTypeId", int.Parse(db_id_input.Text));
                command.Parameters.AddWithValue("@TypeDesc", db_type_name_input.Text);
                MessageBox.Show("Successfully inserted!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not do this because: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

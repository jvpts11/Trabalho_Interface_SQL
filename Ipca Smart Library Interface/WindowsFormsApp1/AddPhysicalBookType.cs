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
    public partial class AddPhysicalBookType : Form
    {
        public AddPhysicalBookType()
        {
            InitializeComponent();
        }

        private void physical_book_type_insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into dbo.DigitalBookType values(@TypeId,@TypeDesc)", sql.con);
                command.Parameters.AddWithValue("@TypeId", int.Parse(physical_book_id_input.Text));
                command.Parameters.AddWithValue("@TypeDesc", physical_book_type_name_input.Text);
                MessageBox.Show("Successfully inserted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not do this because: " + ex.Message);
            }
        }
    }
}

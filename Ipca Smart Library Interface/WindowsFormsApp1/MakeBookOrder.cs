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
    public partial class MakeBookOrder : Form
    {
        public MakeBookOrder()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void make_book_order_add_order_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into dbo.BooksBuyOrder values(@BORid,@BooksBought,@Price,@EDTId)",sql.con);
                command.Parameters.AddWithValue("@BORid",int.Parse(order_id_input.Text));
                command.Parameters.AddWithValue("@BooksBought", int.Parse(amount_to_buy_input.Text));
                command.Parameters.AddWithValue("@Price",float.Parse(price_input.Text));
                command.Parameters.AddWithValue("@EDTId",int.Parse(editor_id_input.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Request added with success! \n Soon it will be revised and maybe approved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Action failed due to: " + ex.Message);
            }
            
        }
    }
}

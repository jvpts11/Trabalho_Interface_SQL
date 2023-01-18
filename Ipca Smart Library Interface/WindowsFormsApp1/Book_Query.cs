using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Book_Query : Form
    {
        public Book_Query()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=JOTAPC\AULAS;Initial Catalog=IPCA_SMART_LIBRARY;User ID=sa;Password=123456");
            con.Open();

            SqlCommand command = new SqlCommand("insert into dbo.Book values(@BKId,@BKName,@TypeId,@BORId,null,@EDTId,null,null)", con);
            command.Parameters.Add("@BKId", int.Parse(book_id_input.Text));
            command.Parameters.Add("@BKName", book_name_input.Text);
            command.Parameters.Add("@TypeId", int.Parse(book_type_id_input.Text));
            command.Parameters.Add("@BORId", int.Parse(books_buy_order_id_input.Text));
            command.Parameters.Add("@EDTId", int.Parse(editor_id_input.Text));
            command.ExecuteNonQuery();
            
            con.Close();

            MessageBox.Show("Success!");
        }

        private void update_button_Click(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {

        }
    }
}

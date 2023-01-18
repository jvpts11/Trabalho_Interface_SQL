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

            SqlCommand command = new SqlCommand("insert into dbo.Book values(@BKId,@BKName,@TypeId,@BORId,null,@EDTId,null,null)", sql.con);
            command.Parameters.AddWithValue("@BKId", int.Parse(book_id_input.Text));
            command.Parameters.AddWithValue("@BKName", book_name_input.Text);
            command.Parameters.AddWithValue("@TypeId", int.Parse(book_type_id_input.Text));
            command.Parameters.AddWithValue("@BORId", int.Parse(books_buy_order_id_input.Text));
            command.Parameters.AddWithValue("@EDTId", int.Parse(editor_id_input.Text));
            command.ExecuteNonQuery();
            

            MessageBox.Show("Insert Success!");
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update dbo.Book set BKName=@BKName, TypeId=@TypeId, BORId=@BORId, EDTId=@EDTId where BKId = @BKId", sql.con);
            command.Parameters.AddWithValue("@BKId", int.Parse(book_id_input.Text));
            command.Parameters.AddWithValue("@BKName", book_name_input.Text);
            command.Parameters.AddWithValue("@TypeId", int.Parse(book_type_id_input.Text));
            command.Parameters.AddWithValue("@BORId", int.Parse(books_buy_order_id_input.Text));
            command.Parameters.AddWithValue("@EDTId", int.Parse(editor_id_input.Text));
            command.ExecuteNonQuery();

            MessageBox.Show("Successfully Updated");
        }

        private void search_button_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("exec dbo.showBooks",sql.con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("delete dbo.Book where BKId=@id",sql.con);
            command.Parameters.AddWithValue("@id" ,int.Parse(book_id_input.Text));
            command.ExecuteNonQuery();

            MessageBox.Show("Delete Success!");
        }
    }
}

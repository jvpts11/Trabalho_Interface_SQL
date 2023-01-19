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
    public partial class AddEditor : Form
    {
        public AddEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into dbo.Editor values(@EDTId,@EDTName,@BooksOfEditorAvaliable)",sql.con);
                command.Parameters.AddWithValue("@EDTId",int.Parse(editor_id_input.Text));
                command.Parameters.AddWithValue("@EDTName", editor_name_input.Text);
                command.Parameters.AddWithValue("@BooksOfEditorAvaliable", int.Parse(editor_books_avaliable.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Successfully Added, your insertion will be verified by another system administrator");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not do it due to: "+ex.Message);
            }
        }
    }
}

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
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void register_student_insert_nif_Click(object sender, EventArgs e)
        {
            try 
            {
                SqlCommand command = new SqlCommand("insert into NIF values(@NIF)",sql.con);
                command.Parameters.AddWithValue("@NIF",int.Parse(register_student_nif_input.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Student NIF added into database!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not enter student nif due to: "+ ex.Message);
            }
        }

        private void register_student_insert_student_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into Student values(@STUNumber, @StudentEmail, @STUName,@NIF)", sql.con);
                command.Parameters.AddWithValue("@STUNumber", int.Parse(register_student_number_input.Text));
                command.Parameters.AddWithValue("@StudentEmail", register_student_email_input.Text);
                command.Parameters.AddWithValue("@STUName", register_student_name_input.Text);
                command.Parameters.AddWithValue("@NIF", int.Parse(register_student_nif_input.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Student inserted into database successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add Student due to: " + ex.Message);
            }
        }
    }
}

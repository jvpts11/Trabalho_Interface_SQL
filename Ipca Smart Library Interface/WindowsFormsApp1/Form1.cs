using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version alpha 0.1, built to interact with the smart library database");
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Book_Query().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql.con.Close();
            this.Hide();
            new Login_Screen().Show();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Statistics_Screen().Show();
        }

        private void specialQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SpecialQueryScreen().Show();
        }

        private void bookOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MakeBookOrder().Show();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddEditor().Show();
        }

        private void digitalBookTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddDigitalBookType().Show();
        }

        private void physicalBookTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddPhysicalBookType().Show();
        }

        private void booksAssignedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet Implemented, use the custom query window to do this");
        }

        private void penaltiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet Implemented, use the custom query window to do this");
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegisterStudent().Show();
        }
    }
}

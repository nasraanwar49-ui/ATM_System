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
    public partial class frm_Balance : Form
    {
        public frm_Balance()
        {
            InitializeComponent();
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void chacke_Balance_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            DB.con.Open();

            DB.cmd = new SqlCommand("SELECT Balance FROM Users WHERE ID_Users = @id", DB.con);

            int ID_Users = 1;

            DB.cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID_Users;
            object result = DB.cmd.ExecuteScalar();

            DB.con.Close();

            if (result != null)
            {
                lblBalance.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Account Number or PIN");
            }
        }
      private void btnYes_Click(object sender, EventArgs e)
        {
            frmPIN frm = new frmPIN();
            frm.Show();
            this.Hide();
        }
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

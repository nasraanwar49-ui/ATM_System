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
    public partial class frm_Deposit : Form
    {
        public frm_Deposit()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            int amount;
            if (!int.TryParse(txt_amount.Text, out amount) || amount <= 0)
            {
                Error errorForm = new Error();
                errorForm.Show();
                this.Hide();
                return;
            }

            try
            {
                if (DB.con.State == ConnectionState.Open)
                    DB.con.Close();

                DB.con.Open();

                DB.cmd = new SqlCommand(
                    "UPDATE Users SET Balance = Balance + @amount WHERE ID_Users = @id AND IsActive = 1",
                    DB.con);
                DB.cmd.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
                DB.cmd.Parameters.Add("@id", SqlDbType.Int).Value = seesion.ID_Users;
                int rows = DB.cmd.ExecuteNonQuery();
                DB.con.Close();

                if (rows > 0)
                {
                    success success = new success();
                    success.Show();
                    this.Hide();
                }
                else
                {
                    Error errorForm = new Error();
                    errorForm.Show();
                }
            }
            catch (Exception ex)
            {
                Error errorForm = new Error();
                errorForm.Show();
                MessageBox.Show(ex.Message);
            }

        }   

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

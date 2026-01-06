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
            decimal amount;
            if (!decimal.TryParse(txt_amount.Text, out amount) || amount <= 0)
            {
                Error errorForm = new Error();
                errorForm.Show();
                this.Hide();
                return;
            }
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ATM.mdf;Integrated Security=True;";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string selectQuery = "SELECT Balance FROM Users WHERE IsActive = 1";
                    SqlCommand cmdSelect = new SqlCommand(selectQuery, con);
                    object result = cmdSelect.ExecuteScalar();
                    if (result == null)
                    {
                        Error errorForm = new Error();
                        errorForm.Show();
                        this.Hide();
                        return;
                    }
                    decimal currentBalance = Convert.ToDecimal(result);
                    decimal newBalance = currentBalance + amount;
                    string updateQuery = "UPDATE Users SET Balance=@Balance WHERE IsActive = 1";
                    SqlCommand cmdUpdate = new SqlCommand(updateQuery, con);
                    cmdUpdate.Parameters.AddWithValue("@Balance", newBalance);
                    cmdUpdate.ExecuteNonQuery();

                    success successForm = new success();
                    successForm.Show();
                    this.Close();
                }
            }
            catch
            {
                Error errorForm = new Error();
                errorForm.Show();
                this.Hide();
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
    }
}

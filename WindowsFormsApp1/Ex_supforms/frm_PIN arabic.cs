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
    public partial class frm_PIN_arabic : Form
    {
        public frm_PIN_arabic()
        {
            InitializeComponent();
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            






        }

        private void txtPIN_Click(object sender, EventArgs e)
        {
            DB.con.Open();

            DB.cmd = new SqlCommand(
                "select ID_Users, Balance from Users Where PIN = @pin and IsActive = 1", DB.con);

            DB.cmd.Parameters.AddWithValue("@pin", guna2TextBox2.Text);


            object result = DB.cmd.ExecuteScalar();

            DB.con.Close();

            if (result != null)
            {
                seesion.ID_Users = Convert.ToInt32(result);
                MessageBox.Show("Login Successful");

                frm_main_arabic frm_main_ = new frm_main_arabic();
                frm_main_.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong PIN");
            }


        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

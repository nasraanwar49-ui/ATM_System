using Microsoft.VisualBasic.ApplicationServices;
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
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class frmPIN : Form
    {
        public frmPIN()
        {
            InitializeComponent();
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel2_Click(object sender, EventArgs e)
        {

        }



        private void btnPIN_Click(object sender, EventArgs e)
        {
            try
            {
                DB.con.Open();

                DB.cmd = new SqlCommand(
                    "select ID_Users, Balance from Users Where PIN = @pin and IsActive = 1", DB.con);

                DB.cmd.Parameters.AddWithValue("@pin", txtPIN.Text);
                //DB.cmd.Parameters.AddWithValue("@p", txtPIN.Text);

                object result = DB.cmd.ExecuteScalar();

                DB.con.Close();

                if (result != null)
                {
                    seesion.ID_Users = Convert.ToInt32(result);
                    MessageBox.Show("Login Successful");

                    frm_main m = new frm_main();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong PIN");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Error errorForm = new Error();
                errorForm.Show();
            }




        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}





        




      






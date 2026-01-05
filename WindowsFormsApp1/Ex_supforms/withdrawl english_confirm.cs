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
    public partial class frmwithdrwal_english_confirm : Form
    {
        public frmwithdrwal_english_confirm(string Amount,string Commission)
        {
            InitializeComponent();
            string total = Convert.ToString(Convert.ToInt32(Amount) + Convert.ToInt32(Commission));
            txtAmount.Text = Amount + ("YR");
            txtcommission.Text = Commission + ("YR");
            txtTotalAmount.Text = total ;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmwithdrwal_english_confirm_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // TEST IF THERE IS NUMBER OR NO 
            if (string.IsNullOrWhiteSpace(txtTotalAmount.Text))
            {
                MessageBox.Show("enter Number first ");
                return;
            }

            int amount = int.Parse(txtTotalAmount.Text);
            // TEST IF THE NUMBER BIGER THEN 0
            if (amount <= 0)
            {
                Error errorEN = new Error();
                errorEN.Show();
                this.Hide();
            }
            // IN ORDER TO ACCEPT MULTIPLES OF A THOUSAND 
            if (amount % 1000 != 0)
            {
                Error errorEN = new Error();
                errorEN.Show();
                this.Hide();
            }

            // THE QUERY
            DB.con.Open();

            
            SqlCommand cmd = new SqlCommand(
                @"UPDATE [USERS]
          SET Balance = Balance - @amount
          WHERE IsActive = 1 AND Balance >= @amount",
                DB.con);

            cmd.Parameters.AddWithValue("@amount", amount);

            int rows = cmd.ExecuteNonQuery();

            DB.con.Close();

            // IF NOT ENOUGH CASH
            if (rows == 0)
            {
                MessageBox.Show("NOT enough cash");
                Error errorEN = new Error();
                errorEN.Show();
                this.Hide();
            }
            // IF SUCCESS 
            else
            {
                success successEN = new success();
                successEN.Show();
                this.Close();
            }
        }

        private void txtTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanke you for using our ATM");
            frm_Language frm_L = new frm_Language();
            frm_L.Show();
            this.Close();
        }
    }
}

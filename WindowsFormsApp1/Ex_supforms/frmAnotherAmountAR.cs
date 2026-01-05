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
    public partial class frmAnotherAmountAR : Form
    {
        public frmAnotherAmountAR()
        {
            InitializeComponent();
        }
        string Amount;
       
        void towithdraw(string Commission)
        {
            int Amounttxt = 0;
            Amounttxt = Convert.ToInt32(txtAnoterAmountAR.Text);

            if (Amounttxt > 30000 || Amounttxt <= 0)
            {


                MessageBox.Show(" لايمكنك ذالك");
            }
            else if (Amounttxt < 1000 || Amounttxt % 1000 != 0)
            {
                MessageBox.Show("المبلغ يجب أن يكون 1000 أو أحد مضاعفاته");

            }
            else
            {

                Amount = Convert.ToString(Amounttxt);
                frmwithdrwal_arabic_confirm frmwithdrwal_ar_confirm = new frmwithdrwal_arabic_confirm(Amount, Commission);
                frmwithdrwal_ar_confirm.Show();
                this.Hide();
            }

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

        private void btnEnter_Click(object sender, EventArgs e)
        {

            towithdraw("0");


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

        private void txtAnoterAmountAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtAnoterAmountAR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

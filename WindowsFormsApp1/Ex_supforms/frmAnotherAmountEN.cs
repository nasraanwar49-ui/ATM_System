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
    public partial class frmAnotherAmountEN : Form
    {
        public frmAnotherAmountEN()
        {
            InitializeComponent();
        }
            string Amount;

            void towithdraw(string Commission)
            {
                int Amounttxt = 0;
                Amounttxt = Convert.ToInt32(txtAnotherAmountER.Text);

                if (Amounttxt > 30000 || Amounttxt <= 0)
                {


                    MessageBox.Show("Cant DO it baby");
                }
                else if (Amounttxt < 1000 || Amounttxt % 1000 != 0)
                {
                    MessageBox.Show("المبلغ يجب أن يكون 1000 أو أحد مضاعفاته");

                }
                else
                {

                    Amount = Convert.ToString(Amounttxt);
                    frmwithdrwal_english_confirm frmwithdrwal_en_confirm = new frmwithdrwal_english_confirm(Amount, Commission);
                    frmwithdrwal_en_confirm.Show();
                    this.Hide();
                }
            }
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtAnotherAmountER_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnterER_Click(object sender, EventArgs e)
        {
            towithdraw("0");
        }

        private void txtAnotherAmountER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

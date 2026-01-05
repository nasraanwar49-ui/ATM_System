using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmwithdrwal_arabic : Form
    {
        public frmwithdrwal_arabic()
        {
            InitializeComponent();
        }
        void towithdrwal(string Amount, string Commission)
        {


            frmwithdrwal_arabic_confirm frmwithdrwal_ar_confirm = new frmwithdrwal_arabic_confirm(Amount, Commission);
            frmwithdrwal_ar_confirm.Show();
            this.Hide();
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frmwithdrwal_arabic_Load(object sender, EventArgs e)
        {

        }

        private void btn2000_Click(object sender, EventArgs e)
        {
            towithdrwal(btn2000.Text, "0");
        }

        private void btn5000_Click(object sender, EventArgs e)
        {
            towithdrwal(btn5000.Text, "0");
        }

        private void btn10000_Click(object sender, EventArgs e)
        {
            towithdrwal(btn10000.Text, "0");
        }

        private void btn15000_Click(object sender, EventArgs e)
        {
            towithdrwal(btn15000.Text, "0");
        }

        private void btn20000_Click(object sender, EventArgs e)
        {
            towithdrwal(btn20000.Text, "0");
        }

        private void btn25000_Click(object sender, EventArgs e)
        {
            towithdrwal(btn25000.Text, "0");
        }

        private void btn30000_Click(object sender, EventArgs e)
        {
            towithdrwal(btn30000.Text, "0");
        }

        private void btnAnotherAmount_Click(object sender, EventArgs e)
        {
            frmAnotherAmountAR anotherAR = new frmAnotherAmountAR();
            anotherAR.Show();
            this.Hide();
         
        }
    }
}

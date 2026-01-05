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
    public partial class frmwithdrwal_english : Form
    {
        public frmwithdrwal_english()
        {
            InitializeComponent();
        }
        void towithdrwal(string Amount, string Commission)
        {
            
            
            frmwithdrwal_english_confirm frmwithdrwal_EN_confirm = new frmwithdrwal_english_confirm(Amount, Commission);
            frmwithdrwal_EN_confirm.Show();
            this.Hide();
        }
        
         
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmwithdrwal_english_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btn10000_Click(object sender, EventArgs e)
        {
            towithdrwal(btn10000.Text, "0");
        }

        private void btn2000_Click(object sender, EventArgs e)
        {
            towithdrwal(btn2000.Text, "0");
        }

        private void btn5000_Click(object sender, EventArgs e)
        {
            towithdrwal(btn5000.Text, "0");
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
            frmAnotherAmountEN anotherEN = new frmAnotherAmountEN();
            anotherEN.Show();
            this.Hide();
        }
    }
}

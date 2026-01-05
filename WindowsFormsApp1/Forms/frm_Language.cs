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
    public partial class frm_Language : Form
    {
        public frm_Language()
        {
            InitializeComponent();
        }

        

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnlanguageAR_Click(object sender, EventArgs e)
        {
            frm_PIN_arabic frm_PIN_ = new frm_PIN_arabic();
            frm_PIN_.Show();
            this.Hide();
            //frm_main_arabic frm_main_ = new frm_main_arabic();
            //frm_main_.Show();
            //this.Hide();
        }

        private void btnlanguageEN_Click(object sender, EventArgs e)
        {
            frmPIN frm = new frmPIN();
            frm.Show();
            this.Hide();
            //frm_main frm_Main = new frm_main();
            //frm_Main.Show();
            //this.Hide();

        }
    }
}

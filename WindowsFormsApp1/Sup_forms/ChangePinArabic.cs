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
    public partial class frmChangePinArabic : Form
    {
        public frmChangePinArabic()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnaccebte_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txtOldPass.Text) ||
                string.IsNullOrWhiteSpace(txtNewPass.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPass.Text))
            {
                MessageBox.Show("املأ جميع الحقول");
                return;
            }

            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("كلمة السر الجديدة غير متطابقة");
                return;
            }

            DB.con.Open();

            
            SqlCommand checkCmd = new SqlCommand(
                "SELECT COUNT(*) FROM [USERS] WHERE IsActive=1 AND PIN=@old",
                DB.con);

            checkCmd.Parameters.AddWithValue("@old", txtOldPass.Text);

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count == 0)
            {
                MessageBox.Show("كلمة السر القديمة خطأ");
                DB.con.Close();
                return;
            }

           
            SqlCommand updateCmd = new SqlCommand(
                "UPDATE [USERS] SET PIN=@new WHERE IsActive=1",
                DB.con);

            updateCmd.Parameters.AddWithValue("@new", txtNewPass.Text);

            updateCmd.ExecuteNonQuery();

            DB.con.Close();

            MessageBox.Show("تم تغيير كلمة السر بنجاح");
        }
    }
}

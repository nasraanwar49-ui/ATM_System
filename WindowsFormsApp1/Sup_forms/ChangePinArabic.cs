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
using Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    public partial class frmChangePinArabic : Form
    {

        Guna2TextBox selectedBox;

        public frmChangePinArabic()
        {
            InitializeComponent();


            selectedBox = txtOldPass;


            txtOldPass.Enter += (s, e) => selectedBox = txtOldPass;
            txtNewPass.Enter += (s, e) => selectedBox = txtNewPass;
            txtConfirmPass.Enter += (s, e) => selectedBox = txtConfirmPass;
        }


        private void AddNumber(string number)
        {

            if (selectedBox != null && selectedBox.Text.Length < 4)
            {
                selectedBox.Text += number;
            }
        }

        private void DeleteLastNumber()
        {

            if (selectedBox != null && selectedBox.Text.Length > 0)
            {
                selectedBox.Text = selectedBox.Text.Substring(0, selectedBox.Text.Length - 1);
            }
        }


        private bool CheckOldPassCorrect()
        {

            if (DB.con.State == ConnectionState.Closed) DB.con.Open();

            string query = "SELECT COUNT(*) FROM [USERS] WHERE IsActive=1 AND PIN=@old";
            SqlCommand checkCmd = new SqlCommand(query, DB.con);


            checkCmd.Parameters.AddWithValue("@old", txtOldPass.Text);

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            DB.con.Close();
            return count > 0;
        }


        private void SaveNewPassToDB()
        {
            try
            {
                if (DB.con.State == ConnectionState.Closed) DB.con.Open();

                string query = "UPDATE [USERS] SET PIN=@new WHERE IsActive=1";
                SqlCommand updateCmd = new SqlCommand(query, DB.con);


                updateCmd.Parameters.AddWithValue("@new", txtNewPass.Text);

                updateCmd.ExecuteNonQuery();
                DB.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Error errorForm = new Error();
                errorForm.Show();
            }

        }


        private void btnaccebte_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtOldPass.Text) ||
                string.IsNullOrWhiteSpace(txtNewPass.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPass.Text))
            {
                MessageBox.Show("الرجاء ملء جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("كلمة السر الجديدة غير متطابقة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPass.Clear();
                txtConfirmPass.Clear();
                return;
            }

            try
            {

                if (!CheckOldPassCorrect())
                {
                    MessageBox.Show("كلمة السر القديمة خطأ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPass.Clear();
                    txtOldPass.Focus();
                    return;
                }


                SaveNewPassToDB();
                
                نجاح success = new نجاح();
                success.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
                if (DB.con.State == ConnectionState.Open) DB.con.Close();
            }
        }


        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

            txtOldPass.Clear();
            txtNewPass.Clear();
            txtConfirmPass.Clear();
            txtOldPass.Focus();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }


        private void guna2CircleButton1_Click(object sender, EventArgs e) => AddNumber("1");
        private void guna2CircleButton2_Click(object sender, EventArgs e) => AddNumber("2");
        private void guna2CircleButton3_Click(object sender, EventArgs e) => AddNumber("3");
        private void guna2CircleButton4_Click(object sender, EventArgs e) => AddNumber("4");
        private void guna2CircleButton5_Click(object sender, EventArgs e) => AddNumber("5");
        private void guna2CircleButton6_Click(object sender, EventArgs e) => AddNumber("6");
        private void guna2CircleButton7_Click(object sender, EventArgs e) => AddNumber("7");
        private void guna2CircleButton8_Click(object sender, EventArgs e) => AddNumber("8");
        private void guna2CircleButton9_Click(object sender, EventArgs e) => AddNumber("9");
        private void guna2CircleButton11_Click(object sender, EventArgs e) => AddNumber("0");

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            DeleteLastNumber();
        }


        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e) { }
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e) { }
        private void guna2PictureBox1_Click(object sender, EventArgs e) { }
        private void gunaGradientPanel1_Click(object sender, EventArgs e) { }
        private void guna2HtmlLabel2_Click(object sender, EventArgs e) { }
        private void guna2HtmlLabel3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void txtOldPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
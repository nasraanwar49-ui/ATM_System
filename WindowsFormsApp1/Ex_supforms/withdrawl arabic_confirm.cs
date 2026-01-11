using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmwithdrwal_arabic_confirm : Form
    {
        public frmwithdrwal_arabic_confirm(string Amount,string Commission)
        {
            InitializeComponent();
            string total = Convert.ToString(Convert.ToInt32(Amount) + Convert.ToInt32(Commission));
            lblAmountResult.Text = Amount + ("YR");
            lblCommissionResultAR.Text = Commission+("YR");
            lblTotalAmountResult.Text = total ;

           

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmwithdrwal_arabic_confirm_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTotalAmountAR_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // TEST IF THERE IS NUMBER OR NO 
            if (string.IsNullOrWhiteSpace(lblTotalAmountResult.Text))
            {
                MessageBox.Show("الرجاء ادخال المبلغ اولا");
                return;
            }

            int amount = int.Parse(lblTotalAmountResult.Text);
            // TEST IF THE NUMBER BIGER THEN 0
            if (amount <= 0)
            {
                خطا error = new خطا();
                error.Show();
                this.Hide();
                return;
            }
            // IN ORDER TO ACCEPT MULTIPLES OF A THOUSAND 
            if (amount % 1000 != 0)
            {
                خطا error = new خطا();
                error.Show();
                this.Hide();
                return;
            }
            // THE QUERY
            try
            {
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
                    MessageBox.Show("لا يوجد لذيك مال كافي");
                    خطا error = new خطا();
                    error.Show();
                    this.Hide();
                }
                // IF SUCCESS 
                else
                {
                    نجاح success = new نجاح();
                    success.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Error errorForm = new Error();
                errorForm.Show();
            }


        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("شكرا لاستخدامك خدمة الصراف الالي الخاصة بنا");
            frm_Language frm_L = new frm_Language();
            frm_L.Show();
            this.Close();
        }
    }
    }


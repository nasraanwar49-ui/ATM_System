namespace WindowsFormsApp1
{ 
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.label4);
            this.gunaGradientPanel1.Controls.Add(this.guna2PictureBox2);
            this.gunaGradientPanel1.Controls.Add(this.btnNo);
            this.gunaGradientPanel1.Controls.Add(this.btnYes);
            this.gunaGradientPanel1.Controls.Add(this.label3);
            this.gunaGradientPanel1.Controls.Add(this.lblBalance);
            this.gunaGradientPanel1.Controls.Add(this.label1);
            this.gunaGradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(48)))), ((int)(((byte)(160)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.DarkViolet;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(48)))), ((int)(((byte)(160)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(128)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(915, 526);
            this.gunaGradientPanel1.TabIndex = 0;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            this.gunaGradientPanel1.Click += new System.EventHandler(this.gunaGradientPanel1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(1, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "ATM System";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(801, 0);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(110, 90);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 6;
            this.guna2PictureBox2.TabStop = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(111, 309);
            this.btnNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(189, 43);
            this.btnNo.TabIndex = 4;
            this.btnNo.Text = "لا";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(584, 309);
            this.btnYes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(209, 43);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "نعم";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(63, 165);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(464, 538);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(252, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 53);
            this.label3.TabIndex = 2;
            this.label3.Text = "هل تريد أي خدمات أخرى";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(368, 129);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(179, 53);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "5678.89";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "الرصيد المتاح ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 526);
            this.Controls.Add(this.gunaGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label4;
    }
}


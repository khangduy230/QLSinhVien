namespace QLSinhVien
{
    partial class frmDangNhap
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
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            btnDangNhap = new Button();
            label2 = new Label();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
<<<<<<< Updated upstream
            btnDangNhap.Location = new Point(354, 278);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(75, 23);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
=======
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTaiKhoan);
            panel1.Location = new Point(159, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 265);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(121, 29);
            label3.Name = "label3";
            label3.Size = new Size(125, 30);
            label3.TabIndex = 4;
            label3.Text = "Đăng Nhập";
            label3.Click += label3_Click;
>>>>>>> Stashed changes
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< Updated upstream
            label1.Location = new Point(252, 145);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
=======
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 140);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 4;
>>>>>>> Stashed changes
            label1.Text = "Tài khoản:";
            label1.Click += label1_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.LightSkyBlue;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(121, 192);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(130, 40);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< Updated upstream
            label2.Location = new Point(252, 218);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(320, 142);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(153, 23);
            txtTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(320, 215);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(153, 23);
            txtMatKhau.TabIndex = 4;
=======
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 82);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(121, 138);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.PlaceholderText = "Nhập mật khẩu của bạn";
            txtMatKhau.Size = new Size(208, 34);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
>>>>>>> Stashed changes
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoan.Location = new Point(121, 80);
            txtTaiKhoan.Multiline = true;
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.PlaceholderText = "Nhập tài khoản của bạn";
            txtTaiKhoan.Size = new Size(208, 33);
            txtTaiKhoan.TabIndex = 1;
            txtTaiKhoan.TextChanged += txtTaiKhoan_TextChanged;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< Updated upstream
            ClientSize = new Size(800, 450);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDangNhap);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
=======
            BackgroundImage = Properties.Resources._11629730640165;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(670, 404);
            Controls.Add(panel1);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            Load += frmDangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
>>>>>>> Stashed changes
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDangNhap;
        private TextBox txtMatKhau;
        private Label label1;
        private Label label2;
        private TextBox txtTaiKhoan;
        private Label label3;
    }
}
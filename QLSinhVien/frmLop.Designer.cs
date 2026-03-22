namespace QLSinhVien
{
    partial class frmLop
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
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label1 = new Label();
            label2 = new Label();
            txtMaLop = new TextBox();
            txtTenLop = new TextBox();
            dgvLop = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 255, 128);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Location = new Point(149, 299);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 32);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 128, 128);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ImageAlign = ContentAlignment.BottomLeft;
            btnXoa.Location = new Point(265, 299);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 32);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(128, 255, 255);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Location = new Point(35, 299);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 32);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 15;
            label1.Text = "Mã lớp:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 98);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 16;
            label2.Text = "Tên lớp:";
            // 
            // txtMaLop
            // 
            txtMaLop.BorderStyle = BorderStyle.FixedSingle;
            txtMaLop.Location = new Point(114, 37);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(131, 23);
            txtMaLop.TabIndex = 17;
            // 
            // txtTenLop
            // 
            txtTenLop.BorderStyle = BorderStyle.FixedSingle;
            txtTenLop.Location = new Point(114, 95);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(131, 23);
            txtTenLop.TabIndex = 18;
            // 
            // dgvLop
            // 
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLop.Location = new Point(27, 94);
            dgvLop.Name = "dgvLop";
            dgvLop.Size = new Size(313, 198);
            dgvLop.TabIndex = 19;
            dgvLop.CellClick += dgvLop_CellClick;
            dgvLop.CellContentClick += dgvLop_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaLop);
            panel1.Controls.Add(txtTenLop);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(35, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 163);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(txtTimKiem);
            panel2.Controls.Add(dgvLop);
            panel2.Location = new Point(387, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 318);
            panel2.TabIndex = 21;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(192, 192, 255);
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Location = new Point(255, 34);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(85, 26);
            btnTimKiem.TabIndex = 21;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Location = new Point(30, 35);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm theo mã lớp, tên lớp";
            txtTimKiem.Size = new Size(204, 23);
            txtTimKiem.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(625, 46);
            button1.Name = "button1";
            button1.Size = new Size(131, 30);
            button1.TabIndex = 22;
            button1.Text = "Quản lý Sinh Viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmLop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Name = "frmLop";
            Text = "frmLop";
            Load += frmLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label1;
        private Label label2;
        private TextBox txtMaLop;
        private TextBox txtTenLop;
        private DataGridView dgvLop;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button button1;
    }
}
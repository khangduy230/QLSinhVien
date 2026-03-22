namespace QLSinhVien
{
    partial class frmSinhVien
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
            dgvSinhVien = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpNgaySinh = new DateTimePicker();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtMaLop = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnTimKiem = new Button();
<<<<<<< Updated upstream
=======
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtTimKiem = new TextBox();
            button1 = new Button();
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< Updated upstream
            dgvSinhVien.Location = new Point(387, 85);
=======
            dgvSinhVien.Location = new Point(21, 72);
>>>>>>> Stashed changes
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.Size = new Size(314, 259);
            dgvSinhVien.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 85);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã SV:";
            label1.Click += txtMaSV_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 131);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Họ Tên:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 177);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 3;
            label3.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 224);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 4;
            label4.Text = "Mã Lớp";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(122, 171);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 23);
            dtpNgaySinh.TabIndex = 5;
            // 
            // txtMaSV
            // 
<<<<<<< Updated upstream
            txtMaSV.Location = new Point(122, 77);
=======
            txtMaSV.BorderStyle = BorderStyle.FixedSingle;
            txtMaSV.Location = new Point(97, 26);
>>>>>>> Stashed changes
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(200, 23);
            txtMaSV.TabIndex = 6;
            // 
            // txtHoTen
            // 
<<<<<<< Updated upstream
            txtHoTen.Location = new Point(122, 123);
=======
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Location = new Point(97, 72);
>>>>>>> Stashed changes
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(200, 23);
            txtHoTen.TabIndex = 7;
            // 
            // txtMaLop
            // 
<<<<<<< Updated upstream
            txtMaLop.Location = new Point(122, 221);
=======
            txtMaLop.BorderStyle = BorderStyle.FixedSingle;
            txtMaLop.Location = new Point(97, 162);
>>>>>>> Stashed changes
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(200, 23);
            txtMaLop.TabIndex = 8;
            // 
            // btnThem
            // 
<<<<<<< Updated upstream
            btnThem.Location = new Point(86, 281);
=======
            btnThem.BackColor = Color.FromArgb(128, 255, 255);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Location = new Point(43, 332);
>>>>>>> Stashed changes
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnXoa
            // 
<<<<<<< Updated upstream
            btnXoa.Location = new Point(86, 321);
=======
            btnXoa.BackColor = Color.FromArgb(255, 128, 128);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ImageAlign = ContentAlignment.BottomLeft;
            btnXoa.Location = new Point(273, 332);
>>>>>>> Stashed changes
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
<<<<<<< Updated upstream
            btnSua.Location = new Point(207, 281);
=======
            btnSua.BackColor = Color.FromArgb(255, 255, 128);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Location = new Point(157, 332);
>>>>>>> Stashed changes
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
<<<<<<< Updated upstream
            btnTimKiem.Location = new Point(207, 321);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
=======
            btnTimKiem.BackColor = Color.FromArgb(192, 192, 255);
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Location = new Point(250, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(85, 26);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaLop);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(43, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 219);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSteelBlue;
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(dgvSinhVien);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Location = new Point(400, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(356, 354);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sinh viên";
            groupBox2.Enter += groupBox2_Enter;
>>>>>>> Stashed changes
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Location = new Point(21, 29);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm theo Tên, MSSV,...";
            txtTimKiem.Size = new Size(205, 23);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(625, 37);
            button1.Name = "button1";
            button1.Size = new Size(131, 30);
            button1.TabIndex = 15;
            button1.Text = "Quản lý Lớp Học";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< Updated upstream
            ClientSize = new Size(800, 450);
            Controls.Add(btnTimKiem);
=======
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox2);
>>>>>>> Stashed changes
            Controls.Add(btnSua);
            Controls.Add(groupBox1);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
<<<<<<< Updated upstream
            Controls.Add(txtMaLop);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSinhVien);
=======
            DoubleBuffered = true;
>>>>>>> Stashed changes
            Name = "frmSinhVien";
            Text = "frmSinhVien";
            Load += frmSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
<<<<<<< Updated upstream
=======
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
>>>>>>> Stashed changes
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSinhVien;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtMaLop;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnTimKiem;
<<<<<<< Updated upstream
=======
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtTimKiem;
        private Button button1;
>>>>>>> Stashed changes
    }
}
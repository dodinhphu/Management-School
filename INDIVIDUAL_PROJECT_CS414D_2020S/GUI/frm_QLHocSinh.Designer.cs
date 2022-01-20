
namespace INDIVIDUAL_PROJECT_CS414D_2020S.GUI
{
    partial class frm_QLHocSinh
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
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tenAnhHS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_themAnhGV = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoaHS = new System.Windows.Forms.Button();
            this.btn_SửaHS = new System.Windows.Forms.Button();
            this.btn_themHS = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.picture_HS = new System.Windows.Forms.PictureBox();
            this.txt_diachiHS = new System.Windows.Forms.TextBox();
            this.txt_TenHS = new System.Windows.Forms.TextBox();
            this.cb_GTHS = new System.Windows.Forms.ComboBox();
            this.txt_MaHS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_NgaySinhHS = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_DSHS = new System.Windows.Forms.DataGridView();
            this.txt_timKiemHS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_MaLop = new System.Windows.Forms.ComboBox();
            this.cb_KhoiLop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_HS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSHS)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(808, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "Ảnh";
            // 
            // txt_tenAnhHS
            // 
            this.txt_tenAnhHS.Location = new System.Drawing.Point(178, 416);
            this.txt_tenAnhHS.Name = "txt_tenAnhHS";
            this.txt_tenAnhHS.ReadOnly = true;
            this.txt_tenAnhHS.Size = new System.Drawing.Size(256, 26);
            this.txt_tenAnhHS.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Tên Ảnh";
            // 
            // btn_themAnhGV
            // 
            this.btn_themAnhGV.Location = new System.Drawing.Point(494, 92);
            this.btn_themAnhGV.Name = "btn_themAnhGV";
            this.btn_themAnhGV.Size = new System.Drawing.Size(92, 30);
            this.btn_themAnhGV.TabIndex = 38;
            this.btn_themAnhGV.Text = "Chọn Ảnh";
            this.btn_themAnhGV.UseVisualStyleBackColor = true;
            this.btn_themAnhGV.Click += new System.EventHandler(this.btn_themAnhGV_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(576, 496);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(108, 40);
            this.btn_thoat.TabIndex = 22;
            this.btn_thoat.Text = "Đóng";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoaHS
            // 
            this.btn_xoaHS.Location = new System.Drawing.Point(392, 496);
            this.btn_xoaHS.Name = "btn_xoaHS";
            this.btn_xoaHS.Size = new System.Drawing.Size(108, 40);
            this.btn_xoaHS.TabIndex = 11;
            this.btn_xoaHS.Text = "Xóa";
            this.btn_xoaHS.UseVisualStyleBackColor = true;
            this.btn_xoaHS.Click += new System.EventHandler(this.btn_xoaHS_Click);
            // 
            // btn_SửaHS
            // 
            this.btn_SửaHS.Location = new System.Drawing.Point(200, 496);
            this.btn_SửaHS.Name = "btn_SửaHS";
            this.btn_SửaHS.Size = new System.Drawing.Size(108, 40);
            this.btn_SửaHS.TabIndex = 9;
            this.btn_SửaHS.Text = "Sửa";
            this.btn_SửaHS.UseVisualStyleBackColor = true;
            this.btn_SửaHS.Click += new System.EventHandler(this.btn_SửaHS_Click);
            // 
            // btn_themHS
            // 
            this.btn_themHS.Location = new System.Drawing.Point(26, 496);
            this.btn_themHS.Name = "btn_themHS";
            this.btn_themHS.Size = new System.Drawing.Size(108, 40);
            this.btn_themHS.TabIndex = 8;
            this.btn_themHS.Text = "Thêm";
            this.btn_themHS.UseVisualStyleBackColor = true;
            this.btn_themHS.Click += new System.EventHandler(this.btn_themHS_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(386, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 31);
            this.label6.TabIndex = 33;
            this.label6.Text = "Quản Lý Học Sinh";
            // 
            // picture_HS
            // 
            this.picture_HS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_HS.Location = new System.Drawing.Point(592, 92);
            this.picture_HS.Name = "picture_HS";
            this.picture_HS.Size = new System.Drawing.Size(417, 350);
            this.picture_HS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_HS.TabIndex = 32;
            this.picture_HS.TabStop = false;
            // 
            // txt_diachiHS
            // 
            this.txt_diachiHS.Location = new System.Drawing.Point(178, 266);
            this.txt_diachiHS.Name = "txt_diachiHS";
            this.txt_diachiHS.Size = new System.Drawing.Size(256, 26);
            this.txt_diachiHS.TabIndex = 5;
            // 
            // txt_TenHS
            // 
            this.txt_TenHS.Location = new System.Drawing.Point(177, 134);
            this.txt_TenHS.Name = "txt_TenHS";
            this.txt_TenHS.Size = new System.Drawing.Size(256, 26);
            this.txt_TenHS.TabIndex = 2;
            // 
            // cb_GTHS
            // 
            this.cb_GTHS.FormattingEnabled = true;
            this.cb_GTHS.ItemHeight = 19;
            this.cb_GTHS.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_GTHS.Location = new System.Drawing.Point(177, 177);
            this.cb_GTHS.Name = "cb_GTHS";
            this.cb_GTHS.Size = new System.Drawing.Size(256, 27);
            this.cb_GTHS.TabIndex = 26;
            // 
            // txt_MaHS
            // 
            this.txt_MaHS.Location = new System.Drawing.Point(177, 92);
            this.txt_MaHS.Name = "txt_MaHS";
            this.txt_MaHS.Size = new System.Drawing.Size(256, 26);
            this.txt_MaHS.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã Học Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Họ Và Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Ngày Sinh";
            // 
            // dt_NgaySinhHS
            // 
            this.dt_NgaySinhHS.CustomFormat = "dd/MM/yyyy";
            this.dt_NgaySinhHS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgaySinhHS.Location = new System.Drawing.Point(177, 222);
            this.dt_NgaySinhHS.Name = "dt_NgaySinhHS";
            this.dt_NgaySinhHS.Size = new System.Drawing.Size(256, 26);
            this.dt_NgaySinhHS.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "Mã Lớp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 45;
            this.label10.Text = "Khối Lớp";
            // 
            // dataGridView_DSHS
            // 
            this.dataGridView_DSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSHS.Location = new System.Drawing.Point(12, 604);
            this.dataGridView_DSHS.Name = "dataGridView_DSHS";
            this.dataGridView_DSHS.Size = new System.Drawing.Size(997, 233);
            this.dataGridView_DSHS.TabIndex = 48;
            this.dataGridView_DSHS.Click += new System.EventHandler(this.dataGridView_DSHS_Click);
            // 
            // txt_timKiemHS
            // 
            this.txt_timKiemHS.Location = new System.Drawing.Point(753, 572);
            this.txt_timKiemHS.Name = "txt_timKiemHS";
            this.txt_timKiemHS.Size = new System.Drawing.Size(256, 26);
            this.txt_timKiemHS.TabIndex = 50;
            this.txt_timKiemHS.TextChanged += new System.EventHandler(this.txt_timKiemHS_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(576, 575);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 19);
            this.label11.TabIndex = 49;
            this.label11.Text = "Tìm Kiếm (MãHS,TênHS)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cb_MaLop
            // 
            this.cb_MaLop.FormattingEnabled = true;
            this.cb_MaLop.ItemHeight = 19;
            this.cb_MaLop.Location = new System.Drawing.Point(177, 316);
            this.cb_MaLop.Name = "cb_MaLop";
            this.cb_MaLop.Size = new System.Drawing.Size(256, 27);
            this.cb_MaLop.TabIndex = 51;
            // 
            // cb_KhoiLop
            // 
            this.cb_KhoiLop.FormattingEnabled = true;
            this.cb_KhoiLop.ItemHeight = 19;
            this.cb_KhoiLop.Location = new System.Drawing.Point(177, 366);
            this.cb_KhoiLop.Name = "cb_KhoiLop";
            this.cb_KhoiLop.Size = new System.Drawing.Size(256, 27);
            this.cb_KhoiLop.TabIndex = 52;
            // 
            // frm_QLHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 849);
            this.Controls.Add(this.cb_KhoiLop);
            this.Controls.Add(this.cb_MaLop);
            this.Controls.Add(this.txt_timKiemHS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView_DSHS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dt_NgaySinhHS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_tenAnhHS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_themAnhGV);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoaHS);
            this.Controls.Add(this.btn_SửaHS);
            this.Controls.Add(this.btn_themHS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picture_HS);
            this.Controls.Add(this.txt_diachiHS);
            this.Controls.Add(this.txt_TenHS);
            this.Controls.Add(this.cb_GTHS);
            this.Controls.Add(this.txt_MaHS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Học Sinh";
            this.Load += new System.EventHandler(this.frm_HocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_HS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_tenAnhHS;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btn_themAnhGV;
        public System.Windows.Forms.Button btn_thoat;
        public System.Windows.Forms.Button btn_xoaHS;
        public System.Windows.Forms.Button btn_SửaHS;
        public System.Windows.Forms.Button btn_themHS;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox picture_HS;
        public System.Windows.Forms.TextBox txt_diachiHS;
        public System.Windows.Forms.TextBox txt_TenHS;
        public System.Windows.Forms.ComboBox cb_GTHS;
        public System.Windows.Forms.TextBox txt_MaHS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dt_NgaySinhHS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DataGridView dataGridView_DSHS;
        public System.Windows.Forms.TextBox txt_timKiemHS;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cb_MaLop;
        public System.Windows.Forms.ComboBox cb_KhoiLop;
    }
}
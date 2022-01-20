
namespace INDIVIDUAL_PROJECT_CS414D_2020S.GUI
{
    partial class frm_QLGiaoVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaGV = new System.Windows.Forms.TextBox();
            this.cb_GTGV = new System.Windows.Forms.ComboBox();
            this.txt_TenGV = new System.Windows.Forms.TextBox();
            this.txt_diachiGV = new System.Windows.Forms.TextBox();
            this.dataGridView_DSGV = new System.Windows.Forms.DataGridView();
            this.txt_TimKiemGV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picture_GV = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_themGV = new System.Windows.Forms.Button();
            this.btn_SửaGV = new System.Windows.Forms.Button();
            this.btn_xoaGV = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_themAnhGV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TenAnh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Giáo Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // txt_MaGV
            // 
            this.txt_MaGV.Location = new System.Drawing.Point(243, 90);
            this.txt_MaGV.Name = "txt_MaGV";
            this.txt_MaGV.Size = new System.Drawing.Size(256, 26);
            this.txt_MaGV.TabIndex = 1;
            // 
            // cb_GTGV
            // 
            this.cb_GTGV.FormattingEnabled = true;
            this.cb_GTGV.ItemHeight = 19;
            this.cb_GTGV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_GTGV.Location = new System.Drawing.Point(243, 211);
            this.cb_GTGV.Name = "cb_GTGV";
            this.cb_GTGV.Size = new System.Drawing.Size(256, 27);
            this.cb_GTGV.TabIndex = 5;
            // 
            // txt_TenGV
            // 
            this.txt_TenGV.Location = new System.Drawing.Point(243, 152);
            this.txt_TenGV.Name = "txt_TenGV";
            this.txt_TenGV.Size = new System.Drawing.Size(256, 26);
            this.txt_TenGV.TabIndex = 2;
            // 
            // txt_diachiGV
            // 
            this.txt_diachiGV.Location = new System.Drawing.Point(243, 274);
            this.txt_diachiGV.Name = "txt_diachiGV";
            this.txt_diachiGV.Size = new System.Drawing.Size(256, 26);
            this.txt_diachiGV.TabIndex = 4;
            // 
            // dataGridView_DSGV
            // 
            this.dataGridView_DSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSGV.Location = new System.Drawing.Point(12, 508);
            this.dataGridView_DSGV.Name = "dataGridView_DSGV";
            this.dataGridView_DSGV.Size = new System.Drawing.Size(959, 220);
            this.dataGridView_DSGV.TabIndex = 8;
            this.dataGridView_DSGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DSGV_CellContentClick);
            this.dataGridView_DSGV.Click += new System.EventHandler(this.dataGridView_DSGV_Click);
            // 
            // txt_TimKiemGV
            // 
            this.txt_TimKiemGV.Location = new System.Drawing.Point(682, 465);
            this.txt_TimKiemGV.Name = "txt_TimKiemGV";
            this.txt_TimKiemGV.Size = new System.Drawing.Size(289, 26);
            this.txt_TimKiemGV.TabIndex = 9;
            this.txt_TimKiemGV.TextChanged += new System.EventHandler(this.txt_TimKiemGV_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tìm Kiếm (MãGV,TênGV):";
            // 
            // picture_GV
            // 
            this.picture_GV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_GV.Location = new System.Drawing.Point(660, 90);
            this.picture_GV.Name = "picture_GV";
            this.picture_GV.Size = new System.Drawing.Size(311, 273);
            this.picture_GV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_GV.TabIndex = 11;
            this.picture_GV.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(367, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quản Lý Giáo Viên";
            // 
            // btn_themGV
            // 
            this.btn_themGV.Location = new System.Drawing.Point(96, 398);
            this.btn_themGV.Name = "btn_themGV";
            this.btn_themGV.Size = new System.Drawing.Size(108, 40);
            this.btn_themGV.TabIndex = 5;
            this.btn_themGV.Text = "Thêm";
            this.btn_themGV.UseVisualStyleBackColor = true;
            this.btn_themGV.Click += new System.EventHandler(this.btn_themGV_Click);
            // 
            // btn_SửaGV
            // 
            this.btn_SửaGV.Location = new System.Drawing.Point(270, 398);
            this.btn_SửaGV.Name = "btn_SửaGV";
            this.btn_SửaGV.Size = new System.Drawing.Size(108, 40);
            this.btn_SửaGV.TabIndex = 6;
            this.btn_SửaGV.Text = "Sửa";
            this.btn_SửaGV.UseVisualStyleBackColor = true;
            this.btn_SửaGV.Click += new System.EventHandler(this.btn_SửaGV_Click);
            // 
            // btn_xoaGV
            // 
            this.btn_xoaGV.Location = new System.Drawing.Point(462, 398);
            this.btn_xoaGV.Name = "btn_xoaGV";
            this.btn_xoaGV.Size = new System.Drawing.Size(108, 40);
            this.btn_xoaGV.TabIndex = 7;
            this.btn_xoaGV.Text = "Xóa";
            this.btn_xoaGV.UseVisualStyleBackColor = true;
            this.btn_xoaGV.Click += new System.EventHandler(this.btn_xoaGV_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(646, 398);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(108, 40);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Đóng";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_themAnhGV
            // 
            this.btn_themAnhGV.Location = new System.Drawing.Point(562, 90);
            this.btn_themAnhGV.Name = "btn_themAnhGV";
            this.btn_themAnhGV.Size = new System.Drawing.Size(92, 30);
            this.btn_themAnhGV.TabIndex = 9;
            this.btn_themAnhGV.Text = "Chọn Ảnh";
            this.btn_themAnhGV.UseVisualStyleBackColor = true;
            this.btn_themAnhGV.Click += new System.EventHandler(this.btn_themAnhGV_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tên Ảnh";
            // 
            // txt_TenAnh
            // 
            this.txt_TenAnh.Location = new System.Drawing.Point(243, 337);
            this.txt_TenAnh.Name = "txt_TenAnh";
            this.txt_TenAnh.ReadOnly = true;
            this.txt_TenAnh.Size = new System.Drawing.Size(256, 26);
            this.txt_TenAnh.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(821, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ảnh";
            // 
            // frm_QLGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 757);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_TenAnh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_themAnhGV);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoaGV);
            this.Controls.Add(this.btn_SửaGV);
            this.Controls.Add(this.btn_themGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picture_GV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TimKiemGV);
            this.Controls.Add(this.dataGridView_DSGV);
            this.Controls.Add(this.txt_diachiGV);
            this.Controls.Add(this.txt_TenGV);
            this.Controls.Add(this.cb_GTGV);
            this.Controls.Add(this.txt_MaGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Giáo Viên";
            this.Load += new System.EventHandler(this.frm_QLGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_MaGV;
        public System.Windows.Forms.ComboBox cb_GTGV;
        public System.Windows.Forms.TextBox txt_TenGV;
        public System.Windows.Forms.TextBox txt_diachiGV;
        public System.Windows.Forms.DataGridView dataGridView_DSGV;
        public System.Windows.Forms.TextBox txt_TimKiemGV;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox picture_GV;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_themGV;
        public System.Windows.Forms.Button btn_SửaGV;
        public System.Windows.Forms.Button btn_xoaGV;
        public System.Windows.Forms.Button btn_thoat;
        public System.Windows.Forms.Button btn_themAnhGV;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_TenAnh;
        private System.Windows.Forms.Label label8;
    }
}
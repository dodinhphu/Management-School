
namespace INDIVIDUAL_PROJECT_CS414D_2020S.GUI
{
    partial class frm_ThongKeGV
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
            this.txt_maGV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tenGV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.dataGridView_DSLOPGVDangDay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_TatCaGV = new System.Windows.Forms.ListBox();
            this.txt_TongSoLopDay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSLOPGVDangDay)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_maGV
            // 
            this.txt_maGV.Location = new System.Drawing.Point(519, 46);
            this.txt_maGV.Name = "txt_maGV";
            this.txt_maGV.ReadOnly = true;
            this.txt_maGV.Size = new System.Drawing.Size(267, 26);
            this.txt_maGV.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mã Giáo Viên";
            // 
            // txt_tenGV
            // 
            this.txt_tenGV.Location = new System.Drawing.Point(519, 97);
            this.txt_tenGV.Name = "txt_tenGV";
            this.txt_tenGV.ReadOnly = true;
            this.txt_tenGV.Size = new System.Drawing.Size(267, 26);
            this.txt_tenGV.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tên Giáo Viên";
            // 
            // txt_GT
            // 
            this.txt_GT.Location = new System.Drawing.Point(519, 150);
            this.txt_GT.Name = "txt_GT";
            this.txt_GT.ReadOnly = true;
            this.txt_GT.Size = new System.Drawing.Size(267, 26);
            this.txt_GT.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tổng Số Lớp Đang Dạy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Chi Tiết Tất Cả Các Lớp Giáo Viên Này Đang Dạy:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(519, 202);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(267, 26);
            this.txt_DiaChi.TabIndex = 16;
            // 
            // dataGridView_DSLOPGVDangDay
            // 
            this.dataGridView_DSLOPGVDangDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSLOPGVDangDay.Location = new System.Drawing.Point(12, 334);
            this.dataGridView_DSLOPGVDangDay.MultiSelect = false;
            this.dataGridView_DSLOPGVDangDay.Name = "dataGridView_DSLOPGVDangDay";
            this.dataGridView_DSLOPGVDangDay.ReadOnly = true;
            this.dataGridView_DSLOPGVDangDay.Size = new System.Drawing.Size(827, 221);
            this.dataGridView_DSLOPGVDangDay.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tât Cả Giáo Viên:";
            // 
            // lb_TatCaGV
            // 
            this.lb_TatCaGV.FormattingEnabled = true;
            this.lb_TatCaGV.ItemHeight = 19;
            this.lb_TatCaGV.Location = new System.Drawing.Point(12, 46);
            this.lb_TatCaGV.Name = "lb_TatCaGV";
            this.lb_TatCaGV.Size = new System.Drawing.Size(210, 232);
            this.lb_TatCaGV.TabIndex = 13;
            this.lb_TatCaGV.Click += new System.EventHandler(this.lb_TatCaGV_Click);
            this.lb_TatCaGV.SelectedIndexChanged += new System.EventHandler(this.lb_TatCaGV_SelectedIndexChanged);
            // 
            // txt_TongSoLopDay
            // 
            this.txt_TongSoLopDay.Location = new System.Drawing.Point(519, 252);
            this.txt_TongSoLopDay.Name = "txt_TongSoLopDay";
            this.txt_TongSoLopDay.ReadOnly = true;
            this.txt_TongSoLopDay.Size = new System.Drawing.Size(267, 26);
            this.txt_TongSoLopDay.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Địa Chỉ";
            // 
            // frm_ThongKeGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 567);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_TongSoLopDay);
            this.Controls.Add(this.txt_maGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tenGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_GT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.dataGridView_DSLOPGVDangDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_TatCaGV);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ThongKeGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Giáo Viên";
            this.Load += new System.EventHandler(this.frm_ThongKeGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSLOPGVDangDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_maGV;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_tenGV;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_GT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_DiaChi;
        public System.Windows.Forms.DataGridView dataGridView_DSLOPGVDangDay;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lb_TatCaGV;
        public System.Windows.Forms.TextBox txt_TongSoLopDay;
        private System.Windows.Forms.Label label8;
    }
}
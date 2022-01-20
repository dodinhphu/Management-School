
namespace INDIVIDUAL_PROJECT_CS414D_2020S.GUI
{
    partial class frm_ThongKeLop
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
            this.lb_TatCaLop = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_DSHSCuaLop = new System.Windows.Forms.DataGridView();
            this.txt_TongHocSinhCuaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenGVDay = new System.Windows.Forms.TextBox();
            this.txt_tenLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSHSCuaLop)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TatCaLop
            // 
            this.lb_TatCaLop.FormattingEnabled = true;
            this.lb_TatCaLop.ItemHeight = 19;
            this.lb_TatCaLop.Location = new System.Drawing.Point(12, 31);
            this.lb_TatCaLop.Name = "lb_TatCaLop";
            this.lb_TatCaLop.Size = new System.Drawing.Size(143, 175);
            this.lb_TatCaLop.TabIndex = 0;
            this.lb_TatCaLop.Click += new System.EventHandler(this.lb_TatCaLop_Click);
            this.lb_TatCaLop.SelectedIndexChanged += new System.EventHandler(this.lb_TatCaLop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tât Cả Lớp:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView_DSHSCuaLop
            // 
            this.dataGridView_DSHSCuaLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSHSCuaLop.Location = new System.Drawing.Point(12, 269);
            this.dataGridView_DSHSCuaLop.MultiSelect = false;
            this.dataGridView_DSHSCuaLop.Name = "dataGridView_DSHSCuaLop";
            this.dataGridView_DSHSCuaLop.ReadOnly = true;
            this.dataGridView_DSHSCuaLop.Size = new System.Drawing.Size(827, 221);
            this.dataGridView_DSHSCuaLop.TabIndex = 3;
            // 
            // txt_TongHocSinhCuaLop
            // 
            this.txt_TongHocSinhCuaLop.Location = new System.Drawing.Point(476, 137);
            this.txt_TongHocSinhCuaLop.Name = "txt_TongHocSinhCuaLop";
            this.txt_TongHocSinhCuaLop.ReadOnly = true;
            this.txt_TongHocSinhCuaLop.Size = new System.Drawing.Size(267, 26);
            this.txt_TongHocSinhCuaLop.TabIndex = 4;
            this.txt_TongHocSinhCuaLop.TextChanged += new System.EventHandler(this.txt_TongHocSinhCuaLop_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chi Tiết Tất Cả Học Sinh Của Lớp Đã Chọn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng Số Học Sinh Trong Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giáo Viên Giảng Dạy";
            // 
            // txt_TenGVDay
            // 
            this.txt_TenGVDay.Location = new System.Drawing.Point(476, 192);
            this.txt_TenGVDay.Name = "txt_TenGVDay";
            this.txt_TenGVDay.ReadOnly = true;
            this.txt_TenGVDay.Size = new System.Drawing.Size(267, 26);
            this.txt_TenGVDay.TabIndex = 8;
            // 
            // txt_tenLop
            // 
            this.txt_tenLop.Location = new System.Drawing.Point(476, 82);
            this.txt_tenLop.Name = "txt_tenLop";
            this.txt_tenLop.ReadOnly = true;
            this.txt_tenLop.Size = new System.Drawing.Size(267, 26);
            this.txt_tenLop.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên Lớp";
            // 
            // txt_malop
            // 
            this.txt_malop.Location = new System.Drawing.Point(476, 31);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.ReadOnly = true;
            this.txt_malop.Size = new System.Drawing.Size(267, 26);
            this.txt_malop.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã Lớp";
            // 
            // frm_ThongKeLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 502);
            this.Controls.Add(this.txt_malop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tenLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TenGVDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TongHocSinhCuaLop);
            this.Controls.Add(this.dataGridView_DSHSCuaLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_TatCaLop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ThongKeLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Lớp";
            this.Load += new System.EventHandler(this.frm_ThongKeLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSHSCuaLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lb_TatCaLop;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView_DSHSCuaLop;
        public System.Windows.Forms.TextBox txt_TongHocSinhCuaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_TenGVDay;
        public System.Windows.Forms.TextBox txt_tenLop;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.Label label6;
    }
}
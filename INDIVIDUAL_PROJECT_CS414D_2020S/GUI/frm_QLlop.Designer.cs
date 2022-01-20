
namespace INDIVIDUAL_PROJECT_CS414D_2020S.GUI
{
    partial class frm_QLlop
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
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.txt_MaLOP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_DSLop = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_timKiemLop = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoaLop = new System.Windows.Forms.Button();
            this.btn_SửaLop = new System.Windows.Forms.Button();
            this.btn_themLop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_MaGV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSLop)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(339, 180);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(256, 26);
            this.txt_TenLop.TabIndex = 2;
            // 
            // txt_MaLOP
            // 
            this.txt_MaLOP.Location = new System.Drawing.Point(339, 113);
            this.txt_MaLOP.Name = "txt_MaLOP";
            this.txt_MaLOP.Size = new System.Drawing.Size(256, 26);
            this.txt_MaLOP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(319, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 31);
            this.label6.TabIndex = 34;
            this.label6.Text = "Quản Lý Lớp";
            // 
            // dataGridView_DSLop
            // 
            this.dataGridView_DSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSLop.Location = new System.Drawing.Point(12, 462);
            this.dataGridView_DSLop.Name = "dataGridView_DSLop";
            this.dataGridView_DSLop.Size = new System.Drawing.Size(781, 200);
            this.dataGridView_DSLop.TabIndex = 35;
            this.dataGridView_DSLop.Click += new System.EventHandler(this.dataGridView_DSLop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã Giáo Viên Dạy";
            // 
            // txt_timKiemLop
            // 
            this.txt_timKiemLop.Location = new System.Drawing.Point(599, 420);
            this.txt_timKiemLop.Name = "txt_timKiemLop";
            this.txt_timKiemLop.Size = new System.Drawing.Size(194, 26);
            this.txt_timKiemLop.TabIndex = 57;
            this.txt_timKiemLop.TextChanged += new System.EventHandler(this.txt_timKiemLop_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(401, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 19);
            this.label11.TabIndex = 56;
            this.label11.Text = "Tìm Kiếm (Mã Lớp,Tên Lớp):";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(567, 318);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(108, 40);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Đóng";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoaLop
            // 
            this.btn_xoaLop.Location = new System.Drawing.Point(423, 318);
            this.btn_xoaLop.Name = "btn_xoaLop";
            this.btn_xoaLop.Size = new System.Drawing.Size(108, 40);
            this.btn_xoaLop.TabIndex = 6;
            this.btn_xoaLop.Text = "Xóa";
            this.btn_xoaLop.UseVisualStyleBackColor = true;
            this.btn_xoaLop.Click += new System.EventHandler(this.btn_xoaHS_Click);
            // 
            // btn_SửaLop
            // 
            this.btn_SửaLop.Location = new System.Drawing.Point(279, 318);
            this.btn_SửaLop.Name = "btn_SửaLop";
            this.btn_SửaLop.Size = new System.Drawing.Size(108, 40);
            this.btn_SửaLop.TabIndex = 5;
            this.btn_SửaLop.Text = "Sửa";
            this.btn_SửaLop.UseVisualStyleBackColor = true;
            this.btn_SửaLop.Click += new System.EventHandler(this.btn_SửaLop_Click);
            // 
            // btn_themLop
            // 
            this.btn_themLop.Location = new System.Drawing.Point(139, 318);
            this.btn_themLop.Name = "btn_themLop";
            this.btn_themLop.Size = new System.Drawing.Size(108, 40);
            this.btn_themLop.TabIndex = 4;
            this.btn_themLop.Text = "Thêm";
            this.btn_themLop.UseVisualStyleBackColor = true;
            this.btn_themLop.Click += new System.EventHandler(this.btn_themLop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(390, -89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 31);
            this.label5.TabIndex = 51;
            this.label5.Text = "Quản Lý Học Sinh";
            // 
            // cb_MaGV
            // 
            this.cb_MaGV.FormattingEnabled = true;
            this.cb_MaGV.ItemHeight = 19;
            this.cb_MaGV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_MaGV.Location = new System.Drawing.Point(339, 244);
            this.cb_MaGV.Name = "cb_MaGV";
            this.cb_MaGV.Size = new System.Drawing.Size(256, 27);
            this.cb_MaGV.TabIndex = 58;
            // 
            // frm_QLlop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 670);
            this.Controls.Add(this.cb_MaGV);
            this.Controls.Add(this.txt_timKiemLop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoaLop);
            this.Controls.Add(this.btn_SửaLop);
            this.Controls.Add(this.btn_themLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_DSLop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TenLop);
            this.Controls.Add(this.txt_MaLOP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLlop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_lop";
            this.Load += new System.EventHandler(this.frm_lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_TenLop;
        public System.Windows.Forms.TextBox txt_MaLOP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dataGridView_DSLop;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_timKiemLop;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btn_thoat;
        public System.Windows.Forms.Button btn_xoaLop;
        public System.Windows.Forms.Button btn_SửaLop;
        public System.Windows.Forms.Button btn_themLop;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cb_MaGV;
    }
}
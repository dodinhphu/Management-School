
namespace INDIVIDUAL_PROJECT_CS414D_2020S.GUI
{
    partial class frm_TaoTK
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
            this.btn_tạo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tentkmoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MKMoi = new System.Windows.Forms.TextBox();
            this.txt_NhapLaiMKMoi = new System.Windows.Forms.TextBox();
            this.btn_dong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_tạo
            // 
            this.btn_tạo.Location = new System.Drawing.Point(259, 300);
            this.btn_tạo.Name = "btn_tạo";
            this.btn_tạo.Size = new System.Drawing.Size(109, 35);
            this.btn_tạo.TabIndex = 5;
            this.btn_tạo.Text = "Tạo";
            this.btn_tạo.UseVisualStyleBackColor = true;
            this.btn_tạo.Click += new System.EventHandler(this.btn_tạo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Tài Khoản Mới";
            // 
            // txt_tentkmoi
            // 
            this.txt_tentkmoi.Location = new System.Drawing.Point(318, 70);
            this.txt_tentkmoi.Name = "txt_tentkmoi";
            this.txt_tentkmoi.Size = new System.Drawing.Size(258, 26);
            this.txt_tentkmoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu Mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // txt_MKMoi
            // 
            this.txt_MKMoi.Location = new System.Drawing.Point(318, 137);
            this.txt_MKMoi.Name = "txt_MKMoi";
            this.txt_MKMoi.Size = new System.Drawing.Size(258, 26);
            this.txt_MKMoi.TabIndex = 2;
            this.txt_MKMoi.UseSystemPasswordChar = true;
            // 
            // txt_NhapLaiMKMoi
            // 
            this.txt_NhapLaiMKMoi.Location = new System.Drawing.Point(318, 209);
            this.txt_NhapLaiMKMoi.Name = "txt_NhapLaiMKMoi";
            this.txt_NhapLaiMKMoi.Size = new System.Drawing.Size(258, 26);
            this.txt_NhapLaiMKMoi.TabIndex = 4;
            this.txt_NhapLaiMKMoi.UseSystemPasswordChar = true;
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(496, 300);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(109, 35);
            this.btn_dong.TabIndex = 6;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(312, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tạo Tài Khoản";
            // 
            // frm_TaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 418);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.txt_NhapLaiMKMoi);
            this.Controls.Add(this.txt_MKMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tentkmoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tạo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TaoTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Tài Khoản";
            this.Load += new System.EventHandler(this.frm_TaoTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_tạo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_tentkmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_MKMoi;
        public System.Windows.Forms.TextBox txt_NhapLaiMKMoi;
        public System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Label label6;
    }
}
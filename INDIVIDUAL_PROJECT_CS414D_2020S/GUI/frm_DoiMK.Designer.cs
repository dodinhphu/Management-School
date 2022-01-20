
namespace INDIVIDUAL_PROJECT_CS414D_2020S.GUI
{
    partial class frm_DoiMK
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
            this.btn_dong = new System.Windows.Forms.Button();
            this.txt_MKMoi = new System.Windows.Forms.TextBox();
            this.txt_MKCu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tentkCandoiMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ĐoiMK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(367, 321);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(109, 35);
            this.btn_dong.TabIndex = 5;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // txt_MKMoi
            // 
            this.txt_MKMoi.Location = new System.Drawing.Point(205, 234);
            this.txt_MKMoi.Name = "txt_MKMoi";
            this.txt_MKMoi.Size = new System.Drawing.Size(258, 26);
            this.txt_MKMoi.TabIndex = 3;
            this.txt_MKMoi.UseSystemPasswordChar = true;
            // 
            // txt_MKCu
            // 
            this.txt_MKCu.Location = new System.Drawing.Point(205, 162);
            this.txt_MKCu.Name = "txt_MKCu";
            this.txt_MKCu.Size = new System.Drawing.Size(258, 26);
            this.txt_MKCu.TabIndex = 2;
            this.txt_MKCu.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mật Khẩu Mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật Khẩu Cũ";
            // 
            // txt_tentkCandoiMK
            // 
            this.txt_tentkCandoiMK.Location = new System.Drawing.Point(205, 95);
            this.txt_tentkCandoiMK.Name = "txt_tentkCandoiMK";
            this.txt_tentkCandoiMK.Size = new System.Drawing.Size(258, 26);
            this.txt_tentkCandoiMK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // btn_ĐoiMK
            // 
            this.btn_ĐoiMK.Location = new System.Drawing.Point(185, 321);
            this.btn_ĐoiMK.Name = "btn_ĐoiMK";
            this.btn_ĐoiMK.Size = new System.Drawing.Size(109, 35);
            this.btn_ĐoiMK.TabIndex = 4;
            this.btn_ĐoiMK.Text = "Đỗi Mật Khẩu";
            this.btn_ĐoiMK.UseVisualStyleBackColor = true;
            this.btn_ĐoiMK.Click += new System.EventHandler(this.btn_ĐoiMK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(188, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Đỗi Mật Khẩu";
            // 
            // frm_DoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 396);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.txt_MKMoi);
            this.Controls.Add(this.txt_MKCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tentkCandoiMK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ĐoiMK);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DoiMK";
            this.Load += new System.EventHandler(this.frm_DoiMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_dong;
        public System.Windows.Forms.TextBox txt_MKMoi;
        public System.Windows.Forms.TextBox txt_MKCu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_tentkCandoiMK;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_ĐoiMK;
        private System.Windows.Forms.Label label6;
    }
}
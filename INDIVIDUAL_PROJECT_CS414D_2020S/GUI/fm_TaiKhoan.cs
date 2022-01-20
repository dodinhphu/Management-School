using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace INDIVIDUAL_PROJECT_CS414D_2020S.GUI
{
    public partial class fm_TaiKhoan : Form
    {
         BLL.BLL_TaiKhoan BLL_TK;
        public fm_TaiKhoan()
        {
           BLL_TK =new BLL.BLL_TaiKhoan(this);
            InitializeComponent();
        }

        private void fm_TaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            
            BLL_TK.dangnhap();
          
        }

        private void btn_themtk_Click(object sender, EventArgs e)
        {
            frm_TaoTK taotk = new frm_TaoTK();
            this.Hide();
            taotk.ShowDialog();
            this.Show();
        }

        private void btn_doi_mk_Click(object sender, EventArgs e)
        {
            frm_DoiMK doimk = new frm_DoiMK();
            this.Hide();
            doimk.ShowDialog();
            this.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn thật sự muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

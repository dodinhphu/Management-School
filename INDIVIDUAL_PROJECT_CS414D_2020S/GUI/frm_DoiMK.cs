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
    public partial class frm_DoiMK : Form
    {
        BLL.BLL_TaiKhoan BLL_TK;
        public frm_DoiMK()
        {
            BLL_TK = new BLL.BLL_TaiKhoan(this);
            InitializeComponent();
        }

        private void btn_ĐoiMK_Click(object sender, EventArgs e)
        {
            BLL_TK.doimk();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DoiMK_Load(object sender, EventArgs e)
        {

        }
    }
}

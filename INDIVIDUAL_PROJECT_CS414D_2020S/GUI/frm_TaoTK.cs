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
    public partial class frm_TaoTK : Form
    {
        BLL.BLL_TaiKhoan BLL_taoTK;
        public frm_TaoTK()
        {
            BLL_taoTK = new BLL.BLL_TaiKhoan(this);
            InitializeComponent();
        }

        private void btn_tạo_Click(object sender, EventArgs e)
        {
            BLL_taoTK.taotk();
        }

        private void frm_TaoTK_Load(object sender, EventArgs e)
        {

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

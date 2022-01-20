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
    public partial class frm_ThongKeLop : Form
    {
        BLL.BLL_ThongKeLop BLL_thongkelop;
        public frm_ThongKeLop()
        {
            BLL_thongkelop = new BLL.BLL_ThongKeLop(this);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_ThongKeLop_Load(object sender, EventArgs e)
        {
            BLL_thongkelop.load_lop();
           
        }

        private void txt_TongHocSinhCuaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_TatCaLop_Click(object sender, EventArgs e)
        {
            BLL_thongkelop.tongHS();
            BLL_thongkelop.docdulieu();
            BLL_thongkelop.load_hs();
        }

        private void lb_TatCaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }
    }
}

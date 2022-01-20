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
    public partial class frm_QLlop : Form
    {
        BLL.BLL_Lop BLL_lop;
        DAL.LopDungChung dungchung = new DAL.LopDungChung();
        public frm_QLlop()
        {
            BLL_lop = new BLL.BLL_Lop(this);
            InitializeComponent();
        }
        private void btn_xoaHS_Click(object sender, EventArgs e)
        {
            BLL_lop.xoa_Lop();
            BLL_lop.load_Lop();
        }

        private void frm_lop_Load(object sender, EventArgs e)
        {
            BLL_lop.load_GV();
            BLL_lop.load_Lop();
           
        }

        private void btn_themLop_Click(object sender, EventArgs e)
        {
            BLL_lop.Them_Lop();
            BLL_lop.load_Lop();
        }

        private void btn_SửaLop_Click(object sender, EventArgs e)
        {
            BLL_lop.sua_Lop();
            BLL_lop.load_Lop();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_timKiemLop_TextChanged(object sender, EventArgs e)
        {
            string sql = " SELECT MALOP AS N'Mã Lớp',TENLOP AS N'Tên Lớp',MAGV AS N'Mã Giáo Viên',TENGV AS N'Tên Giáo Viên' FROM dbo.LOP WHERE MALOP LIKE '%" + txt_timKiemLop.Text + "%' OR TENLOP LIKE'%" + txt_timKiemLop.Text + "%' ";
            dataGridView_DSLop.DataSource = dungchung.load_dulieu(sql);
            dataGridView_DSLop.AutoResizeColumns();
            dataGridView_DSLop.AutoResizeRows();
        }

        private void dataGridView_DSLop_Click(object sender, EventArgs e)
        {
            int index = dataGridView_DSLop.CurrentRow.Index;
            txt_MaLOP.Text = dataGridView_DSLop.Rows[index].Cells[0].Value.ToString();
            txt_TenLop.Text = dataGridView_DSLop.Rows[index].Cells[1].Value.ToString();
            cb_MaGV.Text = dataGridView_DSLop.Rows[index].Cells[2].Value.ToString();
        }

    }
}

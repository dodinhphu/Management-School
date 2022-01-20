using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414D_2020S.BLL
{
    class BLL_Lop
    {
        // ĐỖ ĐÌNH PHÚ.MSV:6450

        DAL.DAL_Lop DAL_Lop = new DAL.DAL_Lop();
        GUI.frm_QLlop frm_Lop;
        public BLL_Lop(GUI.frm_QLlop form)
        {
            frm_Lop = form;
        }
        public void load_Lop()
        {
            frm_Lop.dataGridView_DSLop.DataSource = DAL_Lop.load_Lop();
            frm_Lop.dataGridView_DSLop.AutoResizeColumns();
            frm_Lop.dataGridView_DSLop.AutoResizeRows();
        }
        public void load_GV()
        {
            frm_Lop.cb_MaGV.DataSource = DAL_Lop.load_gv();
            frm_Lop.cb_MaGV.DisplayMember = "MAGV";
            frm_Lop.cb_MaGV.ValueMember = "TENGV";
        }
        //Thêm lop
        public void Them_Lop()
        {
            DAL_Lop.them_lop(frm_Lop.txt_MaLOP.Text.Trim(),frm_Lop.txt_TenLop.Text.Trim(),frm_Lop.cb_MaGV.Text.Trim(),frm_Lop.cb_MaGV.SelectedValue.ToString().Trim() );
            frm_Lop.txt_MaLOP.Clear();
            frm_Lop.txt_TenLop.Clear();
            frm_Lop.txt_TenLop.Clear();
        }
        //sửa lop
        public void sua_Lop()
        {
            DAL_Lop.sua_lop(frm_Lop.txt_MaLOP.Text.Trim(), frm_Lop.txt_TenLop.Text.Trim(), frm_Lop.cb_MaGV.Text.Trim(),frm_Lop.cb_MaGV.SelectedValue.ToString().Trim());
            frm_Lop.txt_MaLOP.Clear();
            frm_Lop.txt_TenLop.Clear();
            frm_Lop.txt_TenLop.Clear();
        }
        //xóa Lớp
        public void xoa_Lop()
        {
            DAL_Lop.xoa_lop(frm_Lop.txt_MaLOP.Text.Trim());
            frm_Lop.txt_MaLOP.Clear();
            frm_Lop.txt_TenLop.Clear();
            frm_Lop.txt_TenLop.Clear();
        }
    }
}

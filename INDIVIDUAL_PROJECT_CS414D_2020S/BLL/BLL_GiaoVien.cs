using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414D_2020S.BLL
{
    class BLL_GiaoVien
    {
        // ĐỖ ĐÌNH PHÚ.MSV:6450

        DAL.DAL_GiaoVien DAL_GV = new DAL.DAL_GiaoVien();
        GUI.frm_QLGiaoVien frm_gv;
        public BLL_GiaoVien(GUI.frm_QLGiaoVien form)
        {
            frm_gv = form;
        }
     
        // load danh sách GV
        public void load_GV()
        {
            frm_gv.dataGridView_DSGV.DataSource = DAL_GV.load_GV();
            frm_gv.dataGridView_DSGV.AutoResizeColumns();
            frm_gv.dataGridView_DSGV.AutoResizeRows();
        }
      
      
        //Thêm GV
        public void them_GV()
        {
            DAL_GV.them_gv(frm_gv.txt_MaGV.Text.Trim(), frm_gv.txt_TenGV.Text.Trim(), frm_gv.cb_GTGV.Text.Trim(), frm_gv.txt_diachiGV.Text.Trim(), frm_gv.txt_TenAnh.Text.Trim(), frm_gv.picture_GV);
            frm_gv.txt_MaGV.Clear();
            frm_gv.txt_TenGV.Clear();
            frm_gv.txt_diachiGV.Clear();
            frm_gv.txt_TenAnh.Clear();
        }
        //Sửa HS
        public void sua_hs()
        {
            DAL_GV.sua_gv(frm_gv.txt_MaGV.Text.Trim(), frm_gv.txt_TenGV.Text.Trim(), frm_gv.cb_GTGV.Text.Trim(), frm_gv.txt_diachiGV.Text.Trim(), frm_gv.txt_TenAnh.Text.Trim(), frm_gv.picture_GV,frm_gv.tenanhcu);
            frm_gv.txt_MaGV.Clear();
            frm_gv.txt_TenGV.Clear();
            frm_gv.txt_diachiGV.Clear();
            frm_gv.txt_TenAnh.Clear();

        }
        // Xóa HS
        public void xoa_hs()
        {

            DAL_GV.xoa_GV(frm_gv.txt_MaGV.Text.Trim(), frm_gv.txt_TenAnh.Text.Trim(), frm_gv.picture_GV);
            frm_gv.txt_MaGV.Clear();
            frm_gv.txt_TenGV.Clear();
            frm_gv.txt_diachiGV.Clear();
            frm_gv.txt_TenAnh.Clear();

        }
    }
}

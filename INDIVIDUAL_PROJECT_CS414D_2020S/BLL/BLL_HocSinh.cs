using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414D_2020S.BLL
{
    class BLL_HocSinh
    {
        // ĐỖ ĐÌNH PHÚ.MSV:6450

        DAL.DAL_HocSinh DAL_HS = new DAL.DAL_HocSinh();
        GUI.frm_QLHocSinh frm_hs;
        public BLL_HocSinh(GUI.frm_QLHocSinh form)
        {
            frm_hs = form;
        }
        // load danh sách học sinh
        public void load_hs()
        {
            frm_hs.dataGridView_DSHS.DataSource = DAL_HS.load_hs();
            frm_hs.dataGridView_DSHS.AutoResizeColumns();
            frm_hs.dataGridView_DSHS.AutoResizeRows();
           
        }
        //load mã Lớp  lên combobox trên form
        public void load_Lop()
        {
           frm_hs.cb_MaLop.DataSource= DAL_HS.load_Lop();
            frm_hs.cb_MaLop.DisplayMember = "TENLOP";
            frm_hs.cb_MaLop.ValueMember = "MALOP";
        }
        //load mã Khối  lên combobox trên form
        public void load_Khoi()
        {
            frm_hs.cb_KhoiLop.DataSource = DAL_HS.load_Khoi();
            frm_hs.cb_KhoiLop.DisplayMember = "TENKHOI";
            frm_hs.cb_KhoiLop.ValueMember = "MAKHOI";
        }
        //Thêm HS
        public void them_hs()
        {
            DAL_HS.them_HS(frm_hs.txt_MaHS.Text.Trim(), frm_hs.txt_TenHS.Text.Trim(), frm_hs.dt_NgaySinhHS.Text.Trim(), frm_hs.txt_diachiHS.Text.Trim(), frm_hs.cb_GTHS.Text.Trim(), frm_hs.cb_MaLop.SelectedValue.ToString().Trim(), frm_hs.cb_KhoiLop.SelectedValue.ToString().Trim(), frm_hs.txt_tenAnhHS.Text.Trim(), frm_hs.picture_HS);
            frm_hs.txt_MaHS.Clear();
            frm_hs.txt_TenHS.Clear();
            frm_hs.txt_diachiHS.Clear();
            frm_hs.txt_tenAnhHS.Clear();
            
        }
        //Sửa HS
        public void sua_hs()
        {
            DAL_HS.sua_HS(frm_hs.txt_MaHS.Text.Trim(), frm_hs.txt_TenHS.Text.Trim(), frm_hs.dt_NgaySinhHS.Text.Trim(), frm_hs.txt_diachiHS.Text.Trim(), frm_hs.cb_GTHS.Text.Trim(), frm_hs.cb_MaLop.SelectedValue.ToString().Trim(), frm_hs.cb_KhoiLop.SelectedValue.ToString().Trim(), frm_hs.txt_tenAnhHS.Text.Trim(), frm_hs.picture_HS, frm_hs.tenanhcu);
            frm_hs.txt_MaHS.Clear();
            frm_hs.txt_TenHS.Clear();
            frm_hs.txt_diachiHS.Clear();
            frm_hs.txt_tenAnhHS.Clear();
            frm_hs.picture_HS.Focus();

        }
        // Xóa HS
        public void xoa_hs()
        {
            DAL_HS.xoa_HS(frm_hs.txt_MaHS.Text, frm_hs.txt_tenAnhHS.Text, frm_hs.picture_HS);
            frm_hs.txt_MaHS.Clear();
            frm_hs.txt_TenHS.Clear();
            frm_hs.txt_diachiHS.Clear();
            frm_hs.txt_tenAnhHS.Clear();

        }
    }
}

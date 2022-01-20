using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace INDIVIDUAL_PROJECT_CS414D_2020S.BLL
{
    class BLL_TaiKhoan
    {
        // ĐỖ ĐÌNH PHÚ.MSV:6450

        DAL.DAL_TaiKhoan DAL_TK = new DAL.DAL_TaiKhoan();
        GUI.fm_TaiKhoan frm_TK;
        GUI.frm_TaoTK frm_TaoTK;
        GUI.frm_DoiMK frm_doiMK;

        public BLL_TaiKhoan(GUI.fm_TaiKhoan form)
        {
            frm_TK = form;
       
        }
        public BLL_TaiKhoan(GUI.frm_TaoTK form)
        {
            frm_TaoTK = form;

        }
        public BLL_TaiKhoan(GUI.frm_DoiMK form)
        {
            frm_doiMK = form;

        }
        public void dangnhap()
        {
            DAL_TK.dangnhap(frm_TK.txt_taikhoan.Text.Trim(), frm_TK.txt_matkhau.Text.Trim(),frm_TK);
            frm_TK.txt_taikhoan.Clear();
            frm_TK.txt_matkhau.Clear();


        }
        public void taotk()
        {
             DAL_TK.TaoTK(frm_TaoTK.txt_tentkmoi.Text.Trim(), frm_TaoTK.txt_MKMoi.Text.Trim(), frm_TaoTK.txt_NhapLaiMKMoi.Text.Trim());
             frm_TaoTK.txt_tentkmoi.Clear();
             frm_TaoTK.txt_MKMoi.Clear();
             frm_TaoTK.txt_NhapLaiMKMoi.Clear();
            
        }
        public void doimk()
        {
            DAL_TK.doiMk(frm_doiMK.txt_tentkCandoiMK.Text.Trim(), frm_doiMK.txt_MKCu.Text.Trim(), frm_doiMK.txt_MKMoi.Text.Trim());
            frm_doiMK.txt_tentkCandoiMK.Clear();
            frm_doiMK.txt_MKCu.Clear();
            frm_doiMK.txt_MKMoi.Clear();
        }
    }
}

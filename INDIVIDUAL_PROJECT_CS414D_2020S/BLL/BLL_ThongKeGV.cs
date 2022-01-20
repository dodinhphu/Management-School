using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414D_2020S.BLL
{
    class BLL_ThongKeGV
    {
        // ĐỖ ĐÌNH PHÚ.MSV:6450

        DAL.DAL_ThongKeGV DAL_ThongKeGV = new DAL.DAL_ThongKeGV();
        GUI.frm_ThongKeGV frm_thongKeGV;
        public BLL_ThongKeGV(GUI.frm_ThongKeGV form)
        {
            frm_thongKeGV = form;
        }
        public void load_GV()
        {
            frm_thongKeGV.lb_TatCaGV.DataSource = DAL_ThongKeGV.load_GV();
            frm_thongKeGV.lb_TatCaGV.DisplayMember = "MAGV";
            frm_thongKeGV.lb_TatCaGV.ValueMember = "MAGV";
        }

        public void tongGV()
        {
            frm_thongKeGV.txt_TongSoLopDay.Text = DAL_ThongKeGV.tong_so_Lop_GV_Dang_day(frm_thongKeGV.lb_TatCaGV.SelectedValue.ToString().Trim()).ToString().Trim();
        }
        // lấy ra các dử liểu trong database
        public void docdulieu()
        {
            DAL.LopDungChung dungchung = new DAL.LopDungChung();
            string sql = "SELECT * FROM dbo.GIAOVIEN WHERE MAGV='" + frm_thongKeGV.lb_TatCaGV.SelectedValue.ToString() + "'";
            if (dungchung.con == null)
            {
                dungchung.con = new SqlConnection(dungchung.chuoikn);
            }
            if (dungchung.con.State == ConnectionState.Closed)
            {
                dungchung.con.Open();
            }
            SqlCommand coman = new SqlCommand();
            coman.CommandType = CommandType.Text;
            coman.CommandText = sql;
            coman.Connection = dungchung.con;
            // thực thi
            SqlDataReader doc = coman.ExecuteReader();
            if (doc.Read())
            {
                frm_thongKeGV.txt_maGV.Text = doc.GetString(0);
                frm_thongKeGV.txt_tenGV.Text = doc.GetString(1);
                frm_thongKeGV.txt_GT.Text = doc.GetString(2);
                frm_thongKeGV.txt_DiaChi.Text = doc.GetString(3);
               
            }
            doc.Close();
            dungchung.con.Close();
        }
        public void load_datagridwied()
        {
            frm_thongKeGV.dataGridView_DSLOPGVDangDay.DataSource = DAL_ThongKeGV.load_LOP(frm_thongKeGV.lb_TatCaGV.SelectedValue.ToString());
            frm_thongKeGV.dataGridView_DSLOPGVDangDay.AutoResizeColumns();
            frm_thongKeGV.dataGridView_DSLOPGVDangDay.AutoResizeRows();
        }
    }
}

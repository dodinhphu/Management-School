using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
namespace INDIVIDUAL_PROJECT_CS414D_2020S.BLL
{
    class BLL_ThongKeLop
    {
        // ĐỖ ĐÌNH PHÚ.MSV:6450

        DAL.DAL_ThongKeLop DAL_ThongKeLop = new DAL.DAL_ThongKeLop();
        GUI.frm_ThongKeLop frm_thongkelop;
        public BLL_ThongKeLop(GUI.frm_ThongKeLop form)
        {
            frm_thongkelop = form;
        }
        public void load_lop()
        {
            frm_thongkelop.lb_TatCaLop.DataSource = DAL_ThongKeLop.load_lop();
            frm_thongkelop.lb_TatCaLop.DisplayMember = "MALOP";
            frm_thongkelop.lb_TatCaLop.ValueMember = "MALOP";
        }

        public void tongHS()
        {
            frm_thongkelop.txt_TongHocSinhCuaLop.Text = DAL_ThongKeLop.tong_so_hs_trong_lop(frm_thongkelop.lb_TatCaLop.SelectedValue.ToString().Trim()).ToString().Trim();
        }
        // lấy ra các dử liểu trong database
        public void docdulieu()
        {
            DAL.LopDungChung dungchung = new DAL.LopDungChung();
            string sql = "SELECT * FROM dbo.LOP WHERE MALOP='" + frm_thongkelop.lb_TatCaLop.SelectedValue.ToString() + "'";
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
                frm_thongkelop.txt_malop.Text = doc.GetString(0);
              frm_thongkelop.txt_tenLop.Text = doc.GetString(1);
              frm_thongkelop.txt_TenGVDay.Text = doc.GetString(3);
            }
            doc.Close();
            dungchung.con.Close();
        }
        public void load_hs()
        {
           frm_thongkelop.dataGridView_DSHSCuaLop.DataSource= DAL_ThongKeLop.load_HS(frm_thongkelop.lb_TatCaLop.SelectedValue.ToString() );
            frm_thongkelop.dataGridView_DSHSCuaLop.AutoResizeColumns();
            frm_thongkelop.dataGridView_DSHSCuaLop.AutoResizeRows();
        }
    }
}

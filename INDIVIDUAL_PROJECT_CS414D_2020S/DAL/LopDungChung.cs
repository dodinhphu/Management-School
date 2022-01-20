using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace INDIVIDUAL_PROJECT_CS414D_2020S.DAL
{
    class LopDungChung
    {
        // ĐỖ ĐÌNH PHÚ.MSV:6450

        public string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FSC\source\repos\INDIVIDUAL_PROJECT_CS414D_2020S\INDIVIDUAL_PROJECT_CS414D_2020S\QL_TruongTHPT.mdf;Integrated Security=True";
        public  SqlConnection con;
        public LopDungChung()
        {
            con = new SqlConnection(chuoikn);
        }
        public int them_sua_xoa(string sql)
        {
            SqlCommand coman = new SqlCommand(sql, con);
            con.Open();
            int kq = (int)coman.ExecuteNonQuery();
            con.Close();
            return kq;
        }
        public int dangnhap(string sql)
        {
            SqlCommand coman = new SqlCommand(sql, con);
            con.Open();
            int kq = (int)coman.ExecuteScalar();
            con.Close();
            return kq;
        }
        public DataTable load_dulieu(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}

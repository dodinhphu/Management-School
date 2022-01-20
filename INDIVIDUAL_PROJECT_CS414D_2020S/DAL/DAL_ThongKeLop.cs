using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace INDIVIDUAL_PROJECT_CS414D_2020S.DAL
{

    class DAL_ThongKeLop
    {
        // ĐỖ ĐÌNH PHÚ.MSV:6450

        LopDungChung dungchung = new LopDungChung();
        public DataTable load_lop()
        {
            string sql = "SELECT * FROM dbo.LOP";
            return dungchung.load_dulieu(sql);
        }
        public int tong_so_hs_trong_lop(string malop)
        {

            string sql = "SELECT COUNT(*) FROM dbo.HOCSINH WHERE MALOP='" + malop+ "'";
            return dungchung.dangnhap(sql);
        }
        // load học sinh trong lop
       public DataTable load_HS(string malop)
        {
            string sql = "SELECT MAHS AS N'Mã Học Sinh',TENHS AS N'Tên Học Sinh',GIOITINH AS N'Giới Tính',NGAYSINH AS N'Ngày Sinh',DIACHI AS N'Địa Chỉ',MALOP N'Mã Lớp',MAKHOI AS N'Mã Khối',TENANH AS N'Tên Ảnh' FROM dbo.HOCSINH WHERE '" + malop+"'=MALOP";
           return dungchung.load_dulieu(sql);
        }
    }
}

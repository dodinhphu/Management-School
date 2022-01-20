using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace INDIVIDUAL_PROJECT_CS414D_2020S.DAL
{
    class DAL_ThongKeGV
    {
        // ĐỖ ĐÌNH PHÚ.MSV:6450

        LopDungChung dungchung = new LopDungChung();
        public DataTable load_GV()
        {
            string sql = "SELECT * FROM dbo.GIAOVIEN";
            return dungchung.load_dulieu(sql);
        }
        public int tong_so_Lop_GV_Dang_day(string magv)
        {

            string sql = "SELECT COUNT(*) FROM dbo.LOP WHERE '" + magv + "'=MAGV";
            return dungchung.dangnhap(sql);
        }
        // load Lop GV Dang Day
        public DataTable load_LOP(string magv)
        {
            string sql = "SELECT MALOP AS N'Mã Lớp',TENLOP AS N'Tên Lớp',MAGV AS N'Mã Giáo Viên',TENGV AS N'Tên Giáo Viên' FROM dbo.LOP WHERE '" + magv + "'=MAGV";
            return dungchung.load_dulieu(sql);
        }
    }
}

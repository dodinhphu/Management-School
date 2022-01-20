using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;
namespace INDIVIDUAL_PROJECT_CS414D_2020S.DAL
{
    class DAL_Lop
    {
        // ĐỖ ĐÌNH PHÚ.MSV:6450

        LopDungChung dungchung = new LopDungChung();

        public DataTable load_Lop()
        {
            string sql = "SELECT MALOP AS N'Mã Lớp',TENLOP AS N'Tên Lớp',MAGV AS N'Mã Giáo Viên',TENGV AS N'Tên Giáo Viên' FROM dbo.LOP";
            return dungchung.load_dulieu(sql);
        }
        // tổng số Học Sinh Đang Học Trong Lớp
        public int tong_so_hs_trong_lop(string malop)
        {

            string sql = "SELECT COUNT(*) FROM dbo.HOCSINH WHERE '" + malop + "'=HOCSINH.MALOP";
            return dungchung.dangnhap(sql);
        }
        // Load Ma GV Vao Combobox Trên form
        public DataTable load_gv()
        {
            string sql = "SELECT * FROM dbo.GIAOVIEN";
            return dungchung.load_dulieu(sql);
        }
        // Thêm Lớp
        public void them_lop(string malop,string tenlop,string magv,string tengv)
        {
            // Kiểm tra Bỏ trống
            if (malop == "" || tenlop == "" || magv == ""|| tengv=="")
            {
                MessageBox.Show("Bạn Không Được Bỏ Trống Các Trường Khi Thêm Lớp !", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                // kiểm tra Mã GV Có trong DS hay Không
                string sql2 = "SELECT COUNT(*) FROM dbo.LOP WHERE MALOP='" + malop + "'";
                if (dungchung.dangnhap(sql2) > 0)
                {
                    MessageBox.Show(" Mã Lơp Đã Tồn Tại !", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    string sql = "INSERT dbo.LOP VALUES(   '" + malop + "', N'" + tenlop + "', '" + magv + "',N'" + tengv + "'  )";
                    int a = dungchung.them_sua_xoa(sql);
                    if (a > 0)
                    {
                        MessageBox.Show("Thêm Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Thêm Không thành Công !", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
        }
        // sủa lớp
        public void sua_lop(string malop, string tenlop, string magv,string tengv)
        {
            if (malop == "" || tenlop == "" || magv == ""|| tenlop=="")
            {
                MessageBox.Show("Bạn Không Được Bỏ Trống Các Trường Khi Sửa Lớp !", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                string sql2 = "SELECT COUNT(*) FROM dbo.LOP WHERE MALOP='" + malop + "'";
                if (dungchung.dangnhap(sql2) <= 0)
                {
                    MessageBox.Show(" Không Tìm Thấy Mã Lớp Cần Sửa Trong Danh Sách !", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    string sql = "INSERT dbo.LOP VALUES(  TENLOP= N'" + tenlop + "',MAGV= '" + magv + "',N'" + tengv + "' WHERE  MALOP='" + malop + "' )";
                    int a = dungchung.them_sua_xoa(sql);
                    if (a > 0)
                    {
                        MessageBox.Show("Sửa Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Sửa Không thành Công !", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
        }
        public void xoa_lop(string malop)
        {
            if (tong_so_hs_trong_lop(malop) > 0)
            {
                MessageBox.Show("Hiện Tại Đang Có " + tong_so_hs_trong_lop(malop) + " Học Sinh Trong Lớp Này,Không Thể Xóa !", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn thật sự muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    string sql = "DELETE FROM dbo.LOP WHERE MALOP='" + malop + "'";
                    int a = dungchung.them_sua_xoa(sql);
                    if (a > 0)
                    {

                        MessageBox.Show("Đã Xóa Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không thành Công !", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}

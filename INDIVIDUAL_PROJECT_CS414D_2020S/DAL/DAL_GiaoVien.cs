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
    class DAL_GiaoVien
    {
        // ĐỖ ĐÌNH PHÚ.MSV:6450

        LopDungChung dungchung = new LopDungChung();
        public DataTable load_GV()
        {
            string sql = "SELECT MAGV AS N'Mã Giáo Viên',TENGV AS N'Tên Giáo Viên', GIOITINH AS N'Giới Tính',DIACHI AS N'Địa Chỉ',TENANH AS N'Tên Ảnh' FROM dbo.GIAOVIEN";
            return dungchung.load_dulieu(sql);
        }
        // tổng số lớp gv đang dạy
        public int TonhsoLopDangday(string magv)
        {
         
            string sql = "SELECT COUNT(*) FROM dbo.LOP WHERE '" + magv + "'=LOP.MAGV";
            return dungchung.dangnhap(sql);
        }
        // thêm giáo viên
        public void them_gv(string magv,string tengv,string gioitinh,string diachi,string tenanh,PictureBox hinhanh)
        {
            // Kiểm tra Bỏ trống
            if (magv == "" || tengv == "" || gioitinh == "" || diachi == ""  || tenanh == "")
            {
                MessageBox.Show("Bạn Không Được Bỏ Trống Các Trường Khi Thêm Giáo Viên !", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                // kiểm tra Mã GV Có trong DS hay Không
                string sql2 = "SELECT COUNT(*) FROM dbo.GIAOVIEN WHERE MAGV='" + magv + "'";
                if (dungchung.dangnhap(sql2) > 0)
                {
                    MessageBox.Show(" Mã Giáo Viên Đã Trùng, Không Thể Thêm Học Sinh !", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    //Kiểm Tra Tên ảnh trùng
                    string sql1 = "SELECT COUNT(*) FROM dbo.GIAOVIEN WHERE TENANH=N'" + tenanh + "'";
                    if (dungchung.dangnhap(sql1) > 0)
                    {
                        MessageBox.Show("Ảnh Giáo Viên Đã Trùng !", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                       
                        string sql = " INSERT dbo.GIAOVIEN VALUES(   '" + magv + "', N'" + tengv + "',N'" + gioitinh + "',N'" + diachi + "',N'" + tenanh + "') ";
                        int kq = dungchung.them_sua_xoa(sql);
                        if (kq > 0)
                        {

                            MessageBox.Show("Bạn Đã Thêm Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                            hinhanh.Image.Save(@"C:\Users\FSC\source\repos\INDIVIDUAL_PROJECT_CS414D_2020S\INDIVIDUAL_PROJECT_CS414D_2020S\Hình Ảnh_Giáo Viên\" + tenanh);
                        }
                        else
                        {
                            MessageBox.Show("Bạn Đã Thêm Không thành Công !", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        //Sửa Thông Tin Học Sinh
        public void sua_gv(string magv, string tengv, string gioitinh, string diachi, string tenanh, PictureBox hinhanh,string tenanhcu)
        {
            // Kiểm tra Bỏ trống
            if (magv == "" || tengv == "" || gioitinh == "" || diachi == "" || tenanh == "")
            {
                MessageBox.Show("Bạn Không Được Bỏ Trống Các Trường Khi Thêm Giáo Viên !", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                // kiểm tra Giáo Viên có trong ds hay ko
                string sql1 = "SELECT COUNT(*) FROM dbo.GIAOVIEN WHERE MAGV='" + magv + "'";
                if (dungchung.dangnhap(sql1) <= 0)
                {
                    MessageBox.Show("Không Tìm Thấy Giáo Viên Thích Hợp Để Sửa !", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    string sql = " UPDATE dbo.GIAOVIEN SET TENGV= N'" + tengv + "',GIOITINH=N'" + gioitinh + "',DIACHI=N'" + diachi + "',TENANH=N'" + tenanh + "' WHERE MAGV='" + magv + "' ";
                    int kq = dungchung.them_sua_xoa(sql);
                    if (kq > 0)
                    {

                        MessageBox.Show("Bạn Đã Sửa Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                        // trước khi thêm ảnh mới thì xóa ảnh cũ
                        File.Delete(@"C:\Users\FSC\source\repos\INDIVIDUAL_PROJECT_CS414D_2020S\INDIVIDUAL_PROJECT_CS414D_2020S\Hình Ảnh_Giáo Viên\" + tenanhcu);
                        // Thêm ảnh Mới
                        hinhanh.Image.Save(@"C:\Users\FSC\source\repos\INDIVIDUAL_PROJECT_CS414D_2020S\INDIVIDUAL_PROJECT_CS414D_2020S\Hình Ảnh_Giáo Viên\" + tenanh);
                    }
                    else
                    {
                        MessageBox.Show("Sửa Không thành Công !", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        // Xóa Học Sinh
        public void xoa_GV(string magv, string tenanh, PictureBox hinhanh)
        {
            // kt xem GV Có Đang Dạy Lơp Nào Không
            
            if (TonhsoLopDangday(magv) > 0)
            {
                MessageBox.Show("Hiện Tại Giáo Viên Đang Dạy "+ TonhsoLopDangday(magv) + " Lớp, Bạn Không Thể Xóa !", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn thật sự muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    string sql = "DELETE dbo.GIAOVIEN WHERE MAGV='" + magv + "' ";
                    int kq = dungchung.them_sua_xoa(sql);
                    if (kq > 0)
                    {

                        MessageBox.Show("Bạn Đã Xóa Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                        File.Delete(@"C:\Users\FSC\source\repos\INDIVIDUAL_PROJECT_CS414D_2020S\INDIVIDUAL_PROJECT_CS414D_2020S\Hình Ảnh_Giáo Viên\" + tenanh);
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

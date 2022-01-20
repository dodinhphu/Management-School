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
    class DAL_HocSinh
    {
        // ĐỖ ĐÌNH PHÚ.MSV:6450

        LopDungChung dungchung = new LopDungChung();
        // load danh sách học sinh
        public DataTable load_hs()
        {
            string sql = "SELECT MAHS AS N'Mã Học Sinh',TENHS AS N'Tên Học Sinh',GIOITINH AS N'Giới Tính',NGAYSINH AS N'Ngày Sinh',DIACHI AS N'Địa Chỉ',MALOP N'Mã Lớp',MAKHOI AS N'Mã Khối',TENANH AS N'Tên Ảnh' FROM dbo.HOCSINH";
            DataTable tb = new DataTable();
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
        //load mã Lớp  lên combobox trên form
        public DataTable load_Lop()
        {
            string sql = "SELECT  * FROM dbo.LOP";
            return dungchung.load_dulieu(sql);
        }
        //load mã Khối  lên combobox trên form
        public DataTable load_Khoi()
        {
            string sql = "SELECT * FROM dbo.KHOI";
            return dungchung.load_dulieu(sql);
        }
        //Thêm Học Sinh Mới
        public void them_HS(string ma_hs, string ten_hs, string ngaysinh,string gioitinh, string diachi ,string malop,string makhoi,string tenanh, PictureBox hinhanh)
        {
           // Kiểm tra Bỏ trống
            if (ma_hs == "" || ten_hs == "" || diachi == "" || gioitinh == "" || ngaysinh == "" ||tenanh=="")
            {
                MessageBox.Show("Bạn Không Được Bỏ Trống Các Trường Khi Thêm Học Sinh !", "Thông Báo", MessageBoxButtons.OK);
            } 
            else
            {
                // kiểm tra Mã HS Có trong DS hay Không
                string sql2 = "SELECT COUNT(*) FROM dbo.HO  CSINH WHERE MAHS='" + ma_hs + "'";
                if (dungchung.dangnhap(sql2) > 0)
                {
                    MessageBox.Show(" Mã Sinh Viên Đã Trùng, Không Thể Thêm Học Sinh !", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    //Kiểm Tra Tên ảnh trùng
                    string sql1 = "SELECT COUNT(*) FROM dbo.HOCSINH WHERE TENANH=N'" + tenanh + "'";
                    if (dungchung.dangnhap(sql1) > 0)
                    {
                        MessageBox.Show("Ảnh Học Sinh Đã Trùng !", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string sql = " INSERT dbo.HOCSINH VALUES(   '" + ma_hs + "', N'" + ten_hs + "',CONVERT(DATE,'" + ngaysinh + "',103),N'" + diachi + "',N'" + gioitinh + "','" + malop + "','" + makhoi + "',N'" + tenanh + "') ";
                        int kq = dungchung.them_sua_xoa(sql);
                        if (kq > 0)
                        {

                            MessageBox.Show("Bạn Đã Thêm Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                            hinhanh.Image.Save(@"C:\Users\FSC\source\repos\INDIVIDUAL_PROJECT_CS414D_2020S\INDIVIDUAL_PROJECT_CS414D_2020S\Hình Ảnh_Học Sinh\" + tenanh);
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
        public void sua_HS(string ma_hs, string ten_hs, string ngaysinh, string diachi, string gioitinh, string malop, string makhoi, string tenanh, PictureBox hinhanh,string tenanhcu)
        {
            // Kiểm tra Bỏ trống
            if (ma_hs == "" || ten_hs == "" || diachi == "" || gioitinh == "" || ngaysinh == "" || tenanh == "")
            {
                MessageBox.Show("Bạn Không Được Bỏ Trống Các Trường Khi Thêm Học Sinh !", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                // kiểm tra Mã Học Sinh Có trong DS hay Không
                string sql1 = "SELECT COUNT(*) FROM dbo.HOCSINH WHERE MAHS='" + ma_hs + "'";
                if (dungchung.dangnhap(sql1) <= 0)
                {
                    MessageBox.Show("Không Tìm Thấy Hoc Sinh Thích Hợp Để Sửa !", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    string sql = " UPDATE dbo.HOCSINH SET TENHS= N'" + ten_hs + "', NGAYSINH=CONVERT(DATE,'" + ngaysinh + "',103),DIACHI=N'" + diachi + "',GIOITINH=N'" + gioitinh + "',MALOP='" + malop + "',MAKHOI='" + makhoi + "',TENANH=N'" + tenanh + "' WHERE MAHS='" + ma_hs + "' ";
                    int kq = dungchung.them_sua_xoa(sql);
                    if (kq > 0)
                    {

                        MessageBox.Show("Bạn Đã Sửa Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                        // trước khi thêm ảnh mới thì xóa ảnh cũ
                        File.Delete(@"C:\Users\FSC\source\repos\INDIVIDUAL_PROJECT_CS414D_2020S\INDIVIDUAL_PROJECT_CS414D_2020S\Hình Ảnh_Học Sinh\" + tenanhcu);
                        // Thêm ảnh Mới
                        hinhanh.Image.Save(@"C:\Users\FSC\source\repos\INDIVIDUAL_PROJECT_CS414D_2020S\INDIVIDUAL_PROJECT_CS414D_2020S\Hình Ảnh_Học Sinh\" + tenanh);
                    }
                    else
                    {
                        MessageBox.Show("Sửa Không thành Công !", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
        }
        // Xóa Học Sinh
        public void xoa_HS(string ma_hs,string tenanh,PictureBox hinhanh)
        {
            DialogResult dialog = MessageBox.Show("Bạn thật sự muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                string sql = "DELETE dbo.HOCSINH WHERE MAHS='"+ma_hs+"' ";
                int kq = dungchung.them_sua_xoa(sql);
                if (kq > 0)
                {

                    MessageBox.Show("Bạn Đã Xóa Thành Công !", "Thông Báo", MessageBoxButtons.OK);                  
                    File.Delete(@"C:\Users\FSC\source\repos\INDIVIDUAL_PROJECT_CS414D_2020S\INDIVIDUAL_PROJECT_CS414D_2020S\Hình Ảnh_Học Sinh\" + tenanh);                  
                }
                else
                {
                    MessageBox.Show("Xóa Không thành Công !", "Thông Báo", MessageBoxButtons.OK);
                }
            }  
        }
    }
}

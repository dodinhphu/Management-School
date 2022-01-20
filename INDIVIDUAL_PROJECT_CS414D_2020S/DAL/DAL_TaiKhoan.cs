using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace INDIVIDUAL_PROJECT_CS414D_2020S.DAL
{
    class DAL_TaiKhoan
    {
        // ĐỖ ĐÌNH PHÚ.MSV:6450

        LopDungChung dungchung = new LopDungChung();
        public void dangnhap(string tentk, string matkhau, GUI.fm_TaiKhoan tk)
        {
            tentk = tentk.Trim();
            tentk = tentk.ToUpper();
            string sql = "SELECT COUNT(*) FROM dbo.TAIKHOAN WHERE TENTK='" + tentk.ToUpper() + "' AND MATKHAU='" + matkhau + "'";
            int a = dungchung.dangnhap(sql);
            if (a > 0)
            {
                MessageBox.Show("Đăng Nhập Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                GUI.frm_TrangChu trangchu = new GUI.frm_TrangChu();
                // ẩn form đăng nhập sau khi đã đăng nhập thành công và hiện form đăng nhập khi thoát khỏi form trang chủ
                tk.Hide();
                trangchu.ShowDialog();
                tk.Show();
            }
            else
            {
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu !", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        public void TaoTK(string tentk, string matkhaumoi, string nhaplaimatkhaumoi)
        {

            if (matkhaumoi != nhaplaimatkhaumoi)
            {
                MessageBox.Show("Hai Mật Khẩu Không Khớp !!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = " SELECT COUNT(*) FROM dbo.TAIKHOAN WHERE TENTK='" + tentk + "' ";

                int a = dungchung.dangnhap(sql1);
                if (a > 0)
                {
                    MessageBox.Show("Tài Khoản Đã Tồn Tại !", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    string sql = " INSERT dbo.TAIKHOAN  VALUES (   '" + tentk + "', '" + matkhaumoi + "') ";
                    int b = dungchung.them_sua_xoa(sql);
                    if (b > 0)
                    {
                        MessageBox.Show("Tạo Tài Khoản Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Tạo Tài Khoản Thất Bại Thất Bại !", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
        }
        public void doiMk(string tentk, string matkhaucu, string matkhaumoi)
        {
            string sql1 = " SELECT COUNT(*) FROM dbo.TAIKHOAN WHERE TENTK='" + tentk + "' ";
            int a = dungchung.dangnhap(sql1);
            if (a > 0)
            {
                string sql2 = "SELECT COUNT(*) FROM dbo.TAIKHOAN WHERE TENTK='" + tentk + "' AND MATKHAU='" + matkhaucu + "'";
                int b = dungchung.dangnhap(sql2);
                    if (b > 0)
                    {
                        string sql = " UPDATE dbo.TAIKHOAN SET MATKHAU='" + matkhaumoi + "' WHERE TENTK='" + tentk + "'";
                        int c = dungchung.them_sua_xoa(sql);
                        if (c > 0)
                        {
                            MessageBox.Show("Đỗi Mật Khẩu Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Đỗi Mật Khẩu Thất Bại Thất Bại !", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu Cũ Không Đúng !", "Thông Báo", MessageBoxButtons.OK);
                    }
            }
            else
            {
                MessageBox.Show("Tên Tài Khoản Không Tồn Tại !", "Thông Báo", MessageBoxButtons.OK);

            }
        }
    }
}

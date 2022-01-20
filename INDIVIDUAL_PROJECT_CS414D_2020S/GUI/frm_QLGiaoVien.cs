using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414D_2020S.GUI
{
    public partial class frm_QLGiaoVien : Form
    {
        DAL.LopDungChung dungchung = new DAL.LopDungChung();
        BLL.BLL_GiaoVien BLL_GV;
        public frm_QLGiaoVien()
        {
            BLL_GV = new BLL.BLL_GiaoVien(this);
            InitializeComponent();
        }
        public string tenanhcu;
        private void frm_QLGiaoVien_Load(object sender, EventArgs e)
        {
            BLL_GV.load_GV(); 
        }

        private void btn_themGV_Click(object sender, EventArgs e)
        {
            BLL_GV.them_GV();
            BLL_GV.load_GV();
        }

        private void btn_SửaGV_Click(object sender, EventArgs e)
        {
            BLL_GV.sua_hs();
            BLL_GV.load_GV();
        }

        private void btn_xoaGV_Click(object sender, EventArgs e)
        {
            BLL_GV.xoa_hs();
            BLL_GV.load_GV();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_themAnhGV_Click(object sender, EventArgs e)
        {
            OpenFileDialog them = new OpenFileDialog();
            them.Title = "Hãy Chọn Hình Hỉnh Sản Phẩm";
            them.Filter = " JPG|*.jpg|Tất Cả File|*.*";

            if (them.ShowDialog() == DialogResult.OK)
            {
                txt_TenAnh.Text = them.SafeFileName.ToString();
                picture_GV.Image = Image.FromFile(them.FileName);
            }
        }

        private void txt_TimKiemGV_TextChanged(object sender, EventArgs e)
        {
           string sql = " SELECT MAGV AS N'Mã Giáo Viên',TENGV AS N'Tên Giáo Viên', GIOITINH AS N'Giới Tính',DIACHI AS N'Địa Chỉ',TENANH AS N'Tên Ảnh' FROM dbo.GIAOVIEN WHERE MAGV LIKE '%" + txt_TimKiemGV.Text + "%' OR TENGV LIKE'%" + txt_TimKiemGV.Text + "%' ";
            dataGridView_DSGV.DataSource = dungchung.load_dulieu(sql);
            dataGridView_DSGV.AutoResizeColumns();
            dataGridView_DSGV.AutoResizeRows();
        }


        private void dataGridView_DSGV_Click(object sender, EventArgs e)
        {
            int index = dataGridView_DSGV.CurrentRow.Index;
            txt_MaGV.Text = dataGridView_DSGV.Rows[index].Cells[0].Value.ToString();
            txt_TenGV.Text = dataGridView_DSGV.Rows[index].Cells[1].Value.ToString();
            cb_GTGV.Text = dataGridView_DSGV.Rows[index].Cells[2].Value.ToString();
            txt_diachiGV.Text = dataGridView_DSGV.Rows[index].Cells[3].Value.ToString();
            txt_TenAnh.Text = dataGridView_DSGV.Rows[index].Cells[4].Value.ToString();
            tenanhcu = txt_TenAnh.Text;
            picture_GV.ImageLocation = @"C:\Users\FSC\source\repos\INDIVIDUAL_PROJECT_CS414D_2020S\INDIVIDUAL_PROJECT_CS414D_2020S\Hình Ảnh_Giáo Viên\" + txt_TenAnh.Text;
        }

        private void dataGridView_DSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

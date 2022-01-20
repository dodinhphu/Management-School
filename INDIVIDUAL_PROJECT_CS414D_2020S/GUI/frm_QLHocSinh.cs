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
    public partial class frm_QLHocSinh : Form
    {
        BLL.BLL_HocSinh BLL_HS;
        DAL.LopDungChung dungchung = new DAL.LopDungChung();
        public frm_QLHocSinh()
        {
            BLL_HS = new BLL.BLL_HocSinh(this);
            InitializeComponent();
        }
        private void frm_HocSinh_Load(object sender, EventArgs e)
        {
            BLL_HS.load_hs();
           BLL_HS.load_Lop();
            BLL_HS.load_Khoi();
        }

        private void btn_themHS_Click(object sender, EventArgs e)
        {
            BLL_HS.them_hs();
            BLL_HS.load_hs();
        }

        private void btn_SửaHS_Click(object sender, EventArgs e)
        {
            BLL_HS.sua_hs();
            BLL_HS.load_hs();
        }

        private void btn_xoaHS_Click(object sender, EventArgs e)
        {
            BLL_HS.xoa_hs();
            BLL_HS.load_hs();
        }
        public string tenanhcu;
        private void dataGridView_DSHS_Click(object sender, EventArgs e)
        {
            int index = dataGridView_DSHS.CurrentRow.Index;
            txt_MaHS.Text = dataGridView_DSHS.Rows[index].Cells[0].Value.ToString();
            txt_TenHS.Text = dataGridView_DSHS.Rows[index].Cells[1].Value.ToString();
            cb_GTHS.Text = dataGridView_DSHS.Rows[index].Cells[2].Value.ToString();
            dt_NgaySinhHS.Text = dataGridView_DSHS.Rows[index].Cells[3].Value.ToString();
            txt_diachiHS.Text = dataGridView_DSHS.Rows[index].Cells[4].Value.ToString();
            txt_tenAnhHS.Text = dataGridView_DSHS.Rows[index].Cells[7].Value.ToString();
            tenanhcu = txt_tenAnhHS.Text;
            picture_HS.ImageLocation = @"C:\Users\FSC\source\repos\INDIVIDUAL_PROJECT_CS414D_2020S\INDIVIDUAL_PROJECT_CS414D_2020S\Hình Ảnh_Học Sinh\" + txt_tenAnhHS.Text;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    
        private void btn_themAnhGV_Click(object sender, EventArgs e)
        {
            OpenFileDialog them = new OpenFileDialog();
            them.Title = "Hãy Chọn Hình Hỉnh Sản Phẩm";
            them.Filter = " JPG|*.jpg|Tất Cả File|*.*";

            if (them.ShowDialog() == DialogResult.OK)
            {
                txt_tenAnhHS.Text = them.SafeFileName.ToString();
                picture_HS.Image = Image.FromFile(them.FileName);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_timKiemHS_TextChanged(object sender, EventArgs e)
        {
            string sql = " SELECT MAHS AS N'Mã Học Sinh',TENHS AS N'Tên Học Sinh',GIOITINH AS N'Giới Tính',NGAYSINH AS N'Ngày Sinh',DIACHI AS N'Địa Chỉ',MALOP N'Mã Lớp',MAKHOI AS N'Mã Khối',TENANH AS N'Tên Ảnh' FROM dbo.HOCSINH WHERE MAHS LIKE '%" + txt_timKiemHS.Text + "%' OR TENHS LIKE'%" + txt_timKiemHS.Text + "%' ";
            dataGridView_DSHS.DataSource = dungchung.load_dulieu(sql);
            dataGridView_DSHS.AutoResizeColumns();
            dataGridView_DSHS.AutoResizeRows();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

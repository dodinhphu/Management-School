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
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLHocSinh"] == null)
            {
              
   
                    frm_QLHocSinh hocsinh = new frm_QLHocSinh();

                    hocsinh.MdiParent = this;
                    hocsinh.Show();
                
            }
            else
            {
                Application.OpenForms["frm_QLHocSinh"].Activate();
            }
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLGiaoVien"] == null)
            {
                frm_QLGiaoVien GV = new frm_QLGiaoVien();
                GV.MdiParent = this;
                GV.Show();
            }
            else
            {
                Application.OpenForms["frm_QLGiaoVien"].Activate();
            }
        }

        private void frm_TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLlop"] == null)
            {
                frm_QLlop lop = new frm_QLlop();
                lop.MdiParent = this;
                lop.Show();
            }
            else
            {
                Application.OpenForms["frm_QLlop"].Activate();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thốngKêLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThongKeLop"] == null)
            {
                frm_ThongKeLop thongkelop = new frm_ThongKeLop();
                thongkelop.MdiParent = this;
                thongkelop.Show();
            }
            else
            {
                Application.OpenForms["frm_ThongKeLop"].Activate();
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThongKeGV"] == null)
            {
                frm_ThongKeGV thongkeGV = new frm_ThongKeGV();
                thongkeGV.MdiParent = this;
                thongkeGV.Show();
            }
            else
            {
                Application.OpenForms["frm_ThongKeGV"].Activate();
            }
        }
    }
}

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
    public partial class frm_ThongKeGV : Form
    {
        BLL.BLL_ThongKeGV BLL_ThongKeGV;
        public frm_ThongKeGV()
        {
            BLL_ThongKeGV = new BLL.BLL_ThongKeGV(this);
            InitializeComponent();
        }

        private void lb_TatCaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void frm_ThongKeGV_Load(object sender, EventArgs e)
        {
            BLL_ThongKeGV.load_GV();
        }

        private void lb_TatCaGV_Click(object sender, EventArgs e)
        {
            BLL_ThongKeGV.tongGV();
            BLL_ThongKeGV.docdulieu();
            BLL_ThongKeGV.load_datagridwied();
        
        }
    }
}

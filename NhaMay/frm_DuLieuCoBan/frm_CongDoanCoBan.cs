using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaMay.frm_DuLieCoBan
{
    public partial class frm_CongDoanCoBan : Form
    {
        public frm_CongDoanCoBan()
        {
            InitializeComponent();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            btn_LuuLai.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Refresh.Enabled = false;
            btn_ThemMoi.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_ChinhSuaDuLieu.Enabled = false;
            tabControl1.SelectedIndex = 1;
        }
    }
}

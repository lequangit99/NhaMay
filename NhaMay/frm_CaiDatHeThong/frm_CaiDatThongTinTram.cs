using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaMay
{
    public partial class frm_CaiDatThongTinTram : Form
    {
        public frm_CaiDatThongTinTram()
        {
            InitializeComponent();
        }

        private void btn_MoDayTruyen_Click(object sender, EventArgs e)
        {
            frm_DayTruyenDaDangKy frm = new frm_DayTruyenDaDangKy();
            frm.Show();
        }

        private void btn_ChinhSuaDuLieu_Click(object sender, EventArgs e)
        {
            btn_MoDayTruyen.Visible = false;
            btn_ChinhSuaDuLieu.Visible = false;
            btn_ThemMoi.Visible = false;
            btn_Xoa.Visible = false;
            btn_ThayDoiSever.Visible = false;
            btn_Print.Visible = false;
            btn_LuuLai.Visible = true;
            btn_HuyBo.Visible = true;
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn huỷ bỏ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                btn_MoDayTruyen.Visible = true;
                btn_ChinhSuaDuLieu.Visible = true;
                btn_ThemMoi.Visible = true;
                btn_Xoa.Visible = true;
                btn_ThayDoiSever.Visible = true;
                btn_Print.Visible = true;
                btn_LuuLai.Visible = false;
                btn_HuyBo.Visible = false;
            }

        }

        private void btn_LuuLai_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn lưu lại không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                btn_MoDayTruyen.Visible = true;
                btn_ChinhSuaDuLieu.Visible = true;
                btn_ThemMoi.Visible = true;
                btn_Xoa.Visible = true;
                btn_ThayDoiSever.Visible = true;
                btn_Print.Visible = true;
                btn_LuuLai.Visible = false;
                btn_HuyBo.Visible = false;
            }
        }
    }
}

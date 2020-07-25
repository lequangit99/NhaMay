using NhaMay.frm_DuLieCoBan;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NhaMay
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            customizeDesing();
        }


        private void customizeDesing()
        {
            panel_KiemSoatVanHanh.Visible = false;
            panel_ThongTin.Visible = false;
            panel_DuLieuCoBan.Visible = false;
            panel_DuLieuDonHang.Visible = false;
            panel_BaoCao.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panel_KiemSoatVanHanh.Visible == true)
            {
                panel_KiemSoatVanHanh.Visible = false;
            }
            if (panel_DuLieuCoBan.Visible == true)
            {
                panel_DuLieuCoBan.Visible = false;
            }
            if (panel_DuLieuDonHang.Visible == true)
            {
                panel_DuLieuDonHang.Visible = false;
            }
            if (panel_ThongTin.Visible == true)
            {
                panel_ThongTin.Visible = false;
            }
            if (panel_BaoCao.Visible == true)
            {
                panel_BaoCao.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void menuItem_ToSX_in_DLCB_Click(object sender, EventArgs e)
        {
            frm_ToSanXuat frm = new frm_ToSanXuat();
            TabCreating(tabControl1, "Tổ sản xuất", frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_KiemSoatVanHanh);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_ThongTin);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_DuLieuCoBan);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_DuLieuDonHang);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_BaoCao);
        }

        #region KiemTraTonTaiTab
        static int KiemTraTonTai(TabControl TabControlName, string TabName)
        {
            int temp = -1;

            for (int i = 0; i < TabControlName.TabPages.Count; i++)

            {

                if (TabControlName.TabPages[i].Text == TabName)
                {
                    temp = i;

                    break;
                }
            }
            return temp;

        }
        #endregion
        #region TabCreating
        public void TabCreating(TabControl TabControl, string Text, Form Form)
        {

            int Index = KiemTraTonTai(TabControl, Text);

            if (Index >= 0)
            {

                TabControl.SelectedTab = TabControl.TabPages[Index];
                TabControl.SelectedTab.Text = Text;

            }
            else
            {
                TabPage TabPage = new TabPage { Text = Text };
                TabControl.TabPages.Add(TabPage);
                TabControl.SelectedTab = TabPage;

                Form.TopLevel = false;
                Form.Parent = TabPage;
                Form.FormBorderStyle = FormBorderStyle.None;

                //  Form.MdiParent = this;
                Form.Show();
                Form.Dock = DockStyle.Fill;

            }

        }
        #endregion
        #region Dấu X Tab
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;

            Font drawFont = new Font("Arial", 10);

            g.FillRectangle(new SolidBrush(Color.LightBlue), e.Bounds);

            e.Graphics.DrawString("X", drawFont, Brushes.Red, e.Bounds.Right - 12, e.Bounds.Top + 4);

            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 1, e.Bounds.Top + 4);

            e.DrawFocusRectangle();
        }
        #endregion
        #region MessageBox Tab Close
        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            //Looping through the controls.
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);

                //Getting the position of the “x” mark.

                Rectangle closeButton = new Rectangle(r.Right - 12, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Bạn có muốn đóng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        this.tabControl1.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        #endregion

        private void menuItem_ThongTinTram_Click(object sender, EventArgs e)
        {
            frm_CaiDatThongTinTram frm = new frm_CaiDatThongTinTram();
            TabCreating(tabControl1, "Cài đặt thông tin trạm", frm);
        }

        private void menuItem_CongDoanCoBan_Click(object sender, EventArgs e)
        {
            frm_CongDoanCoBan frm = new frm_CongDoanCoBan() ;
            TabCreating(tabControl1, "Công đoạn cơ bản", frm);
        }

        private void menuItem_NhanSu_Click(object sender, EventArgs e)
        {
            frm_DuLieuNhanSu frm = new frm_DuLieuNhanSu();
            TabCreating(tabControl1, "Dữ liệu nhân sự", frm);
        }
    }
}

using System;
using System.Windows.Forms;

namespace TracNghiem
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            barButtonItem_DN.PerformClick();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void barButtonItem_DN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        public void HienThiMenu()
        {
            if (Program.isGV)
            {
                toolStripStatusLabel_MaUser.Text = "Mã giảng viên: " + Program.username;
                toolStripStatusLabel_HoTen.Text = "Họ tên: " + Program.mHoten;
                toolStripStatusLabel_Nhom.Text = "Nhóm: " + Program.mGroup;
            }
            else
            {
                toolStripStatusLabel_MaUser.Text = "Mã sinh viên: " + Program.username;
                toolStripStatusLabel_HoTen.Text = "Họ tên: " + Program.mHoten;
                toolStripStatusLabel_Nhom.Text = "Nhóm: " + Program.mGroup;
            }
            //phan quyen
        }
    }
}

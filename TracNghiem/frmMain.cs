﻿using System;
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
            if (Program.isGV)
            {
                barButtonItem_TaoTaiKhoan.Enabled = true;

            }
            else{
                barButtonItem_TaoTaiKhoan.Enabled = false;

            }
        }

        private void barButtonItem_TaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKhoaGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKhoa_GiaoVien));
            if (frm != null) frm.Activate();
            else
            {
                frmKhoa_GiaoVien f = new frmKhoa_GiaoVien();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}

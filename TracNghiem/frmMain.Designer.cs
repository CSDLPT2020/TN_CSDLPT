namespace TracNghiem
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem_DN = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_TaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoaGV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_DX = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_LopSV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_BODE = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_CBT = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Thi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage_HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_DM = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_PhanQuyen = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_MaUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Nhom = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem_DN,
            this.barButtonItem1,
            this.barButtonItem3,
            this.barButtonItem_TaoTaiKhoan,
            this.btnMonHoc,
            this.btnKhoaGV,
            this.barButtonItem_DX,
            this.barButtonItem_LopSV,
            this.barButtonItem_BODE,
            this.barButtonItem_CBT,
            this.barButtonItem_Thi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_HeThong,
            this.ribbonPage_DM,
            this.ribbonPage_PhanQuyen});
            this.ribbonControl1.Size = new System.Drawing.Size(824, 158);
            // 
            // barButtonItem_DN
            // 
            this.barButtonItem_DN.Caption = "Đăng nhập";
            this.barButtonItem_DN.Id = 4;
            this.barButtonItem_DN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_DN.ImageOptions.SvgImage")));
            this.barButtonItem_DN.Name = "barButtonItem_DN";
            this.barButtonItem_DN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_DN_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem_TaoTaiKhoan
            // 
            this.barButtonItem_TaoTaiKhoan.Caption = "Tạo tài khoản";
            this.barButtonItem_TaoTaiKhoan.Enabled = false;
            this.barButtonItem_TaoTaiKhoan.Id = 10;
            this.barButtonItem_TaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_TaoTaiKhoan.ImageOptions.Image")));
            this.barButtonItem_TaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_TaoTaiKhoan.ImageOptions.LargeImage")));
            this.barButtonItem_TaoTaiKhoan.Name = "barButtonItem_TaoTaiKhoan";
            this.barButtonItem_TaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_TaoTaiKhoan_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn học";
            this.btnMonHoc.Id = 11;
            this.btnMonHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMonHoc.ImageOptions.SvgImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnKhoaGV
            // 
            this.btnKhoaGV.Caption = "Khoa-Giảng viên";
            this.btnKhoaGV.Id = 12;
            this.btnKhoaGV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhoaGV.ImageOptions.SvgImage")));
            this.btnKhoaGV.Name = "btnKhoaGV";
            this.btnKhoaGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoaGV_ItemClick);
            // 
            // barButtonItem_DX
            // 
            this.barButtonItem_DX.Caption = "Đăng xuất";
            this.barButtonItem_DX.Id = 14;
            this.barButtonItem_DX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_DX.ImageOptions.SvgImage")));
            this.barButtonItem_DX.Name = "barButtonItem_DX";
            this.barButtonItem_DX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_DX_ItemClick);
            // 
            // barButtonItem_LopSV
            // 
            this.barButtonItem_LopSV.Caption = "Lớp-Sinh viên";
            this.barButtonItem_LopSV.Id = 15;
            this.barButtonItem_LopSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_LopSV.ImageOptions.SvgImage")));
            this.barButtonItem_LopSV.Name = "barButtonItem_LopSV";
            this.barButtonItem_LopSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_LopSV_ItemClick);
            // 
            // barButtonItem_BODE
            // 
            this.barButtonItem_BODE.Caption = "Bộ đề";
            this.barButtonItem_BODE.Id = 16;
            this.barButtonItem_BODE.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_BODE.ImageOptions.SvgImage")));
            this.barButtonItem_BODE.Name = "barButtonItem_BODE";
            this.barButtonItem_BODE.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_BODE_ItemClick);
            // 
            // barButtonItem_CBT
            // 
            this.barButtonItem_CBT.Caption = "Chuẩn bị thi";
            this.barButtonItem_CBT.Id = 17;
            this.barButtonItem_CBT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_CBT.ImageOptions.SvgImage")));
            this.barButtonItem_CBT.Name = "barButtonItem_CBT";
            this.barButtonItem_CBT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_CBT_ItemClick);
            // 
            // barButtonItem_Thi
            // 
            this.barButtonItem_Thi.Caption = "Thi";
            this.barButtonItem_Thi.Id = 18;
            this.barButtonItem_Thi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_Thi.ImageOptions.SvgImage")));
            this.barButtonItem_Thi.Name = "barButtonItem_Thi";
            this.barButtonItem_Thi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Thi_ItemClick);
            // 
            // ribbonPage_HeThong
            // 
            this.ribbonPage_HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5});
            this.ribbonPage_HeThong.Name = "ribbonPage_HeThong";
            this.ribbonPage_HeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_DN);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem_DX);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage_DM
            // 
            this.ribbonPage_DM.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup6});
            this.ribbonPage_DM.Name = "ribbonPage_DM";
            this.ribbonPage_DM.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem_BODE);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Simple form";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnKhoaGV);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem_LopSV);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Subform";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem_CBT);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem_Thi);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Thi";
            // 
            // ribbonPage_PhanQuyen
            // 
            this.ribbonPage_PhanQuyen.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage_PhanQuyen.Name = "ribbonPage_PhanQuyen";
            this.ribbonPage_PhanQuyen.Text = "Phân quyền";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem_TaoTaiKhoan);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_MaUser,
            this.toolStripStatusLabel_HoTen,
            this.toolStripStatusLabel_Nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_MaUser
            // 
            this.toolStripStatusLabel_MaUser.Name = "toolStripStatusLabel_MaUser";
            this.toolStripStatusLabel_MaUser.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel_MaUser.Text = "MA USER";
            // 
            // toolStripStatusLabel_HoTen
            // 
            this.toolStripStatusLabel_HoTen.Name = "toolStripStatusLabel_HoTen";
            this.toolStripStatusLabel_HoTen.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel_HoTen.Text = "HO TEN";
            // 
            // toolStripStatusLabel_Nhom
            // 
            this.toolStripStatusLabel_Nhom.Name = "toolStripStatusLabel_Nhom";
            this.toolStripStatusLabel_Nhom.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel_Nhom.Text = "NHOM";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "TRAC NGHIEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_DM;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DN;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_PhanQuyen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_MaUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_HoTen;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Nhom;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_TaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnKhoaGV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DX;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_LopSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_BODE;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_CBT;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Thi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}


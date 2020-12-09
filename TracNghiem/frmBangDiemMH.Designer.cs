namespace TracNghiem
{
    partial class frmBangDiemMH
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
            this.comboBox_TenCN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcBangDiem = new DevExpress.XtraEditors.GroupControl();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cbbLopDK = new System.Windows.Forms.ComboBox();
            this.bdsLopDK = new System.Windows.Forms.BindingSource(this.components);
            this.dSReport = new TracNghiem.DSReport();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.cbbLanThi = new System.Windows.Forms.ComboBox();
            this.bdsLanThi = new System.Windows.Forms.BindingSource(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInBC = new System.Windows.Forms.Button();
            this.sP_BANGDIEMMHGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsBANGDIEMMH = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEMCHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_BANGDIEMMHTableAdapter = new TracNghiem.DSReportTableAdapters.SP_BANGDIEMMHTableAdapter();
            this.tableAdapterManager = new TracNghiem.DSReportTableAdapters.TableAdapterManager();
            this.sP_DSLANTHIDADANGKYTableAdapter = new TracNghiem.DSReportTableAdapters.SP_DSLANTHIDADANGKYTableAdapter();
            this.sP_DSMHDADKTableAdapter = new TracNghiem.DSReportTableAdapters.SP_DSMHDADKTableAdapter();
            this.sP_DSLOPDADKTableAdapter = new TracNghiem.DSReportTableAdapters.SP_DSLOPDADKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcBangDiem)).BeginInit();
            this.gcBangDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLanThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BANGDIEMMHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBANGDIEMMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_TenCN
            // 
            this.comboBox_TenCN.DisplayMember = "TENCN";
            this.comboBox_TenCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TenCN.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TenCN.FormattingEnabled = true;
            this.comboBox_TenCN.Location = new System.Drawing.Point(292, 36);
            this.comboBox_TenCN.Name = "comboBox_TenCN";
            this.comboBox_TenCN.Size = new System.Drawing.Size(237, 29);
            this.comboBox_TenCN.TabIndex = 3;
            this.comboBox_TenCN.ValueMember = "TENSERVER";
            this.comboBox_TenCN.SelectedIndexChanged += new System.EventHandler(this.comboBox_TenCN_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cơ Sở";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(497, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lần thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lớp";
            // 
            // gcBangDiem
            // 
            this.gcBangDiem.Controls.Add(this.btnPreview);
            this.gcBangDiem.Controls.Add(this.cbbLopDK);
            this.gcBangDiem.Controls.Add(this.cbbMonHoc);
            this.gcBangDiem.Controls.Add(this.cbbLanThi);
            this.gcBangDiem.Controls.Add(this.btnThoat);
            this.gcBangDiem.Controls.Add(this.btnInBC);
            this.gcBangDiem.Controls.Add(this.label6);
            this.gcBangDiem.Controls.Add(this.label5);
            this.gcBangDiem.Controls.Add(this.label1);
            this.gcBangDiem.Controls.Add(this.comboBox_TenCN);
            this.gcBangDiem.Controls.Add(this.label2);
            this.gcBangDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBangDiem.Location = new System.Drawing.Point(0, 0);
            this.gcBangDiem.Name = "gcBangDiem";
            this.gcBangDiem.Size = new System.Drawing.Size(730, 233);
            this.gcBangDiem.TabIndex = 2;
            this.gcBangDiem.Text = "Thông Tin";
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(125, 173);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(113, 40);
            this.btnPreview.TabIndex = 44;
            this.btnPreview.Text = "Xem trước";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cbbLopDK
            // 
            this.cbbLopDK.DataSource = this.bdsLopDK;
            this.cbbLopDK.DisplayMember = "TENLOP";
            this.cbbLopDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLopDK.FormattingEnabled = true;
            this.cbbLopDK.Location = new System.Drawing.Point(93, 103);
            this.cbbLopDK.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLopDK.Name = "cbbLopDK";
            this.cbbLopDK.Size = new System.Drawing.Size(134, 21);
            this.cbbLopDK.TabIndex = 32;
            this.cbbLopDK.ValueMember = "MALOP";
            this.cbbLopDK.SelectedIndexChanged += new System.EventHandler(this.cbbLopDK_SelectedIndexChanged);
            // 
            // bdsLopDK
            // 
            this.bdsLopDK.DataMember = "SP_DSLOPDADK";
            this.bdsLopDK.DataSource = this.dSReport;
            // 
            // dSReport
            // 
            this.dSReport.DataSetName = "DSReport";
            this.dSReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.DataSource = this.bdsMonHoc;
            this.cbbMonHoc.DisplayMember = "TENMH";
            this.cbbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(336, 106);
            this.cbbMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(134, 21);
            this.cbbMonHoc.TabIndex = 1;
            this.cbbMonHoc.ValueMember = "MAMH";
            this.cbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMonHoc_SelectedIndexChanged);
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "SP_DSMHDADK";
            this.bdsMonHoc.DataSource = this.dSReport;
            // 
            // cbbLanThi
            // 
            this.cbbLanThi.DataSource = this.bdsLanThi;
            this.cbbLanThi.DisplayMember = "LAN";
            this.cbbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLanThi.FormattingEnabled = true;
            this.cbbLanThi.Location = new System.Drawing.Point(571, 107);
            this.cbbLanThi.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLanThi.Name = "cbbLanThi";
            this.cbbLanThi.Size = new System.Drawing.Size(134, 21);
            this.cbbLanThi.TabIndex = 30;
            this.cbbLanThi.ValueMember = "LAN";
            // 
            // bdsLanThi
            // 
            this.bdsLanThi.DataMember = "SP_DSLANTHIDADANGKY";
            this.bdsLanThi.DataSource = this.dSReport;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(473, 173);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 40);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInBC
            // 
            this.btnInBC.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC.Location = new System.Drawing.Point(299, 173);
            this.btnInBC.Margin = new System.Windows.Forms.Padding(2);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(113, 40);
            this.btnInBC.TabIndex = 28;
            this.btnInBC.Text = "In Báo Cáo";
            this.btnInBC.UseVisualStyleBackColor = true;
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // sP_BANGDIEMMHGridControl
            // 
            this.sP_BANGDIEMMHGridControl.DataSource = this.bdsBANGDIEMMH;
            this.sP_BANGDIEMMHGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_BANGDIEMMHGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.sP_BANGDIEMMHGridControl.Location = new System.Drawing.Point(0, 233);
            this.sP_BANGDIEMMHGridControl.MainView = this.gridView1;
            this.sP_BANGDIEMMHGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.sP_BANGDIEMMHGridControl.Name = "sP_BANGDIEMMHGridControl";
            this.sP_BANGDIEMMHGridControl.Size = new System.Drawing.Size(730, 248);
            this.sP_BANGDIEMMHGridControl.TabIndex = 4;
            this.sP_BANGDIEMMHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsBANGDIEMMH
            // 
            this.bdsBANGDIEMMH.DataMember = "SP_BANGDIEMMH";
            this.bdsBANGDIEMMH.DataSource = this.dSReport;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colDIEM,
            this.colDIEMCHU});
            this.gridView1.DetailHeight = 227;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.sP_BANGDIEMMHGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã Sinh Viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIEM
            // 
            this.colDIEM.Caption = "Điểm";
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 3;
            // 
            // colDIEMCHU
            // 
            this.colDIEMCHU.Caption = "Điểm Chữ";
            this.colDIEMCHU.FieldName = "DIEMCHU";
            this.colDIEMCHU.Name = "colDIEMCHU";
            this.colDIEMCHU.Visible = true;
            this.colDIEMCHU.VisibleIndex = 4;
            // 
            // sP_BANGDIEMMHTableAdapter
            // 
            this.sP_BANGDIEMMHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DSReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_DSLANTHIDADANGKYTableAdapter
            // 
            this.sP_DSLANTHIDADANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // sP_DSMHDADKTableAdapter
            // 
            this.sP_DSMHDADKTableAdapter.ClearBeforeFill = true;
            // 
            // sP_DSLOPDADKTableAdapter
            // 
            this.sP_DSLOPDADKTableAdapter.ClearBeforeFill = true;
            // 
            // frmBangDiemMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 481);
            this.Controls.Add(this.sP_BANGDIEMMHGridControl);
            this.Controls.Add(this.gcBangDiem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBangDiemMH";
            this.Text = "Bảng Điểm Môn Học";
            this.Load += new System.EventHandler(this.frmBangDiemMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcBangDiem)).EndInit();
            this.gcBangDiem.ResumeLayout(false);
            this.gcBangDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLanThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BANGDIEMMHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBANGDIEMMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_TenCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl gcBangDiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnInBC;
        //private DSReportTableAdapters.SP_BANGDIEMMHTableAdapter sP_BANGDIEMMHTableAdapter;
        //private DSReportTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbLanThi;
        //private DSReportTableAdapters.SP_DSMHDKTableAdapter sP_DSMHDKTableAdapter;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        //private DSReportTableAdapters.SP_DSLOPDKTableAdapter sP_DSLOPDKTableAdapter;
        private System.Windows.Forms.ComboBox cbbLopDK;
        //private DSReportTableAdapters.SP_DSLANTHIDKTableAdapter sP_DSLANTHIDKTableAdapter;
        private System.Windows.Forms.Button btnPreview;
        private DevExpress.XtraGrid.GridControl sP_BANGDIEMMHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEMCHU;
        private DSReport dSReport;
        private System.Windows.Forms.BindingSource bdsBANGDIEMMH;
        private DSReportTableAdapters.SP_BANGDIEMMHTableAdapter sP_BANGDIEMMHTableAdapter;
        private DSReportTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsLanThi;
        private DSReportTableAdapters.SP_DSLANTHIDADANGKYTableAdapter sP_DSLANTHIDADANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DSReportTableAdapters.SP_DSMHDADKTableAdapter sP_DSMHDADKTableAdapter;
        private System.Windows.Forms.BindingSource bdsLopDK;
        private DSReportTableAdapters.SP_DSLOPDADKTableAdapter sP_DSLOPDADKTableAdapter;
    }
}
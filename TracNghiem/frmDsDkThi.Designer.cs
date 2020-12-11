namespace TracNghiem
{
    partial class frmDsDkThi
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInBC = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCoso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bdsDSDKTHI = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DSDANGKYTHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dSReport = new TracNghiem.DSReport();
            this.sP_DSDANGKYTHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DSDANGKYTHITableAdapter = new TracNghiem.DSReportTableAdapters.SP_DSDANGKYTHITableAdapter();
            this.tableAdapterManager = new TracNghiem.DSReportTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSDKTHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSDANGKYTHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSDANGKYTHIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnInBC);
            this.groupControl1.Controls.Add(this.btnPreview);
            this.groupControl1.Controls.Add(this.dateFrom);
            this.groupControl1.Controls.Add(this.dateTo);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cbbCoso);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(957, 211);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(595, 138);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 38);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInBC
            // 
            this.btnInBC.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC.Location = new System.Drawing.Point(419, 138);
            this.btnInBC.Margin = new System.Windows.Forms.Padding(2);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(113, 38);
            this.btnInBC.TabIndex = 25;
            this.btnInBC.Text = "In Báo Cáo";
            this.btnInBC.UseVisualStyleBackColor = true;
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(239, 138);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(113, 38);
            this.btnPreview.TabIndex = 24;
            this.btnPreview.Text = "Xem trước";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.EditValue = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.dateFrom.Location = new System.Drawing.Point(605, 57);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Properties.Appearance.Options.UseFont = true;
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Size = new System.Drawing.Size(103, 20);
            this.dateFrom.TabIndex = 23;
            // 
            // dateTo
            // 
            this.dateTo.EditValue = new System.DateTime(2020, 12, 11, 13, 28, 34, 0);
            this.dateTo.Location = new System.Drawing.Point(834, 60);
            this.dateTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Properties.Appearance.Options.UseFont = true;
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTo.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateTo.Size = new System.Drawing.Size(103, 20);
            this.dateTo.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(757, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Từ ngày";
            // 
            // cbbCoso
            // 
            this.cbbCoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoso.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCoso.FormattingEnabled = true;
            this.cbbCoso.Location = new System.Drawing.Point(239, 51);
            this.cbbCoso.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbCoso.Name = "cbbCoso";
            this.cbbCoso.Size = new System.Drawing.Size(217, 31);
            this.cbbCoso.Sorted = true;
            this.cbbCoso.TabIndex = 15;
            this.cbbCoso.SelectedIndexChanged += new System.EventHandler(this.cbbCoso_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cơ sở";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bdsDSDKTHI
            // 
            this.bdsDSDKTHI.DataMember = "SP_DSDANGKYTHI";
            // 
            // sP_DSDANGKYTHIGridControl
            // 
            this.sP_DSDANGKYTHIGridControl.DataSource = this.bdsDSDKTHI;
            this.sP_DSDANGKYTHIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_DSDANGKYTHIGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.sP_DSDANGKYTHIGridControl.Location = new System.Drawing.Point(0, 211);
            this.sP_DSDANGKYTHIGridControl.MainView = this.gridView1;
            this.sP_DSDANGKYTHIGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.sP_DSDANGKYTHIGridControl.Name = "sP_DSDANGKYTHIGridControl";
            this.sP_DSDANGKYTHIGridControl.Size = new System.Drawing.Size(957, 226);
            this.sP_DSDANGKYTHIGridControl.TabIndex = 3;
            this.sP_DSDANGKYTHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENLOP,
            this.colTENMH,
            this.colHOTEN,
            this.colSOCAUTHI,
            this.colNGAYTHI,
            this.colDATHI});
            this.gridView1.DetailHeight = 227;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.sP_DSDANGKYTHIGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "Tên Lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên Môn Học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ Tên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 2;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.Caption = "Số Câu Thi";
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 3;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.Caption = "Ngày Thi";
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            // 
            // colDATHI
            // 
            this.colDATHI.Caption = "Đã Thi";
            this.colDATHI.FieldName = "DATHI";
            this.colDATHI.Name = "colDATHI";
            this.colDATHI.Visible = true;
            this.colDATHI.VisibleIndex = 5;
            // 
            // dSReport
            // 
            this.dSReport.DataSetName = "DSReport";
            this.dSReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_DSDANGKYTHIBindingSource
            // 
            this.sP_DSDANGKYTHIBindingSource.DataMember = "SP_DSDANGKYTHI";
            this.sP_DSDANGKYTHIBindingSource.DataSource = this.dSReport;
            // 
            // sP_DSDANGKYTHITableAdapter
            // 
            this.sP_DSDANGKYTHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DSReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDsDkThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 437);
            this.Controls.Add(this.sP_DSDANGKYTHIGridControl);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDsDkThi";
            this.Text = "Danh Sách Đăng Ký Thi";
            this.Load += new System.EventHandler(this.frmDsDkThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSDKTHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSDANGKYTHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSDANGKYTHIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnPreview;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private DevExpress.XtraEditors.DateEdit dateTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCoso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bdsDSDKTHI;
        private DevExpress.XtraGrid.GridControl sP_DSDANGKYTHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colDATHI;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnInBC;
        private DSReport dSReport;
        private System.Windows.Forms.BindingSource sP_DSDANGKYTHIBindingSource;
        private DSReportTableAdapters.SP_DSDANGKYTHITableAdapter sP_DSDANGKYTHITableAdapter;
        private DSReportTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
namespace TracNghiem
{
    partial class frmKQTHI
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
            this.tENMHLabel = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cbbLThi = new System.Windows.Forms.ComboBox();
            this.bdsLthiMSV = new System.Windows.Forms.BindingSource(this.components);
            this.dSReport = new TracNghiem.DSReport();
            this.cbbMHSV = new System.Windows.Forms.ComboBox();
            this.bdsMHocMSV = new System.Windows.Forms.BindingSource(this.components);
            this.labelNgayThi = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelLop = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInBC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbLanThi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTenMonhoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bdsINBAITHI = new System.Windows.Forms.BindingSource(this.components);
            this.sP_INBAITHITableAdapter = new TracNghiem.DSReportTableAdapters.SP_INBAITHITableAdapter();
            this.tableAdapterManager = new TracNghiem.DSReportTableAdapters.TableAdapterManager();
            this.sP_INBAITHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTTTRONGBAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTTTRONGDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN_DA_CHON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_MHtheoMASVTableAdapter = new TracNghiem.DSReportTableAdapters.SP_MHtheoMASVTableAdapter();
            this.sP_LThitheoMASVMAMHTableAdapter = new TracNghiem.DSReportTableAdapters.SP_LThitheoMASVMAMHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLthiMSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMHocMSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsINBAITHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INBAITHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            this.tENMHLabel.AutoSize = true;
            this.tENMHLabel.Location = new System.Drawing.Point(123, 112);
            this.tENMHLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tENMHLabel.Name = "tENMHLabel";
            this.tENMHLabel.Size = new System.Drawing.Size(0, 13);
            this.tENMHLabel.TabIndex = 39;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnPreview);
            this.groupControl1.Controls.Add(this.cbbLThi);
            this.groupControl1.Controls.Add(this.tENMHLabel);
            this.groupControl1.Controls.Add(this.cbbMHSV);
            this.groupControl1.Controls.Add(this.labelNgayThi);
            this.groupControl1.Controls.Add(this.labelHoTen);
            this.groupControl1.Controls.Add(this.labelLop);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnInBC);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cbbLanThi);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.cbbTenMonhoc);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(913, 190);
            this.groupControl1.TabIndex = 15;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(352, 116);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(113, 38);
            this.btnPreview.TabIndex = 42;
            this.btnPreview.Text = "Xem trước";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cbbLThi
            // 
            this.cbbLThi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLthiMSV, "LAN", true));
            this.cbbLThi.DataSource = this.bdsLthiMSV;
            this.cbbLThi.DisplayMember = "LAN";
            this.cbbLThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLThi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLThi.FormattingEnabled = true;
            this.cbbLThi.Location = new System.Drawing.Point(686, 40);
            this.cbbLThi.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLThi.Name = "cbbLThi";
            this.cbbLThi.Size = new System.Drawing.Size(117, 27);
            this.cbbLThi.TabIndex = 41;
            this.cbbLThi.ValueMember = "LAN";
            // 
            // bdsLthiMSV
            // 
            this.bdsLthiMSV.DataMember = "SP_LThitheoMASVMAMH";
            this.bdsLthiMSV.DataSource = this.dSReport;
            // 
            // dSReport
            // 
            this.dSReport.DataSetName = "DSReport";
            this.dSReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbMHSV
            // 
            this.cbbMHSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMHocMSV, "TENMH", true));
            this.cbbMHSV.DataSource = this.bdsMHocMSV;
            this.cbbMHSV.DisplayMember = "TENMH";
            this.cbbMHSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMHSV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMHSV.FormattingEnabled = true;
            this.cbbMHSV.Location = new System.Drawing.Point(431, 36);
            this.cbbMHSV.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMHSV.Name = "cbbMHSV";
            this.cbbMHSV.Size = new System.Drawing.Size(117, 27);
            this.cbbMHSV.TabIndex = 40;
            this.cbbMHSV.ValueMember = "MAMH";
            // 
            // bdsMHocMSV
            // 
            this.bdsMHocMSV.DataMember = "SP_MHtheoMASV";
            this.bdsMHocMSV.DataSource = this.dSReport;
            // 
            // labelNgayThi
            // 
            this.labelNgayThi.AutoSize = true;
            this.labelNgayThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayThi.Location = new System.Drawing.Point(173, 126);
            this.labelNgayThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNgayThi.Name = "labelNgayThi";
            this.labelNgayThi.Size = new System.Drawing.Size(87, 14);
            this.labelNgayThi.TabIndex = 39;
            this.labelNgayThi.Text = "dd/MM/yyyy";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.Location = new System.Drawing.Point(173, 45);
            this.labelHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(74, 14);
            this.labelHoTen.TabIndex = 37;
            this.labelHoTen.Text = "labelHoTen";
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLop.Location = new System.Drawing.Point(173, 85);
            this.labelLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(58, 14);
            this.labelLop.TabIndex = 36;
            this.labelLop.Text = "labelLop";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ngày Thi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 33;
            this.label7.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 14);
            this.label2.TabIndex = 32;
            this.label2.Text = "Lớp:";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(642, 116);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 38);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInBC
            // 
            this.btnInBC.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC.Location = new System.Drawing.Point(501, 114);
            this.btnInBC.Margin = new System.Windows.Forms.Padding(2);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(113, 40);
            this.btnInBC.TabIndex = 30;
            this.btnInBC.Text = "In Báo Cáo";
            this.btnInBC.UseVisualStyleBackColor = true;
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(625, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lần thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Môn học";
            // 
            // cbbLanThi
            // 
            this.cbbLanThi.FormattingEnabled = true;
            this.cbbLanThi.Location = new System.Drawing.Point(2929, 137);
            this.cbbLanThi.Name = "cbbLanThi";
            this.cbbLanThi.Size = new System.Drawing.Size(179, 21);
            this.cbbLanThi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2769, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lần thi";
            // 
            // cbbTenMonhoc
            // 
            this.cbbTenMonhoc.FormattingEnabled = true;
            this.cbbTenMonhoc.Location = new System.Drawing.Point(2052, 109);
            this.cbbTenMonhoc.Name = "cbbTenMonhoc";
            this.cbbTenMonhoc.Size = new System.Drawing.Size(463, 21);
            this.cbbTenMonhoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1831, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên mô học";
            // 
            // bdsINBAITHI
            // 
            this.bdsINBAITHI.DataMember = "SP_INBAITHI";
            this.bdsINBAITHI.DataSource = this.dSReport;
            // 
            // sP_INBAITHITableAdapter
            // 
            this.sP_INBAITHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DSReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_INBAITHIGridControl
            // 
            this.sP_INBAITHIGridControl.DataSource = this.bdsINBAITHI;
            this.sP_INBAITHIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_INBAITHIGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.sP_INBAITHIGridControl.Location = new System.Drawing.Point(0, 190);
            this.sP_INBAITHIGridControl.MainView = this.gridView1;
            this.sP_INBAITHIGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.sP_INBAITHIGridControl.Name = "sP_INBAITHIGridControl";
            this.sP_INBAITHIGridControl.Size = new System.Drawing.Size(913, 218);
            this.sP_INBAITHIGridControl.TabIndex = 17;
            this.sP_INBAITHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTTTRONGBAI,
            this.colSTTTRONGDE,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colDAP_AN_DA_CHON});
            this.gridView1.DetailHeight = 227;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.sP_INBAITHIGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSTTTRONGBAI
            // 
            this.colSTTTRONGBAI.Caption = "STT";
            this.colSTTTRONGBAI.FieldName = "STTTRONGBAI";
            this.colSTTTRONGBAI.Name = "colSTTTRONGBAI";
            this.colSTTTRONGBAI.Visible = true;
            this.colSTTTRONGBAI.VisibleIndex = 0;
            // 
            // colSTTTRONGDE
            // 
            this.colSTTTRONGDE.Caption = "Câu trong bộ đề";
            this.colSTTTRONGDE.FieldName = "STTTRONGDE";
            this.colSTTTRONGDE.Name = "colSTTTRONGDE";
            this.colSTTTRONGDE.Visible = true;
            this.colSTTTRONGDE.VisibleIndex = 1;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.Caption = "Nội dung câu hỏi";
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 2;
            // 
            // colA
            // 
            this.colA.Caption = "A";
            this.colA.FieldName = "A";
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 3;
            // 
            // colB
            // 
            this.colB.Caption = "B";
            this.colB.FieldName = "B";
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 4;
            // 
            // colC
            // 
            this.colC.Caption = "C";
            this.colC.FieldName = "C";
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 5;
            // 
            // colD
            // 
            this.colD.Caption = "D";
            this.colD.FieldName = "D";
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 6;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.Caption = "Đáp án";
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 7;
            // 
            // colDAP_AN_DA_CHON
            // 
            this.colDAP_AN_DA_CHON.Caption = "Đáp án đã chọn";
            this.colDAP_AN_DA_CHON.FieldName = "DAP_AN_DA_CHON";
            this.colDAP_AN_DA_CHON.Name = "colDAP_AN_DA_CHON";
            this.colDAP_AN_DA_CHON.Visible = true;
            this.colDAP_AN_DA_CHON.VisibleIndex = 8;
            // 
            // sP_MHtheoMASVTableAdapter
            // 
            this.sP_MHtheoMASVTableAdapter.ClearBeforeFill = true;
            // 
            // sP_LThitheoMASVMAMHTableAdapter
            // 
            this.sP_LThitheoMASVMAMHTableAdapter.ClearBeforeFill = true;
            // 
            // frmKQTHI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(913, 408);
            this.Controls.Add(this.sP_INBAITHIGridControl);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKQTHI";
            this.Text = "Kết Quả Bài Thi";
            this.Load += new System.EventHandler(this.frmKQTHI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLthiMSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMHocMSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsINBAITHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INBAITHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbLanThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTenMonhoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInBC;
        private System.Windows.Forms.Button btnThoat;
        private DSReport dSReport;
        private System.Windows.Forms.BindingSource bdsINBAITHI;
        private DSReportTableAdapters.SP_INBAITHITableAdapter sP_INBAITHITableAdapter;
        private DSReportTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_INBAITHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colSTTTRONGBAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSTTTRONGDE;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN_DA_CHON;
        private System.Windows.Forms.Label labelNgayThi;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bdsMHocMSV;
        private DSReportTableAdapters.SP_MHtheoMASVTableAdapter sP_MHtheoMASVTableAdapter;
        private System.Windows.Forms.ComboBox cbbMHSV;
        private System.Windows.Forms.BindingSource bdsLthiMSV;
        private DSReportTableAdapters.SP_LThitheoMASVMAMHTableAdapter sP_LThitheoMASVMAMHTableAdapter;
        private System.Windows.Forms.ComboBox cbbLThi;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label tENMHLabel;
    }
}
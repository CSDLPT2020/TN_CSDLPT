namespace TracNghiem
{
    partial class frmThi
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
            System.Windows.Forms.Label mAMHLabel;
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Timer = new System.Windows.Forms.Label();
            this.label_TENLOP = new System.Windows.Forms.Label();
            this.label_MALOP = new System.Windows.Forms.Label();
            this.label_TENSV = new System.Windows.Forms.Label();
            this.label_MASV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label_SCT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_TD = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_NOPBAI = new System.Windows.Forms.Button();
            this.button_Find = new System.Windows.Forms.Button();
            this.spinEdit_LAN = new DevExpress.XtraEditors.SpinEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.dateEdit_NT = new DevExpress.XtraEditors.DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBox_MAMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new TracNghiem.DS();
            this.label6 = new System.Windows.Forms.Label();
            this.mONHOCTableAdapter = new TracNghiem.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TracNghiem.DSTableAdapters.TableAdapterManager();
            this.flowLayoutPanel_THI = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_LAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(34, 69);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(71, 19);
            mAMHLabel.TabIndex = 9;
            mAMHLabel.Text = "Môn học: ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label_Timer);
            this.groupControl1.Controls.Add(this.label_TENLOP);
            this.groupControl1.Controls.Add(this.label_MALOP);
            this.groupControl1.Controls.Add(this.label_TENSV);
            this.groupControl1.Controls.Add(this.label_MASV);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1332, 120);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(973, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 27);
            this.label11.TabIndex = 10;
            this.label11.Text = "Thời gian: ";
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timer.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Timer.Location = new System.Drawing.Point(1114, 52);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(98, 40);
            this.label_Timer.TabIndex = 9;
            this.label_Timer.Text = "00:00";
            // 
            // label_TENLOP
            // 
            this.label_TENLOP.AutoSize = true;
            this.label_TENLOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TENLOP.Location = new System.Drawing.Point(652, 89);
            this.label_TENLOP.Name = "label_TENLOP";
            this.label_TENLOP.Size = new System.Drawing.Size(45, 19);
            this.label_TENLOP.TabIndex = 8;
            this.label_TENLOP.Text = "label9";
            // 
            // label_MALOP
            // 
            this.label_MALOP.AutoSize = true;
            this.label_MALOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MALOP.Location = new System.Drawing.Point(652, 52);
            this.label_MALOP.Name = "label_MALOP";
            this.label_MALOP.Size = new System.Drawing.Size(45, 19);
            this.label_MALOP.TabIndex = 7;
            this.label_MALOP.Text = "label8";
            // 
            // label_TENSV
            // 
            this.label_TENSV.AutoSize = true;
            this.label_TENSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TENSV.Location = new System.Drawing.Point(281, 88);
            this.label_TENSV.Name = "label_TENSV";
            this.label_TENSV.Size = new System.Drawing.Size(45, 19);
            this.label_TENSV.TabIndex = 6;
            this.label_TENSV.Text = "label7";
            // 
            // label_MASV
            // 
            this.label_MASV.AutoSize = true;
            this.label_MASV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MASV.Location = new System.Drawing.Point(281, 52);
            this.label_MASV.Name = "label_MASV";
            this.label_MASV.Size = new System.Drawing.Size(45, 19);
            this.label_MASV.TabIndex = 5;
            this.label_MASV.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên lớp: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(584, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã lớp: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên SV: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SV: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label_SCT);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Controls.Add(this.label_TD);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.button_NOPBAI);
            this.groupControl2.Controls.Add(this.button_Find);
            this.groupControl2.Controls.Add(this.spinEdit_LAN);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.dateEdit_NT);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(mAMHLabel);
            this.groupControl2.Controls.Add(this.ComboBox_MAMH);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 120);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1332, 124);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // label_SCT
            // 
            this.label_SCT.AutoSize = true;
            this.label_SCT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SCT.Location = new System.Drawing.Point(1042, 68);
            this.label_SCT.Name = "label_SCT";
            this.label_SCT.Size = new System.Drawing.Size(17, 19);
            this.label_SCT.TabIndex = 20;
            this.label_SCT.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(957, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Số câu thi";
            // 
            // label_TD
            // 
            this.label_TD.AutoSize = true;
            this.label_TD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TD.Location = new System.Drawing.Point(891, 69);
            this.label_TD.Name = "label_TD";
            this.label_TD.Size = new System.Drawing.Size(29, 19);
            this.label_TD.TabIndex = 18;
            this.label_TD.Text = "TD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(819, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Trình độ: ";
            // 
            // button_NOPBAI
            // 
            this.button_NOPBAI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NOPBAI.Location = new System.Drawing.Point(1233, 63);
            this.button_NOPBAI.Name = "button_NOPBAI";
            this.button_NOPBAI.Size = new System.Drawing.Size(95, 28);
            this.button_NOPBAI.TabIndex = 16;
            this.button_NOPBAI.Text = "Bắt đầu thi";
            this.button_NOPBAI.UseVisualStyleBackColor = true;
            this.button_NOPBAI.Click += new System.EventHandler(this.button_NOPBAI_Click);
            // 
            // button_Find
            // 
            this.button_Find.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Find.Location = new System.Drawing.Point(1121, 64);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(75, 28);
            this.button_Find.TabIndex = 15;
            this.button_Find.Text = "Find";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // spinEdit_LAN
            // 
            this.spinEdit_LAN.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit_LAN.Location = new System.Drawing.Point(717, 65);
            this.spinEdit_LAN.Name = "spinEdit_LAN";
            this.spinEdit_LAN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit_LAN.Properties.Appearance.Options.UseFont = true;
            this.spinEdit_LAN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_LAN.Properties.IsFloatValue = false;
            this.spinEdit_LAN.Properties.Mask.EditMask = "N00";
            this.spinEdit_LAN.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinEdit_LAN.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit_LAN.Size = new System.Drawing.Size(62, 26);
            this.spinEdit_LAN.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(662, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Lần: ";
            // 
            // dateEdit_NT
            // 
            this.dateEdit_NT.EditValue = null;
            this.dateEdit_NT.Location = new System.Drawing.Point(474, 66);
            this.dateEdit_NT.Name = "dateEdit_NT";
            this.dateEdit_NT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_NT.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_NT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NT.Size = new System.Drawing.Size(156, 26);
            this.dateEdit_NT.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày thi: ";
            // 
            // ComboBox_MAMH
            // 
            this.ComboBox_MAMH.DataSource = this.bdsMH;
            this.ComboBox_MAMH.DisplayMember = "TENMH";
            this.ComboBox_MAMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_MAMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_MAMH.FormattingEnabled = true;
            this.ComboBox_MAMH.Location = new System.Drawing.Point(111, 66);
            this.ComboBox_MAMH.Name = "ComboBox_MAMH";
            this.ComboBox_MAMH.Size = new System.Drawing.Size(229, 27);
            this.ComboBox_MAMH.TabIndex = 10;
            this.ComboBox_MAMH.ValueMember = "MAMH";
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Thông tin thi";
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIETBAITHITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // flowLayoutPanel_THI
            // 
            this.flowLayoutPanel_THI.AutoScroll = true;
            this.flowLayoutPanel_THI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_THI.ForeColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel_THI.Location = new System.Drawing.Point(0, 244);
            this.flowLayoutPanel_THI.Name = "flowLayoutPanel_THI";
            this.flowLayoutPanel_THI.Size = new System.Drawing.Size(1332, 344);
            this.flowLayoutPanel_THI.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 588);
            this.Controls.Add(this.flowLayoutPanel_THI);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThi";
            this.Text = "frmThi";
            this.Load += new System.EventHandler(this.frmThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_LAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TENLOP;
        private System.Windows.Forms.Label label_MALOP;
        private System.Windows.Forms.Label label_TENSV;
        private System.Windows.Forms.Label label_MASV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label6;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox ComboBox_MAMH;
        private DevExpress.XtraEditors.SpinEdit spinEdit_LAN;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.DateEdit dateEdit_NT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_THI;
        private System.Windows.Forms.Button button_NOPBAI;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_SCT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_TD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Label label11;
    }
}
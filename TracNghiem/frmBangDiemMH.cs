using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracNghiem
{
    public partial class frmBangDiemMH : Form
    {
        public static String macn = "";
        public frmBangDiemMH()
        {
            InitializeComponent();
        }

        private void frmBangDiemMH_Load(object sender, EventArgs e)
        {
            this.sP_DSLOPDADKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DSLOPDADKTableAdapter.Fill(this.dSReport.SP_DSLOPDADK);
            this.ControlBox = false;
            dSReport.EnforceConstraints = false;
            // Lấy kết danh sách phân mảnh đổ vào combobox
            macn = Program.GetMaCS();
            comboBox_TenCN.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            comboBox_TenCN.DisplayMember = "TENCN";
            comboBox_TenCN.ValueMember = "TENSERVER";
            comboBox_TenCN.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "Truong")
            {
                comboBox_TenCN.Enabled = true;
                comboBox_TenCN.SelectedIndex = 1;
            }
            else if (Program.mGroup == "Coso")
            {
                comboBox_TenCN.Enabled = false;
                comboBox_TenCN.SelectedIndex = Program.mChinhanh;
            }


        }

        private void comboBox_TenCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TenCN.SelectedIndex == -1) return;
            if (comboBox_TenCN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = comboBox_TenCN.SelectedValue.ToString();

            if (comboBox_TenCN.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.sP_DSLOPDADKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DSLOPDADKTableAdapter.Fill(this.dSReport.SP_DSLOPDADK);
                this.sP_DSMHDADKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DSMHDADKTableAdapter.Fill(this.dSReport.SP_DSMHDADK, cbbLopDK.SelectedValue.ToString());
                this.sP_DSLANTHIDADANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DSLANTHIDADANGKYTableAdapter.Fill(this.dSReport.SP_DSLANTHIDADANGKY, cbbMonHoc.SelectedValue.ToString(), cbbLopDK.SelectedValue.ToString());

                macn = Program.GetMaCS();
            }
        }

        private void cbbLopDK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLopDK.SelectedIndex == -1) return;

            if (cbbLopDK.SelectedValue != null)
            {

                this.sP_DSMHDADKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DSMHDADKTableAdapter.Fill(this.dSReport.SP_DSMHDADK, cbbLopDK.SelectedValue.ToString());
                this.sP_DSLANTHIDADANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DSLANTHIDADANGKYTableAdapter.Fill(this.dSReport.SP_DSLANTHIDADANGKY, cbbMonHoc.SelectedValue.ToString(), cbbLopDK.SelectedValue.ToString());
            }
        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMonHoc.SelectedValue != null)
            {
                this.sP_DSLANTHIDADANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DSLANTHIDADANGKYTableAdapter.Fill(this.dSReport.SP_DSLANTHIDADANGKY, cbbMonHoc.SelectedValue.ToString(), cbbLopDK.SelectedValue.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {

            XrpBANGDIEM rpBD = new XrpBANGDIEM(cbbLopDK.SelectedValue.ToString(), cbbMonHoc.SelectedValue.ToString(), short.Parse(cbbLanThi.SelectedValue.ToString()));
            rpBD.lbLop.Text = cbbLopDK.Text;
            rpBD.lbMH.Text = cbbMonHoc.Text;
            rpBD.lbLanThi.Text = cbbLanThi.Text;
            ReportPrintTool report = new ReportPrintTool(rpBD);
            report.ShowPreviewDialog();

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.sP_BANGDIEMMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_BANGDIEMMHTableAdapter.Fill(this.dSReport.SP_BANGDIEMMH, cbbLopDK.SelectedValue.ToString(), cbbMonHoc.SelectedValue.ToString(), short.Parse(cbbLanThi.SelectedValue.ToString()));
            if (bdsBANGDIEMMH.Count == 0)
            {
                MessageBox.Show("Chưa có Bảng điểm!", "Thông Báo", MessageBoxButtons.OK);
            }
        }
    }
}

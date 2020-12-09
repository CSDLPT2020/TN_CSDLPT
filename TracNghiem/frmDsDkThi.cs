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
    public partial class frmDsDkThi : Form
    {
        // public static Boolean checkVitriCS = false;
        public static String macn = "";
        public frmDsDkThi()
        {
            InitializeComponent();
        }



        private void frmDsDkThi_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            dSReport.EnforceConstraints = false;
            // Lấy kết danh sách phân mảnh đổ vào combobox
            macn = Program.GetMaCS();
            cbbCoso.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cbbCoso.DisplayMember = "TENCN";
            cbbCoso.ValueMember = "TENSERVER";
            cbbCoso.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "Truong")
            {
                cbbCoso.Enabled = true;
                cbbCoso.SelectedIndex = 1;
            }
            else if (Program.mGroup == "Coso")
            {
                cbbCoso.Enabled = false;
                cbbCoso.SelectedIndex = Program.mChinhanh;
            }
        }

        private void cbbCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCoso.SelectedIndex == -1) return;
            if (cbbCoso.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbbCoso.SelectedValue.ToString();

            if (cbbCoso.SelectedIndex != Program.mChinhanh)
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
                macn = Program.GetMaCS();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (dateFrom.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (dateTo.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var FromDate = dateFrom.DateTime;
            var ToDate = dateTo.DateTime;
            int compare = DateTime.Compare(FromDate, ToDate);
            if (compare > 0)
            {
                // ngày bắt đầu không thể lớn hơn ngày kết thúc
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc");
                return;
            }
            else
            {
                this.sP_DSDANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DSDANGKYTHITableAdapter.Fill(this.dSReport.SP_DSDANGKYTHI, FromDate, ToDate);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {
            if (dateFrom.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (dateTo.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var FromDate = dateFrom.DateTime;
            var ToDate = dateTo.DateTime;
            /*XrpDSDKTHI xrp = new XrpDSDKTHI(FromDate, ToDate);
            int compare = DateTime.Compare(FromDate, ToDate);
            if (compare > 0)
            {
                // ngày bắt đầu không thể lớn hơn ngày kết thúc
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc");
                return;
            }
            else
            {
                //Console.WriteLine("ngay" + ToDate.ToString("dd/MM/yyyy"));
                xrp.lbCoso.Text = (cbbCoso.SelectedIndex + 1).ToString();
                xrp.lbDateFrom.Text = FromDate.ToString("dd/MM/yyyy");
                xrp.lbDateTo.Text = ToDate.ToString("dd/MM/yyyy");

                ReportPrintTool report = new ReportPrintTool(xrp);
                report.ShowPreviewDialog();
            }*/
        }
    }
}

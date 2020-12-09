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
    public partial class frmKQTHI : Form
    {
        private String tenLop = null;
        private String ngay = null;

        public frmKQTHI()
        {
            InitializeComponent();
        }

        private void frmKQTHI_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            String sql = "SELECT LOP.TENLOP FROM SINHVIEN SV inner join LOP ON(SV.MASV='" + Program.username + "' AND SV.MALOP = lOP.MALOP)";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            // String mLop = Program.myReader.GetString(0);
            tenLop = Program.myReader.GetString(0);
            labelLop.Text = tenLop;
            Program.myReader.Close();
            labelHoTen.Text = Program.mHoten;

            try
            {

                this.sP_MHtheoMASVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_MHtheoMASVTableAdapter.Fill(this.dSReport.SP_MHtheoMASV, Program.username);
                if (bdsMHocMSV.Count > 0)
                {
                    cbbMHSV.SelectedIndex = 0;
                    this.sP_LThitheoMASVMAMHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_LThitheoMASVMAMHTableAdapter.Fill(this.dSReport.SP_LThitheoMASVMAMH, Program.username, cbbMHSV.SelectedValue.ToString());
                    if (bdsLthiMSV.Count > 0)
                    {
                        cbbLThi.SelectedIndex = 0;
                        String sqlNgayThi = "SELECT BANGDIEM.NGAYTHI FROM BANGDIEM WHERE BANGDIEM.MASV = '" + Program.username + "' AND BANGDIEM.MAMH = '" + cbbMHSV.SelectedValue.ToString() + "'  AND BANGDIEM.LAN = '" + cbbLThi.SelectedValue.ToString() + "' ";
                        Program.myReader = Program.ExecSqlDataReader(sqlNgayThi);
                        if (Program.myReader == null) return;
                        Program.myReader.Read();
                        //  String ngay = Program.myReader.GetDateTime(0).ToString();
                        ngay = Program.myReader.GetDateTime(0).ToString("dd/MM/yyyy");
                        //String[] arrNgay = ngay.Split(' ');
                        // ngayThi = arrNgay[0];
                        labelNgayThi.Text = ngay.ToString();
                        Program.myReader.Close();
                        Program.conn.Close();
                    }
                }
                else
                {
                    Program.myReader.Close();
                    Program.conn.Close();
                    MessageBox.Show("Sinh viên không có môn học đăng ký", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnInBC_Click(object sender, EventArgs e)
        {
            XrpKQTHI rpKQT = new XrpKQTHI(Program.username, cbbMHSV.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));
            rpKQT.lbLop.Text = tenLop;
            rpKQT.lbHoTen.Text = Program.mHoten;
            rpKQT.lbMH.Text = cbbMHSV.Text;
            rpKQT.lbNgayThi.Text = ngay.ToString();
            rpKQT.lbLan.Text = cbbLThi.Text;
            ReportPrintTool report = new ReportPrintTool(rpKQT);
            report.ShowPreviewDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (bdsMHocMSV.Count <= 0 || bdsLthiMSV.Count <= 0)
            {
                MessageBox.Show("Sinh viên chưa có kết quả thi", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            this.sP_INBAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_INBAITHITableAdapter.Fill(this.dSReport.SP_INBAITHI, Program.username, cbbMHSV.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));
            if (bdsINBAITHI.Count == 0)
            {
                MessageBox.Show("Chưa có Bài Thi!", "Thông Báo", MessageBoxButtons.OK);
            }
        }
    }
}

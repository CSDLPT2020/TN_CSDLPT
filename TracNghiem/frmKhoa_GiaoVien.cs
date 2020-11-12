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
    public partial class frmKhoa_GiaoVien : Form
    {
        int vitri = 0;
        string macn = "";
        public frmKhoa_GiaoVien()
        {
            InitializeComponent();
        }
        private void frmKhoa_GiaoVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.DS.KHOA);

            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            macn = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            comboBox_CN.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            comboBox_CN.DisplayMember = "TENCN";
            comboBox_CN.ValueMember = "TENSERVER";
            comboBox_CN.SelectedIndex = Program.mChinhanh;
            //phan quyen
            if (Program.mGroup.Equals("Coso"))
            {
                comboBox_CN.Enabled = false;
            }
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKhoa.Position;
            groupControl1.Enabled = true;
            bdsKhoa.AddNew();
            TextBox_MaCS.Text = macn;

            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Khoa.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String makh = "";
            if (bdsGV.Count > 0)
            {
                MessageBox.Show("Không thể xóa khoa này vì đã có giảng viên", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (bdsLop.Count > 0)
            {
                MessageBox.Show("Không thể xóa khoa này vì đã có lớp", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa khoa này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    makh = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MAKH"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsKhoa.RemoveCurrent();
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Update(this.DS.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khoa. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.kHOATableAdapter.Fill(this.DS.KHOA);
                    bdsKhoa.Position = bdsKhoa.Find("MAMH", makh);
                    return;
                }
            }
            if (bdsKhoa.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TextBox_MaKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_MaKH.Focus();
                return;
            }
            if (TextBox_TenKH.Text.Trim() == "")
            {
                MessageBox.Show("Tên khoa không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_TenKH.Focus();
                return;
            }
            
            //check ma, ten khoa ko trung tren 2 site o site tra cuu

            try
            {
                bdsKhoa.EndEdit();
                bdsKhoa.ResetCurrentItem();
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Update(this.DS.KHOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi khoa.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            GridControl_Khoa.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;

            groupControl2.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.kHOATableAdapter.Fill(this.DS.KHOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.CancelEdit();
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Khoa.Enabled = true;
            btnReload.PerformClick();
        }

        private void comboBox_CN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = comboBox_CN.SelectedValue.ToString();

            if (comboBox_CN.SelectedIndex != Program.mChinhanh)
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
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.DS.KHOA);
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                macn = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            }
        }
    }
}

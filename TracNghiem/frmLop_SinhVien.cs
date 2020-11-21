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
    public partial class frmLop_SinhVien : Form
    {
        int vitri = 0;
        string macn = "";
        public frmLop_SinhVien()
        {
            InitializeComponent();
        }

        private void frmLop_SinhVien_Load(object sender, EventArgs e)
        {
            //nhac nho chuyen ve trang thai cu truoc khi mo form loi nhom Truong
            DS.EnforceConstraints = false;

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.DS.KHOA);

            macn = Program.GetMaCS();
            comboBox_CN.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            comboBox_CN.DisplayMember = "TENCN";
            comboBox_CN.ValueMember = "TENSERVER";
            comboBox_CN.SelectedIndex = Program.mChinhanh;
            //phan quyen
            if (Program.mGroup.Equals("Coso"))
            {
                comboBox_CN.Enabled = false;
            }
            else if (Program.mGroup.Equals("Truong"))
            {
                comboBox_CN.Enabled = true;
                bar2.Visible = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            groupControl1.Enabled = true;
            bdsLop.AddNew();

            ComboBox_MAKH.SelectedIndex = 0;
            TextBox_MAKH.Text = ComboBox_MAKH.SelectedValue.ToString();

            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Lop.Enabled = false;
        }

        private void comboBox_CN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CN.SelectedIndex == -1) return;
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
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.DS.KHOA);
                macn = Program.GetMaCS();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Lop.Enabled = true;
            btnReload.PerformClick();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.DS.LOP);
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                this.kHOATableAdapter.Fill(this.DS.KHOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void ComboBox_MAKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_MAKH.SelectedIndex == -1) return;
            TextBox_MAKH.Text = ComboBox_MAKH.SelectedValue.ToString();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String malop = "";
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có giảng viên đăng ký thi", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsLop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.DS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.kHOATableAdapter.Fill(this.DS.KHOA);
                    bdsLop.Position = bdsLop.Find("MALOP", malop);
                    return;
                }
            }
            if (bdsLop.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TextBox_MALOP.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_MALOP.Focus();
                return;
            }
            if (TextBox_TENLOP.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_TENLOP.Focus();
                return;
            }
            if (btnThem.Enabled == false) //dang them moi check
            {
                //check ma, ten lop ko trung tren 2 site o site tra cuu
                string strLenh = "EXEC SP_CHECKLOP_TRACUU N'" + TextBox_MALOP.Text.Trim() + "', N'"
                    + TextBox_TENLOP.Text.Trim() + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1 || kq == 2) return;
            }
            else //sua
            {
                string strLenh = "EXEC SP_CHECKLOP_PM N'" + TextBox_MALOP.Text.Trim() + "', N'"
                    + TextBox_TENLOP.Text.Trim() + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1 || kq == 2) return;
            }
            //bat dau ghi
            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.DS.LOP);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PK_LOP"))
                {
                    MessageBox.Show("Lỗi mã lớp bị trùng", "", MessageBoxButtons.OK);
                }
                else if (ex.Message.Contains("UN_TENLOP"))
                {
                    MessageBox.Show("Lỗi tên lớp bị trùng", "", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            GridControl_Lop.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;

            groupControl2.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void TextBox_MAKH_TextChanged(object sender, EventArgs e)
        {
            ComboBox_MAKH.SelectedValue = TextBox_MAKH.Text;
        }

        private void themSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsSV.AddNew();
            themSVToolStripMenuItem.Enabled = false;
            xoaSVToolStripMenuItem.Enabled = false;
        }

        private void xoaSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String masv = "";
            if (bdsBangDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã có điểm", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                    bdsSV.Position = bdsSV.Find("MASV", masv);
                    return;
                }
            }
            if (bdsSV.Count == 0) xoaSVToolStripMenuItem.Enabled = false;
        }

        private void ghiSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dang them
            if (themSVToolStripMenuItem.Enabled == false)
            {
                int index = bdsSV.Count - 1;
                //check thong tin giang vien moi nhap vao
                string maSV = this.DataGridView_SV.Rows[index].Cells[0].Value.ToString();

                if (string.IsNullOrEmpty(maSV.Trim()))
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "", MessageBoxButtons.OK);
                    DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[index].Cells[0];
                    DataGridView_SV.BeginEdit(true);
                    return;
                }
                string strLenh = "EXEC SP_CHECKSV_TRACUU N'" + maSV.Trim() + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1)
                {
                    DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[index].Cells[0];
                    DataGridView_SV.BeginEdit(true);
                    return;
                }
            }
            else //sua
            {
                string maSV = this.DataGridView_SV.Rows[bdsSV.Position].Cells[0].Value.ToString();

                if (string.IsNullOrEmpty(maSV.Trim()))
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "", MessageBoxButtons.OK);
                    DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[bdsSV.Position].Cells[0];
                    DataGridView_SV.BeginEdit(true);
                    return;
                }
                string strLenh = "EXEC SP_CHECKSV_PM N'" + maSV.Trim() + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1)
                {
                    DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[bdsSV.Position].Cells[0];
                    DataGridView_SV.BeginEdit(true);
                    return;
                }
            }
            //ghi
            try
            {
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PK_SINHVIEN"))
                {
                    MessageBox.Show("Lỗi mã sinh viên bị trùng", "", MessageBoxButtons.OK);
                    DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[bdsSV.Position].Cells[0];
                    DataGridView_SV.BeginEdit(true);
                }
                else
                {
                    this.bdsSV.RemoveCurrent();
                    MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                }
                return;
            }
            themSVToolStripMenuItem.Enabled = true;
            xoaSVToolStripMenuItem.Enabled = true;
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (themSVToolStripMenuItem.Enabled == false)
            {
                this.bdsSV.RemoveCurrent();
                themSVToolStripMenuItem.Enabled = true;
                xoaSVToolStripMenuItem.Enabled = true;
            }
        }
    }
}

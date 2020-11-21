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
    public partial class frmNhapDe : Form
    {
        public frmNhapDe()
        {
            InitializeComponent();
        }

        private void frmNhapDe_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.DS.BODE);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

            ComboBox_MAMH.SelectedValue = TextBox_MAMH.Text;
            
        }

        private void TextBox_MAMH_TextChanged(object sender, EventArgs e)
        {
            ComboBox_MAMH.SelectedValue = TextBox_MAMH.Text;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBD.AddNew();
            TextBox_MAGV.Text = Program.username;
            ComboBox_MAMH.SelectedIndex = 0;
            ComboBox_DA.SelectedIndex = -1;
            ComboBox_TD.SelectedIndex = -1;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String mach = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa câu hỏi này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mach = ((DataRowView)bdsBD[bdsBD.Position])["CAUHOI"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsBD.RemoveCurrent();
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Update(this.DS.BODE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa câu hỏi. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.bODETableAdapter.Fill(this.DS.BODE);
                    bdsMH.Position = bdsMH.Find("CAUHOI", mach);
                    return;
                }
            }
            if (bdsBD.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsBD.EndEdit();
                bdsBD.ResetCurrentItem();
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Update(this.DS.BODE);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("CK_BODE"))
                {
                    MessageBox.Show("Bạn chưa chọn trình độ hoặc trình độ " +
                        "không hợp lệ!", "", MessageBoxButtons.OK);
                }
                else if (ex.Message.Contains("CK_DAPAN"))
                {
                    MessageBox.Show("Bạn chưa chọn đáp án hoặc đáp án " +
                        "không hợp lệ!", "", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Lỗi ghi bộ đề.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.bODETableAdapter.Fill(this.DS.BODE);
                this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
                ComboBox_MAMH.SelectedValue = TextBox_MAMH.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBD.CancelEdit();
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_BODE.Enabled = true;
            btnReload.PerformClick();
        }

        private void ComboBox_MAMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_MAMH.SelectedIndex == -1) return;
            TextBox_MAMH.Text = ComboBox_MAMH.SelectedValue.ToString();
        }

        private void TextBox_MAGV_TextChanged(object sender, EventArgs e)
        {
            if(TextBox_MAGV.Text.Trim() == Program.username)
            {
                btnGhi.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnGhi.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void ComboBox_TD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_TD.SelectedIndex == -1)
            {
                label_TD.Text = "Chọn trình độ";
            }
            else if(ComboBox_TD.SelectedIndex == 0)
            {
                label_TD.Text = "Đại học, chuyên ngành";
            }
            else if (ComboBox_TD.SelectedIndex == 1)
            {
                label_TD.Text = "Đại học, không chuyên ngành";
            }
            else if (ComboBox_TD.SelectedIndex == 2)
            {
                label_TD.Text = "Cao đẳng";
            }
        }
    }
}

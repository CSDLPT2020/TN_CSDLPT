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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);
            comboBox_TenCN.SelectedIndex = 1;
            comboBox_TenCN.SelectedIndex = 0;
            //string t=((DataRowView)bdsPM[2])["TENCN"].ToString();
            //MessageBox.Show(t);
        }

        private void comboBox_TenCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = (string)comboBox_TenCN.SelectedValue;
            }
            catch(Exception) { }
        }

        private void radioButton_SinhVien_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Pass.Enabled = false;
            label_LoginName.Text = "Mã sinh viên";
            label_pass.Enabled = false;
        }

        private void radioButton_GiangVien_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Pass.Enabled = true;
            label_LoginName.Text = "Login name";
            label_pass.Enabled = true;
        }

        private void button_DN_Click(object sender, EventArgs e)
        {
            if (radioButton_GiangVien.Checked)
            {
                Program.isGV = true;//giang vien
                if (textBox_TenDN.Text.Trim() == "" || textBox_Pass.Text.Trim() == "")
                {
                    MessageBox.Show("Login name và password của giảng viên không được để trống!","",MessageBoxButtons.OK);
                    return;
                }
                Program.mlogin = textBox_TenDN.Text;
                Program.password = textBox_Pass.Text;
            }
            else
            {
                Program.isGV = false;//sinh vien
                if (textBox_TenDN.Text.Trim() == "")
                {
                    MessageBox.Show("Mã sinh viên không được để trống!","", MessageBoxButtons.OK);
                    return;
                }
                Program.mlogin = "sv";
                Program.password = "sv";
            }

            if (Program.KetNoi() == 0) return;

            Program.mChinhanh = comboBox_TenCN.SelectedIndex;
            Program.bds_dspm = bdsPM;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            
            if(Program.isGV == true)
            {
                string strLenh = "EXEC SP_THONGTINDANGNHAP_GV '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten= Program.myReader.GetString(1);
                Program.mGroup= Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
                Program.frmChinh.HienThiMenu();
            }
            else
            {
                //sua lai ben sinh vien. sai cho Program.mlogin ko phai mã sv như trong sp
                string strLenh = "EXEC SP_THONGTINDANGNHAP_SV '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
                Program.frmChinh.HienThiMenu();
            }
        }
    }
}

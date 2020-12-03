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
    public partial class frmThi : Form
    {
        List<itemCauHoi> list = new List<itemCauHoi>();
        int s=0;//tong so giay
        int sct=0;
        string td = "";
        public frmThi()
        {
            InitializeComponent();
        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

            dateEdit_NT.DateTime = DateTime.Now.Date;
            spinEdit_LAN.Value = spinEdit_LAN.Properties.MinValue;
            //fill thong tin SV
            label_MASV.Text = Program.username;
            label_TENSV.Text = Program.mHoten;
            if (Program.mGroup == "Sinhvien")
            {
                ComboBox_MaLop.Visible = false;
                GetMaLop_TenLop();
            }
            else if (Program.mGroup == "Giangvien" || Program.mGroup == "Coso")
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);

                label_TT.Text = "Thông tin giáo viên";
                label_TENLOP.Visible = false;

                ComboBox_MaLop.SelectedIndex = 1;
                ComboBox_MaLop.SelectedIndex = 0;
                labelMaSV_GV.Text = "Mã GV";
                labelTenSV_GV.Text = "Tên GV";
            }
        }

        private void GetMaLop_TenLop()
        {
            string strLenh = "SELECT MALOP,TENLOP FROM LOP WHERE MALOP in" +
                " (SELECT MALOP FROM SINHVIEN WHERE MASV= N'" + Program.username + "')";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            if (Program.myReader.Read() == false) return;
            label_MALOP.Text = Program.myReader.GetString(0);
            label_TENLOP.Text = Program.myReader.GetString(1);
            Program.myReader.Close();
        }

        private void loadCauHoiThi()
        {
            string strLenh = "EXEC SP_GETCAUHOITHI N'"
                    + ComboBox_MAMH.SelectedValue.ToString() + "', N'"
                    + td + "', "
                    + sct;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            list.Clear();
            flowLayoutPanel_THI.Controls.Clear();
            int i = 0;
            while (Program.myReader.Read() == true)
            {
                itemCauHoi ch = new itemCauHoi();
                ch.CauHoi = Program.myReader.GetInt32(0);
                ch.NoiDung = Program.myReader.GetString(1);
                ch.A = Program.myReader.GetString(2);
                ch.B = Program.myReader.GetString(3);
                ch.C = Program.myReader.GetString(4);
                ch.D = Program.myReader.GetString(5);
                ch.DapAn = Program.myReader.GetString(6);
                ch.Stt = i + 1;
                i++;
                list.Add(ch);
                flowLayoutPanel_THI.Controls.Add(ch);
            }
            Program.myReader.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            int seconds = s % 60;
            int minutes = s / 60;
            string se = "" + seconds;
            string mi = "" + minutes;
            if (seconds < 10)
            {
                se = "0" + se;
            }
            if (minutes < 10)
            {
                mi = "0" + mi;
            }
            label_Timer.Text = mi + ":" + se;
            if (s == 0)
            {
                timer1.Stop();
            }
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateEdit_NT.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày thi!", "", MessageBoxButtons.OK);
                dateEdit_NT.Focus();
                return;
            }
            if (Program.mGroup == "Sinhvien")
            {
                if (dateEdit_NT.DateTime.Date != DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày thi phải là hôm nay!", "", MessageBoxButtons.OK);
                    dateEdit_NT.Focus();
                    return;
                }
                //check sv da thi hay chua
                string strLenh1 = "EXEC SP_CHECKSVTRONGBANGDIEM N'" + Program.username
                    + "', N'" + ComboBox_MAMH.SelectedValue.ToString() +
                    "', " + spinEdit_LAN.Value;
                int kq = Program.ExecSqlNonQuery(strLenh1);
                if (kq == 1) return;
            }
            //get gvdk
            string strLenh = "EXEC SP_CHECKTHONGTINTHI_SV N'" + label_MALOP.Text
                + "', N'" + ComboBox_MAMH.SelectedValue.ToString() +
                "', N'" + dateEdit_NT.DateTime.ToString("yyyy-MM-dd HH:mm:ss") + "', " + spinEdit_LAN.Value;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            if (Program.myReader.Read() == false)
            {
                MessageBox.Show("Thông tin đăng ký thi không tồn tại!", "", MessageBoxButtons.OK);
            }
            else
            {
                td = Program.myReader.GetString(0);
                label_TD.Text = td;
                sct = Program.myReader.GetInt16(1);
                label_SCT.Text = sct.ToString();
                Int16 time = Program.myReader.GetInt16(2);
                label_Timer.Text = time.ToString() + ":00";
                s = time * 60;
            }
            Program.myReader.Close();
        }

        private string getDapAn(itemCauHoi x)
        {
            string da = "";
            if (x.Rbtn_A.Checked == true)
            {
                da = "A";
            }
            else if (x.Rbtn_B.Checked == true)
            {
                da = "B";
            }
            else if (x.Rbtn_C.Checked == true)
            {
                da = "C";
            }
            else if (x.Rbtn_D.Checked == true)
            {
                da = "D";
            }
            return da;
        }

        private float tinhDiem()
        {
            int soCauDung = 0;
            foreach(itemCauHoi x in list)
            {
                string da = getDapAn(x);
                if (da == x.DapAn)
                {
                    soCauDung++;
                }
            }

            return (soCauDung * 10) / sct;
        }

        private void ghiBangDiem(float diem)
        {
            //ghi vao bang diem
            string strLenh = "EXEC SP_THEMBANGDIEM N'"
            + Program.username + "', N'"
            + ComboBox_MAMH.SelectedValue.ToString() + "', "
            + spinEdit_LAN.Value + ", N'"
            + dateEdit_NT.DateTime.ToString("yyyy-MM-dd HH:mm:ss") + "', "
            + diem ;
            int kq = Program.ExecSqlNonQuery(strLenh);
            if (kq != 0)
            {
                MessageBox.Show("Lỗi ghi bảng điểm!", "", MessageBoxButtons.OK);
            }
        }

        private void ghiCTBT()
        {
            foreach(itemCauHoi x in list)
            {
                string da = getDapAn(x);

                string strLenh = "EXEC SP_THEMCTBT N'"
                    + Program.username + "', N'"
                    + ComboBox_MAMH.SelectedValue.ToString() + "', "
                    + spinEdit_LAN.Value + ", "
                    + x.Stt + ", " + x.CauHoi + ", N'"
                    + da.Trim() + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq != 0)
                {
                    MessageBox.Show("Lỗi ghi CTBT!", "", MessageBoxButtons.OK);
                }
            }
        }

        private void button_NOPBAI_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false) //bat dau thi
            {
                //check them cho chac SCT
                string strLenh1 = "EXEC SP_CHECKSOCAUTHI N'"
                    + ComboBox_MAMH.SelectedValue.ToString() + "', N'"
                    + td + "', "
                    + sct;
                int kq1 = Program.ExecSqlNonQuery(strLenh1);
                if (kq1 == 1) return;

                button_NOPBAI.Text = "Nộp bài";
                timer1.Start();
                //load cau hoi thi
                //load giao dien thi
                loadCauHoiThi();
            }
            else //nop bai
            {
                if (MessageBox.Show("Bạn có thật sự muốn nộp bài ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    button_NOPBAI.Text = "Bắt đầu thi";
                    timer1.Stop();
                    float diem = tinhDiem();
                    if (Program.mGroup == "Sinhvien")
                    {
                        //ghi bang diem
                        ghiBangDiem(diem);
                        //ghi chi tiet bai thi
                        ghiCTBT();
                    }
                    MessageBox.Show("Bạn đã đạt được " + diem + " điểm!", "", MessageBoxButtons.OK);
                }
            }
        }

        private void ComboBox_MaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_MaLop.SelectedIndex == -1) return;
            label_MALOP.Text = ComboBox_MaLop.SelectedValue.ToString();
        }
    }
}

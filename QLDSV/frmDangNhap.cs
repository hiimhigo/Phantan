using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;

namespace QLDSV
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);
            cbxTenKhoa.SelectedIndex = 1;
            cbxTenKhoa.SelectedIndex = 0;

        }

        private void tENKHOAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTenKhoa.SelectedValue != null)
            {
                Program.servername = cbxTenKhoa.SelectedValue.ToString();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "")
            {
                //kiểm tra tài khoản 
                MessageBox.Show("Tài Khoản đăng nhập không được trống", "Báo Lỗi Đăng Nhập", MessageBoxButtons.OK);
                txtTaiKhoan.Focus();
                return;
            }
            Program.mlogin = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;
            if (Program.KetNoi() == 0) return;
            Program.mKhoa = cbxTenKhoa.SelectedIndex;
            Program.bds_DSPM = bds_DSPM;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            SqlDataReader myReader;
            String strLenh = "exec SP_DANGNHAP'" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();
            Program.username = myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MaGV.Text = "Mã User : "+ Program.username;
            Program.frmChinh.HoTen.Text = "Họ Tên :" +Program.mHoten;
            Program.frmChinh.Nhom.Text = "Nhóm :"+Program.mGroup;
            Program.frmChinh.rbpDanhMuc.Visible = true;
            groupBox1.Enabled = false;
            //this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
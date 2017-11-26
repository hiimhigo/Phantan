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

namespace QLDSV
{
    public partial class frmXemDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmXemDiem()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_QLDSV);

        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {

            
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);
            ds_QLDSV.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.ds_QLDSV.MONHOC);
            // TODO: This line of code loads data into the 'ds_QLDSV.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.ds_QLDSV.LOP);
            this.sp_timDiemTableAdapter.Connection.ConnectionString = Program.connstr;

            cbxKhoa.DataSource = Program.bds_DSPM;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cbxKhoa.DisplayMember = "TENKHOA";
            cbxKhoa.ValueMember = "TENSERVER";
            cbxKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "PGV") cbxKhoa.Enabled = true;  // bật tắt theo phân quyền
            else cbxKhoa.Enabled = false;
        }

        /*private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_timDiemTableAdapter.Fill(this.ds_QLDSV.sp_timDiem, malopToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(lanToolStripTextBox.Text, typeof(int))))), mamhToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_timDiemTableAdapter.Fill(this.ds_QLDSV.sp_timDiem, cbxMaLop.SelectedValue.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(txtLan.Text, typeof(int))))), cbxMaMH.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cbxKhoa.SelectedValue.ToString();

            if (cbxKhoa.SelectedIndex != Program.mKhoa)
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
                this.lOPTableAdapter.Fill(this.ds_QLDSV.LOP);
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.ds_QLDSV.MONHOC);
                this.sp_timDiemTableAdapter.Connection.ConnectionString = Program.connstr;

            } 
        }
    }
}
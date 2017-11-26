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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string maKhoa = "";
        public frmLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_QLDSV);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_QLDSV.SINHVIEN' table. You can move, or remove it, as needed.
            ds_QLDSV.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'ds_QLDSV.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.ds_QLDSV.LOP);
            this.sINHVIENTableAdapter.Fill(this.ds_QLDSV.SINHVIEN);
            maKhoa = ((DataRowView)bdsLop[0])["MAKH"].ToString();
            cbxKhoa.DataSource = Program.bds_DSPM;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cbxKhoa.DisplayMember = "TENKHOA";
            cbxKhoa.ValueMember = "TENSERVER";
            cbxKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "PGV") cbxKhoa.Enabled = true;  // bật tắt theo phân quyền
            else cbxKhoa.Enabled = false;
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
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.ds_QLDSV.SINHVIEN);
                maKhoa = ((DataRowView)bdsLop[0])["MAKH"].ToString(); 
               
            } 
        }

        private void btnThemLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            groupBox1.Enabled = true;
            bdsLop.AddNew();
            txtMaKhoa.Text = maKhoa;            
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = btnReloadLop.Enabled = btnThoatLop.Enabled = false;
            btnGhiLop.Enabled = btnPhucHoiLop.Enabled = true;
            gcLop.Enabled = false;
        }

        private void btnSuaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            txtMaKhoa.Enabled = false;
            groupBox1.Enabled = true;
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = btnReloadLop.Enabled = btnThoatLop.Enabled = false;
            btnGhiLop.Enabled = btnPhucHoiLop.Enabled = true;
            gcLop.Enabled = false;
        }

        private void btnGhiLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên Lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            
            

            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.ds_QLDSV.LOP);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                this.lOPTableAdapter.Fill(this.ds_QLDSV.LOP);
                return;
            }
            gcLop.Enabled = true;
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = btnReloadLop.Enabled = btnThoatLop.Enabled = true;
            btnGhiLop.Enabled = btnPhucHoiLop.Enabled = false;

            groupBox1.Enabled = false; 
        }

        private void btnXoaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 maLop = 0;
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLop = int.Parse(((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString()); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsLop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.ds_QLDSV.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.ds_QLDSV.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", maLop);
                    return;
                }
            }

            if (bdsLop.Count == 0) btnXoaLop.Enabled = false;
        }

        private void btnReloadLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.ds_QLDSV.LOP);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoiLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            if (btnThemLop.Enabled == false) bdsLop.Position = vitri;
            gcLop.Enabled = true;
            groupBox1.Enabled = false;
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = btnReloadLop.Enabled = btnThoatLop.Enabled = true;
            btnGhiLop.Enabled = btnPhucHoiLop.Enabled = false;
        }

        private void btnThoatLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
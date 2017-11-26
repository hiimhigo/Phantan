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
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string maKhoa = "";
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSinhVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_QLDSV);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_QLDSV.DIEM' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'ds_QLDSV.LOP' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'ds_QLDSV.SINHVIEN' table. You can move, or remove it, as needed.
            
            ds_QLDSV.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.ds_QLDSV.SINHVIEN);
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.ds_QLDSV.DIEM);
            //maKhoa = ((DataRowView)bdsSinhVien[0])["MAKH"].ToString();
            cbxKhoa.DataSource = Program.bds_DSPM;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cbxKhoa.DisplayMember = "TENKHOA";
            cbxKhoa.ValueMember = "TENSERVER";
            cbxKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "PGV") cbxKhoa.Enabled = true;  // bật tắt theo phân quyền
            else cbxKhoa.Enabled = false;

        }

        private void btnThemSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSinhVien.Position;
            groupBox1.Enabled = true;
            bdsSinhVien.AddNew();
            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = btnReloadSV.Enabled = btnThoatSV.Enabled = false;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = true;
            gcSinhVien.Enabled = false;
            
        }

        private void btnSuaSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSinhVien.Position;
            groupBox1.Enabled = true;
            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = btnReloadSV.Enabled = btnThoatSV.Enabled = false;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = true;
            gcSinhVien.Enabled = false;
        }

        private void btnGhiSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            if (txtHoSV.Text.Trim() == "")
            {
                MessageBox.Show("Họ sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtHoSV.Focus();
                return;
            }
            if (txtTenSV.Text.Trim() == "")
            {
                MessageBox.Show("Tên sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtTenSV.Focus();
                return;
            }
            // Kiểm tra MACN, PHAI, NGAYSINH  phải có
            // LUONg thỏa Miền giá trị
            // MANV không được trùng trên các phân mảnh

            try
            {
                bdsSinhVien.EndEdit();
                bdsSinhVien.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.ds_QLDSV.SINHVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcSinhVien.Enabled = true;
            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = btnReloadSV.Enabled = btnThoatSV.Enabled = true;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = false;

            groupBox1.Enabled = false; 
        }

        private void btnPhucHoiSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSinhVien.CancelEdit();
            if (btnThemSV.Enabled == false) bdsSinhVien.Position = vitri;
            gcSinhVien.Enabled = true;
            groupBox1.Enabled = false;
            btnThemSV.Enabled = btnSuaSV.Enabled = btnXoaSV.Enabled = btnReloadSV.Enabled = btnThoatSV.Enabled = true;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = false;
        }

        private void btnReloadSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sINHVIENTableAdapter.Fill(this.ds_QLDSV.SINHVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoaSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 masv = 0;
            if (bdsDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã nhập điểm", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = int.Parse(((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString()); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsSinhVien.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.ds_QLDSV.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.ds_QLDSV.SINHVIEN);
                    bdsSinhVien.Position = bdsSinhVien.Find("MASV", masv);
                    return;
                }
            }

            if (bdsSinhVien.Count == 0) btnXoaSV.Enabled = false;
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
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.ds_QLDSV.SINHVIEN);
                
                //maKhoa = ((DataRowView)bdsSinhVien[0])["MAKH"].ToString();
            } 
        }

        private void btnThoatSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cbxPhai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
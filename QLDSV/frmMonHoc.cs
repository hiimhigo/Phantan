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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_QLDSV);

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_QLDSV.MONHOC' table. You can move, or remove it, as needed.
            ds_QLDSV.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.ds_QLDSV.MONHOC);
            if (Program.mGroup == "KHOA")
            {
                btnGhiMH.Enabled = btnPhucHoiMH.Enabled = btnSuaMH.Enabled = btnThemMH.Enabled = btnXoaMH.Enabled = false;
                btnThoatMH.Enabled = btnReloadMH.Enabled = true;
            }

        }

        private void btnThemMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            groupBox1.Enabled = true;
            bdsMonHoc.AddNew();
            btnThemMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnReloadMH.Enabled = btnThoatMH.Enabled = false;
            btnGhiMH.Enabled = btnPhucHoiMH.Enabled = true;
            gcMonHoc.Enabled = false;
        }

        private void btnSuaMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            groupBox1.Enabled = true;
            btnThemMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnReloadMH.Enabled = btnThoatMH.Enabled = false;
            btnGhiMH.Enabled = btnPhucHoiMH.Enabled = true;
            gcMonHoc.Enabled = false;
        }

        private void btnXoaMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnGhiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return;
            }
            
            // Kiểm tra MACN, PHAI, NGAYSINH  phải có
            // LUONg thỏa Miền giá trị
            // MANV không được trùng trên các phân mảnh

            try
            {
                bdsMonHoc.EndEdit();
                bdsMonHoc.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.ds_QLDSV.MONHOC);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcMonHoc.Enabled = true;
            btnThemMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnReloadMH.Enabled = btnThoatMH.Enabled = true;
            btnGhiMH.Enabled = btnPhucHoiMH.Enabled = false;

            groupBox1.Enabled = false; 
        }

        private void btnThoatMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnPhucHoiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();
            if (btnThemMH.Enabled == false) bdsMonHoc.Position = vitri;
            gcMonHoc.Enabled = true;
            groupBox1.Enabled = false;
            btnThemMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnReloadMH.Enabled = btnThoatMH.Enabled = true;
            btnGhiMH.Enabled = btnPhucHoiMH.Enabled = false;
        }

        private void btnReloadMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mONHOCTableAdapter.Fill(this.ds_QLDSV.MONHOC);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
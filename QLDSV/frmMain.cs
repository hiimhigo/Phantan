using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.Show();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void barDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "PGV")
            {
                MessageBox.Show("User này không thể nhập điểm", "", MessageBoxButtons.OK);
                
            }
            else
            {
                frmNhapDiem f = new frmNhapDiem();
                f.ShowDialog();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnXemDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmXemDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmXemDiem f = new frmXemDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

    }
}

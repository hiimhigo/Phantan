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
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            ds_QLDSV.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.ds_QLDSV.LOP);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.ds_QLDSV.MONHOC);           
            SqlDataReader Reader;
            String strLenh = "exec SP_TIMLOP'" + cbxMaLop.SelectedValue.ToString() + "'";
            Reader = Program.ExecSqlDataReader(strLenh);
            if (Reader == null) return;
            Reader.Read();
            txtTenLop.Text = Reader["TENLOP"].ToString();
            Reader.Close();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_QLDSV);

        }

        private void cbxMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader Reader;
            String strLenh = "exec SP_TIMLOP'" + cbxMaLop.SelectedValue.ToString() + "'";
            Reader = Program.ExecSqlDataReader(strLenh);
            if (Reader == null) return;
            Reader.Read();
            txtTenLop.Text = Reader["TENLOP"].ToString();
            Reader.Close();
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            Program.maMh = cbxMonHoc.SelectedValue.ToString();
            Program.maLop = cbxMaLop.SelectedValue.ToString();
            Program.lan = txtLanThi.Text;
            frmForm f = new frmForm();
            f.ShowDialog();
            Program.maLop = "";
            Program.maMh = "";
            Program.lan = "";
            this.Close();
        }
        

        
    }
}
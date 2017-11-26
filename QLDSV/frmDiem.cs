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
    public partial class frmDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmDiem()
        {
            InitializeComponent();
        }

        

        private void frmDiem_Load(object sender, EventArgs e)
        {
            ds_QLDSV.EnforceConstraints = false;
            this.sp_SinhVienLopTableAdapter.Connection.ConnectionString = Program.connstr;   
            txtMaLop.Text = Program.maLop;
            try
            {
                this.sp_SinhVienLopTableAdapter.Fill(this.ds_QLDSV.sp_SinhVienLop, txtMaLop.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
           
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sp_SinhVienLopTableAdapter.Fill(this.ds_QLDSV.sp_SinhVienLop, txtMaLop.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string s1 = "";
            string s2 = "";
            try
            {
                for (int i = 0; i < gcSinhVienLop.RowCount - 1; i++)
                {
                    s1 = gcSinhVienLop.Rows[i].Cells[0].Value.ToString();
                    s2 = gcSinhVienLop.Rows[i].Cells[2].Value.ToString();
                    String strLenh = "exec sp_NhapDiem '" + s1 + "','" + Program.maMh + "','" + Program.lan + "','" + s2 + "'";
                    SqlDataReader Reader;
                    Reader = Program.ExecSqlDataReader(strLenh);
                    Reader.Close();
                }
                MessageBox.Show("Đã nhập điểm thành công", "", MessageBoxButtons.OK);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi trong quá trình nhập điểm "+ ex.Message,"",MessageBoxButtons.OK);
            }
            this.Close();
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_SinhVienLopTableAdapter.Fill(this.ds_QLDSV.sp_SinhVienLop, txtMaLop.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
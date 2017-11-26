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
    public partial class frmForm : DevExpress.XtraEditors.XtraForm
    {
        public frmForm()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_nhapDiemSVLopTableAdapter.Fill(this.ds_QLDSV.sp_nhapDiemSVLop, malopToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(lanToolStripTextBox.Text, typeof(int))))), mamhToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < sp_nhapDiemSVLopBindingSource.Count ; i++)
                {


                    dIEMBindingSource.Filter = "MAMH = '" + Program.maMh + "' and lan = " + Program.lan;
                    int count = dIEMBindingSource.Count;

                    dIEMBindingSource.AddNew();
                    ((DataRowView)dIEMBindingSource[count])["MASV"] = sp_nhapDiemSVLopDataGridView.Rows[i].Cells[0].Value.ToString();

                    ((DataRowView)dIEMBindingSource[count])["MAMH"] = Program.maMh;
                    ((DataRowView)dIEMBindingSource[count])["LAN"] = Program.lan;
                    ((DataRowView)dIEMBindingSource[count])["DIEM"] = sp_nhapDiemSVLopDataGridView.Rows[i].Cells[2].Value;//sp_nhapDiemSVLopDataGridView.Rows[5].Cells[2];
                    dIEMBindingSource.EndEdit();
                    dIEMBindingSource.ResetCurrentItem();
                    this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dIEMTableAdapter.Update(this.ds_QLDSV.DIEM);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            
            
            
        }

        private void frmForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_QLDSV.DIEM' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'ds_QLDSV.DIEM' table. You can move, or remove it, as needed.
            ds_QLDSV.EnforceConstraints = false;
            this.sp_nhapDiemSVLopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.ds_QLDSV.DIEM);
            
            try
            {
                this.sp_nhapDiemSVLopTableAdapter.Fill(this.ds_QLDSV.sp_nhapDiemSVLop, Program.maLop, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.lan, typeof(int))))), Program.maMh);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
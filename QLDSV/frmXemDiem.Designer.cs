namespace QLDSV
{
    partial class frmXemDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENKHOALabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPM = new QLDSV.DS_DSPM();
            this.txtLan = new System.Windows.Forms.TextBox();
            this.labellan = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbxMaLop = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.ds_QLDSV = new QLDSV.ds_QLDSV();
            this.cbxMaMH = new System.Windows.Forms.ComboBox();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.ds_QLDSVTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.ds_QLDSVTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV.ds_QLDSVTableAdapters.MONHOCTableAdapter();
            this.sp_timDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_timDiemTableAdapter = new QLDSV.ds_QLDSVTableAdapters.sp_timDiemTableAdapter();
            this.gcSp_TimDiem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_DS_PHANMANHTableAdapter = new QLDSV.DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new QLDSV.DS_DSPMTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            mAMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENKHOALabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_timDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSp_TimDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(25, 98);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(66, 17);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "Môn học";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(25, 54);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(58, 17);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "Tên lớp";
            // 
            // tENKHOALabel
            // 
            tENKHOALabel.AutoSize = true;
            tENKHOALabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENKHOALabel.Location = new System.Drawing.Point(25, 20);
            tENKHOALabel.Name = "tENKHOALabel";
            tENKHOALabel.Size = new System.Drawing.Size(70, 17);
            tENKHOALabel.TabIndex = 8;
            tENKHOALabel.Text = "Tên khoa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(tENKHOALabel);
            this.panel1.Controls.Add(this.cbxKhoa);
            this.panel1.Controls.Add(this.txtLan);
            this.panel1.Controls.Add(this.labellan);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(mALOPLabel);
            this.panel1.Controls.Add(this.cbxMaLop);
            this.panel1.Controls.Add(mAMHLabel);
            this.panel1.Controls.Add(this.cbxMaMH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(576, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 549);
            this.panel1.TabIndex = 0;
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DS_PHANMANHBindingSource, "TENKHOA", true));
            this.cbxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(177, 12);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(149, 25);
            this.cbxKhoa.TabIndex = 9;
            this.cbxKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxKhoa_SelectedIndexChanged);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.dS_DSPM;
            // 
            // dS_DSPM
            // 
            this.dS_DSPM.DataSetName = "DS_DSPM";
            this.dS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtLan
            // 
            this.txtLan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLan.Location = new System.Drawing.Point(177, 132);
            this.txtLan.Name = "txtLan";
            this.txtLan.Size = new System.Drawing.Size(100, 25);
            this.txtLan.TabIndex = 7;
            this.txtLan.Text = "1";
            // 
            // labellan
            // 
            this.labellan.AutoSize = true;
            this.labellan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellan.Location = new System.Drawing.Point(25, 138);
            this.labellan.Name = "labellan";
            this.labellan.Size = new System.Drawing.Size(33, 17);
            this.labellan.TabIndex = 6;
            this.labellan.Text = "Lần";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(28, 474);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(136, 46);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(28, 251);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(136, 49);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbxMaLop
            // 
            this.cbxMaLop.DataSource = this.bdsLop;
            this.cbxMaLop.DisplayMember = "TENLOP";
            this.cbxMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaLop.FormattingEnabled = true;
            this.cbxMaLop.Location = new System.Drawing.Point(177, 51);
            this.cbxMaLop.Name = "cbxMaLop";
            this.cbxMaLop.Size = new System.Drawing.Size(309, 25);
            this.cbxMaLop.TabIndex = 3;
            this.cbxMaLop.ValueMember = "MALOP";
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.ds_QLDSV;
            // 
            // ds_QLDSV
            // 
            this.ds_QLDSV.DataSetName = "ds_QLDSV";
            this.ds_QLDSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxMaMH
            // 
            this.cbxMaMH.DataSource = this.bdsMonHoc;
            this.cbxMaMH.DisplayMember = "MAMH";
            this.cbxMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaMH.FormattingEnabled = true;
            this.cbxMaMH.Location = new System.Drawing.Point(177, 90);
            this.cbxMaMH.Name = "cbxMaMH";
            this.cbxMaMH.Size = new System.Drawing.Size(309, 25);
            this.cbxMaMH.TabIndex = 1;
            this.cbxMaMH.ValueMember = "MAMH";
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.ds_QLDSV;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.ds_QLDSVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // sp_timDiemBindingSource
            // 
            this.sp_timDiemBindingSource.DataMember = "sp_timDiem";
            this.sp_timDiemBindingSource.DataSource = this.ds_QLDSV;
            // 
            // sp_timDiemTableAdapter
            // 
            this.sp_timDiemTableAdapter.ClearBeforeFill = true;
            // 
            // gcSp_TimDiem
            // 
            this.gcSp_TimDiem.DataSource = this.sp_timDiemBindingSource;
            this.gcSp_TimDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSp_TimDiem.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcSp_TimDiem.Location = new System.Drawing.Point(0, 0);
            this.gcSp_TimDiem.MainView = this.gridView1;
            this.gcSp_TimDiem.Name = "gcSp_TimDiem";
            this.gcSp_TimDiem.Size = new System.Drawing.Size(576, 549);
            this.gcSp_TimDiem.TabIndex = 2;
            this.gcSp_TimDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colhoten,
            this.colDIEM});
            this.gridView1.GridControl = this.gcSp_TimDiem;
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã sinh viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 200;
            // 
            // colhoten
            // 
            this.colhoten.Caption = "Họ tên";
            this.colhoten.FieldName = "hoten";
            this.colhoten.Name = "colhoten";
            this.colhoten.Visible = true;
            this.colhoten.VisibleIndex = 1;
            this.colhoten.Width = 275;
            // 
            // colDIEM
            // 
            this.colDIEM.Caption = "Điểm";
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            this.colDIEM.Width = 279;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLDSV.DS_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcSp_TimDiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 549);
            this.panel2.TabIndex = 1;
            // 
            // frmXemDiem
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXemDiem";
            this.Text = "Xem Điểm";
            this.Load += new System.EventHandler(this.frmXemDiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_timDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSp_TimDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ds_QLDSV ds_QLDSV;
        private System.Windows.Forms.BindingSource bdsLop;
        private ds_QLDSVTableAdapters.LOPTableAdapter lOPTableAdapter;
        private ds_QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private ds_QLDSVTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox cbxMaLop;
        private System.Windows.Forms.ComboBox cbxMaMH;
        private System.Windows.Forms.BindingSource sp_timDiemBindingSource;
        private ds_QLDSVTableAdapters.sp_timDiemTableAdapter sp_timDiemTableAdapter;
        private DevExpress.XtraGrid.GridControl gcSp_TimDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtLan;
        private System.Windows.Forms.Label labellan;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colhoten;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.Panel panel2;
    }
}
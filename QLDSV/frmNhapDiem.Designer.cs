namespace QLDSV
{
    partial class frmNhapDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLanThi = new System.Windows.Forms.TextBox();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.ds_QLDSV = new QLDSV.ds_QLDSV();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.ds_QLDSVTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.ds_QLDSVTableAdapters.TableAdapterManager();
            this.cbxMaLop = new System.Windows.Forms.ComboBox();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLDSV.ds_QLDSVTableAdapters.MONHOCTableAdapter();
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP ĐIỂM MÔN HỌC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lần thi";
            // 
            // txtLanThi
            // 
            this.txtLanThi.Location = new System.Drawing.Point(447, 113);
            this.txtLanThi.Name = "txtLanThi";
            this.txtLanThi.Size = new System.Drawing.Size(100, 25);
            this.txtLanThi.TabIndex = 10;
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(346, 197);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(96, 40);
            this.btnBatDau.TabIndex = 12;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // ds_QLDSV
            // 
            this.ds_QLDSV.DataSetName = "ds_QLDSV";
            this.ds_QLDSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.ds_QLDSV;
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
            // cbxMaLop
            // 
            this.cbxMaLop.DataSource = this.bdsLop;
            this.cbxMaLop.DisplayMember = "MALOP";
            this.cbxMaLop.FormattingEnabled = true;
            this.cbxMaLop.Location = new System.Drawing.Point(142, 60);
            this.cbxMaLop.Name = "cbxMaLop";
            this.cbxMaLop.Size = new System.Drawing.Size(200, 25);
            this.cbxMaLop.TabIndex = 15;
            this.cbxMaLop.ValueMember = "MALOP";
            this.cbxMaLop.SelectedIndexChanged += new System.EventHandler(this.cbxMaLop_SelectedIndexChanged);
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.ds_QLDSV;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMonHoc, "TENMH", true));
            this.cbxMonHoc.DataSource = this.bdsMonHoc;
            this.cbxMonHoc.DisplayMember = "TENMH";
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.Location = new System.Drawing.Point(142, 113);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(200, 25);
            this.cbxMonHoc.TabIndex = 17;
            this.cbxMonHoc.ValueMember = "MAMH";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(447, 60);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(441, 25);
            this.txtTenLop.TabIndex = 16;
            // 
            // frmNhapDiem
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 272);
            this.Controls.Add(this.cbxMonHoc);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.cbxMaLop);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.txtLanThi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapDiem";
            this.Text = "Nhập Điểm";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBatDau;
        private ds_QLDSV ds_QLDSV;
        private System.Windows.Forms.BindingSource bdsLop;
        private ds_QLDSVTableAdapters.LOPTableAdapter lOPTableAdapter;
        private ds_QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private ds_QLDSVTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.TextBox txtTenLop;
        public System.Windows.Forms.TextBox txtLanThi;
        public System.Windows.Forms.ComboBox cbxMaLop;
        public System.Windows.Forms.ComboBox cbxMonHoc;
    }
}
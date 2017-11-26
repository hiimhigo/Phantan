namespace QLDSV
{
    partial class frmDiem
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
            this.ds_QLDSV = new QLDSV.ds_QLDSV();
            this.sp_timDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_timDiemTableAdapter = new QLDSV.ds_QLDSVTableAdapters.sp_timDiemTableAdapter();
            this.tableAdapterManager = new QLDSV.ds_QLDSVTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.bdsSinhVienLop = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SinhVienLopTableAdapter = new QLDSV.ds_QLDSVTableAdapters.sp_SinhVienLopTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.malopToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtMaLop = new System.Windows.Forms.ToolStripTextBox();
            this.gcSinhVienLop = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_timDiemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVienLop)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVienLop)).BeginInit();
            this.SuspendLayout();
            // 
            // ds_QLDSV
            // 
            this.ds_QLDSV.DataSetName = "ds_QLDSV";
            this.ds_QLDSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.ds_QLDSVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 698);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(364, 24);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(117, 37);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // bdsSinhVienLop
            // 
            this.bdsSinhVienLop.DataMember = "sp_SinhVienLop";
            this.bdsSinhVienLop.DataSource = this.ds_QLDSV;
            // 
            // sp_SinhVienLopTableAdapter
            // 
            this.sp_SinhVienLopTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malopToolStripLabel,
            this.txtMaLop});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(845, 25);
            this.fillToolStrip.TabIndex = 3;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // malopToolStripLabel
            // 
            this.malopToolStripLabel.Name = "malopToolStripLabel";
            this.malopToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.malopToolStripLabel.Text = "malop:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(100, 25);
            // 
            // gcSinhVienLop
            // 
            this.gcSinhVienLop.AutoGenerateColumns = false;
            this.gcSinhVienLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcSinhVienLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Diem});
            this.gcSinhVienLop.DataSource = this.bdsSinhVienLop;
            this.gcSinhVienLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSinhVienLop.Location = new System.Drawing.Point(0, 25);
            this.gcSinhVienLop.Name = "gcSinhVienLop";
            this.gcSinhVienLop.Size = new System.Drawing.Size(845, 673);
            this.gcSinhVienLop.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã sinh viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "hoten";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // Diem
            // 
            this.Diem.HeaderText = "Điểm";
            this.Diem.Name = "Diem";
            this.Diem.Width = 300;
            // 
            // frmDiem
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 789);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcSinhVienLop);
            this.Controls.Add(this.fillToolStrip);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiem";
            this.Text = "frmDiem";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_timDiemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVienLop)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVienLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ds_QLDSV ds_QLDSV;
        private System.Windows.Forms.BindingSource sp_timDiemBindingSource;
        private ds_QLDSVTableAdapters.sp_timDiemTableAdapter sp_timDiemTableAdapter;
        private ds_QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.BindingSource bdsSinhVienLop;
        private ds_QLDSVTableAdapters.sp_SinhVienLopTableAdapter sp_SinhVienLopTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel malopToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txtMaLop;
        private System.Windows.Forms.DataGridView gcSinhVienLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
    }
}
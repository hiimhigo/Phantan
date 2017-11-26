namespace QLDSV
{
    partial class frmForm
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
            this.sp_nhapDiemSVLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_nhapDiemSVLopTableAdapter = new QLDSV.ds_QLDSVTableAdapters.sp_nhapDiemSVLopTableAdapter();
            this.tableAdapterManager = new QLDSV.ds_QLDSVTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.malopToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.malopToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.lanToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.lanToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.mamhToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mamhToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sp_nhapDiemSVLopDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMTableAdapter = new QLDSV.ds_QLDSVTableAdapters.DIEMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_nhapDiemSVLopBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_nhapDiemSVLopDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ds_QLDSV
            // 
            this.ds_QLDSV.DataSetName = "ds_QLDSV";
            this.ds_QLDSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_nhapDiemSVLopBindingSource
            // 
            this.sp_nhapDiemSVLopBindingSource.DataMember = "sp_nhapDiemSVLop";
            this.sp_nhapDiemSVLopBindingSource.DataSource = this.ds_QLDSV;
            // 
            // sp_nhapDiemSVLopTableAdapter
            // 
            this.sp_nhapDiemSVLopTableAdapter.ClearBeforeFill = true;
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
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malopToolStripLabel,
            this.malopToolStripTextBox,
            this.lanToolStripLabel,
            this.lanToolStripTextBox,
            this.mamhToolStripLabel,
            this.mamhToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1175, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // malopToolStripLabel
            // 
            this.malopToolStripLabel.Name = "malopToolStripLabel";
            this.malopToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.malopToolStripLabel.Text = "malop:";
            // 
            // malopToolStripTextBox
            // 
            this.malopToolStripTextBox.Name = "malopToolStripTextBox";
            this.malopToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // lanToolStripLabel
            // 
            this.lanToolStripLabel.Name = "lanToolStripLabel";
            this.lanToolStripLabel.Size = new System.Drawing.Size(26, 22);
            this.lanToolStripLabel.Text = "lan:";
            // 
            // lanToolStripTextBox
            // 
            this.lanToolStripTextBox.Name = "lanToolStripTextBox";
            this.lanToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // mamhToolStripLabel
            // 
            this.mamhToolStripLabel.Name = "mamhToolStripLabel";
            this.mamhToolStripLabel.Size = new System.Drawing.Size(45, 22);
            this.mamhToolStripLabel.Text = "mamh:";
            // 
            // mamhToolStripTextBox
            // 
            this.mamhToolStripTextBox.Name = "mamhToolStripTextBox";
            this.mamhToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // sp_nhapDiemSVLopDataGridView
            // 
            this.sp_nhapDiemSVLopDataGridView.AutoGenerateColumns = false;
            this.sp_nhapDiemSVLopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_nhapDiemSVLopDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.sp_nhapDiemSVLopDataGridView.DataSource = this.sp_nhapDiemSVLopBindingSource;
            this.sp_nhapDiemSVLopDataGridView.Location = new System.Drawing.Point(7, 38);
            this.sp_nhapDiemSVLopDataGridView.Name = "sp_nhapDiemSVLopDataGridView";
            this.sp_nhapDiemSVLopDataGridView.Size = new System.Drawing.Size(1168, 560);
            this.sp_nhapDiemSVLopDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DIEM";
            this.dataGridViewTextBoxColumn3.HeaderText = "DIEM";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "hoten";
            this.dataGridViewTextBoxColumn2.HeaderText = "hoten";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MASV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dIEMBindingSource
            // 
            this.dIEMBindingSource.DataMember = "DIEM";
            this.dIEMBindingSource.DataSource = this.ds_QLDSV;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // frmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sp_nhapDiemSVLopDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Name = "frmForm";
            this.Text = "frmForm";
            this.Load += new System.EventHandler(this.frmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_nhapDiemSVLopBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_nhapDiemSVLopDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ds_QLDSV ds_QLDSV;
        private System.Windows.Forms.BindingSource sp_nhapDiemSVLopBindingSource;
        private ds_QLDSVTableAdapters.sp_nhapDiemSVLopTableAdapter sp_nhapDiemSVLopTableAdapter;
        private ds_QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel malopToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox malopToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel lanToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox lanToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel mamhToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox mamhToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView sp_nhapDiemSVLopDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource dIEMBindingSource;
        private ds_QLDSVTableAdapters.DIEMTableAdapter dIEMTableAdapter;
    }
}
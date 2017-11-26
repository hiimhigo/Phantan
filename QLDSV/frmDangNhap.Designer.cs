namespace QLDSV
{
    partial class frmDangNhap
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
            System.Windows.Forms.Label tENKHOALabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.cbxTenKhoa = new System.Windows.Forms.ComboBox();
            this.bds_DSPM = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPM = new QLDSV.DS_DSPM();
            this.v_DS_PHANMANHTableAdapter = new QLDSV.DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLDSV.DS_DSPMTableAdapters.TableAdapterManager();
            tENKHOALabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            this.SuspendLayout();
            // 
            // tENKHOALabel
            // 
            tENKHOALabel.AutoSize = true;
            tENKHOALabel.Location = new System.Drawing.Point(98, 50);
            tENKHOALabel.Name = "tENKHOALabel";
            tENKHOALabel.Size = new System.Drawing.Size(77, 19);
            tENKHOALabel.TabIndex = 0;
            tENKHOALabel.Text = "Tên Khoa :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnDangNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(tENKHOALabel);
            this.groupBox1.Controls.Add(this.cbxTenKhoa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(298, 217);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(181, 48);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(102, 217);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(171, 48);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài Khoản";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(240, 167);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(239, 26);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.Text = "12345";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(240, 105);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(239, 26);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // cbxTenKhoa
            // 
            this.cbxTenKhoa.DataSource = this.bds_DSPM;
            this.cbxTenKhoa.DisplayMember = "TENKHOA";
            this.cbxTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenKhoa.FormattingEnabled = true;
            this.cbxTenKhoa.Location = new System.Drawing.Point(240, 42);
            this.cbxTenKhoa.Name = "cbxTenKhoa";
            this.cbxTenKhoa.Size = new System.Drawing.Size(239, 27);
            this.cbxTenKhoa.TabIndex = 1;
            this.cbxTenKhoa.ValueMember = "TENSERVER";
            this.cbxTenKhoa.SelectedIndexChanged += new System.EventHandler(this.tENKHOAComboBox_SelectedIndexChanged);
            // 
            // bds_DSPM
            // 
            this.bds_DSPM.DataMember = "V_DS_PHANMANH";
            this.bds_DSPM.DataSource = this.dS_DSPM;
            // 
            // dS_DSPM
            // 
            this.dS_DSPM.DataSetName = "DS_DSPM";
            this.dS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DS_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDangNhap
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 310);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.BindingSource bds_DSPM;
        private DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbxTenKhoa;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Button btnThoat;
    }
}
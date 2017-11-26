namespace QLDSV
{
    partial class frmLop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAKHLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnReloadLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatLop = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.ds_QLDSV = new QLDSV.ds_QLDSV();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.ds_QLDSVTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.ds_QLDSVTableAdapters.TableAdapterManager();
            this.sINHVIENTableAdapter = new QLDSV.ds_QLDSVTableAdapters.SINHVIENTableAdapter();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(107, 42);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(64, 17);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(107, 99);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(69, 17);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(107, 160);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(57, 17);
            mAKHLabel.TabIndex = 4;
            mAKHLabel.Text = "MAKH:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemLop,
            this.btnSuaLop,
            this.btnGhiLop,
            this.btnXoaLop,
            this.btnPhucHoiLop,
            this.btnReloadLop,
            this.btnThoatLop});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemLop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaLop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiLop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaLop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiLop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReloadLop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatLop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemLop
            // 
            this.btnThemLop.Caption = "Thêm";
            this.btnThemLop.Id = 0;
            this.btnThemLop.ImageOptions.Image = global::QLDSV.Properties.Resources.Button_Add_24_icon;
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemLop_ItemClick);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Caption = "Sửa";
            this.btnSuaLop.Id = 1;
            this.btnSuaLop.ImageOptions.Image = global::QLDSV.Properties.Resources.edit;
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaLop_ItemClick);
            // 
            // btnGhiLop
            // 
            this.btnGhiLop.Caption = "Ghi";
            this.btnGhiLop.Id = 2;
            this.btnGhiLop.ImageOptions.Image = global::QLDSV.Properties.Resources.Save_icon_24;
            this.btnGhiLop.Name = "btnGhiLop";
            this.btnGhiLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiLop_ItemClick);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Caption = "Xóa";
            this.btnXoaLop.Id = 3;
            this.btnXoaLop.ImageOptions.Image = global::QLDSV.Properties.Resources.Delete_2_icon_24;
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaLop_ItemClick);
            // 
            // btnPhucHoiLop
            // 
            this.btnPhucHoiLop.Caption = "Phục hồi";
            this.btnPhucHoiLop.Id = 4;
            this.btnPhucHoiLop.ImageOptions.Image = global::QLDSV.Properties.Resources.Undo_icon_24;
            this.btnPhucHoiLop.Name = "btnPhucHoiLop";
            this.btnPhucHoiLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiLop_ItemClick);
            // 
            // btnReloadLop
            // 
            this.btnReloadLop.Caption = "Reset";
            this.btnReloadLop.Id = 5;
            this.btnReloadLop.ImageOptions.Image = global::QLDSV.Properties.Resources.Button_Refresh_icon_24;
            this.btnReloadLop.Name = "btnReloadLop";
            this.btnReloadLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadLop_ItemClick);
            // 
            // btnThoatLop
            // 
            this.btnThoatLop.Caption = "Thoát";
            this.btnThoatLop.Id = 6;
            this.btnThoatLop.ImageOptions.Image = global::QLDSV.Properties.Resources.exit;
            this.btnThoatLop.Name = "btnThoatLop";
            this.btnThoatLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatLop_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1289, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 761);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1289, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 729);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1289, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 729);
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(137, 26);
            this.cbxKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(357, 25);
            this.cbxKhoa.TabIndex = 4;
            this.cbxKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxKhoa_SelectedIndexChanged);
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
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.ds_QLDSVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLop.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcLop.Location = new System.Drawing.Point(0, 105);
            this.gcLop.MainView = this.gridView1;
            this.gcLop.Margin = new System.Windows.Forms.Padding(4);
            this.gcLop.MenuManager = this.barManager1;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(1289, 318);
            this.gcLop.TabIndex = 6;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
            this.gridView1.GridControl = this.gcLop;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "Tên lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Mã khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên khoa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(mAKHLabel);
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Controls.Add(tENLOPLabel);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1289, 312);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MAKH", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(241, 152);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(250, 25);
            this.txtMaKhoa.TabIndex = 5;
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "TENLOP", true));
            this.txtTenLop.Location = new System.Drawing.Point(241, 91);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(250, 25);
            this.txtTenLop.TabIndex = 3;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(241, 34);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(250, 25);
            this.txtMaLop.TabIndex = 1;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSinhVien.DataSource = this.bdsLop;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxKhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 73);
            this.panel1.TabIndex = 13;
            // 
            // frmLop
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 761);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcLop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLop";
            this.Text = "Lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsLop;
        private ds_QLDSV ds_QLDSV;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private ds_QLDSVTableAdapters.LOPTableAdapter lOPTableAdapter;
        private ds_QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraBars.BarButtonItem btnThemLop;
        private DevExpress.XtraBars.BarButtonItem btnSuaLop;
        private DevExpress.XtraBars.BarButtonItem btnGhiLop;
        private DevExpress.XtraBars.BarButtonItem btnXoaLop;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiLop;
        private DevExpress.XtraBars.BarButtonItem btnReloadLop;
        private DevExpress.XtraBars.BarButtonItem btnThoatLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private ds_QLDSVTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Panel panel1;
    }
}
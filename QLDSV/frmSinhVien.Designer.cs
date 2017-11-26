namespace QLDSV
{
    partial class frmSinhVien
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label nOISINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGHIHOCLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnReloadSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatSV = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ds_QLDSV = new QLDSV.ds_QLDSV();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV.ds_QLDSVTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.ds_QLDSVTableAdapters.TableAdapterManager();
            this.gcSinhVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOISINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxMaLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHAICheckBox = new System.Windows.Forms.CheckBox();
            this.nGHIHOCCheckBox = new System.Windows.Forms.CheckBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.dtPNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtHoSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lOPTableAdapter = new QLDSV.ds_QLDSVTableAdapters.LOPTableAdapter();
            this.bdsDiem = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMTableAdapter = new QLDSV.ds_QLDSVTableAdapters.DIEMTableAdapter();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            nOISINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGHIHOCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLDSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(27, 62);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(95, 17);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "Mã Sinh Viên :";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(27, 120);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(33, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ :";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(27, 168);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(38, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên :";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(27, 221);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(57, 17);
            mALOPLabel.TabIndex = 6;
            mALOPLabel.Text = "Mã lớp :";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(473, 65);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(41, 17);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "Phái :";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(473, 117);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(67, 17);
            nGAYSINHLabel.TabIndex = 10;
            nGAYSINHLabel.Text = "Ngày sinh";
            // 
            // nOISINHLabel
            // 
            nOISINHLabel.AutoSize = true;
            nOISINHLabel.Location = new System.Drawing.Point(473, 168);
            nOISINHLabel.Name = "nOISINHLabel";
            nOISINHLabel.Size = new System.Drawing.Size(59, 17);
            nOISINHLabel.TabIndex = 12;
            nOISINHLabel.Text = "Nơi Sinh";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(473, 221);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(57, 17);
            dIACHILabel.TabIndex = 14;
            dIACHILabel.Text = "Địa chỉ :";
            // 
            // nGHIHOCLabel
            // 
            nGHIHOCLabel.AutoSize = true;
            nGHIHOCLabel.Location = new System.Drawing.Point(473, 266);
            nGHIHOCLabel.Name = "nGHIHOCLabel";
            nGHIHOCLabel.Size = new System.Drawing.Size(61, 17);
            nGHIHOCLabel.TabIndex = 16;
            nGHIHOCLabel.Text = "Nghỉ học";
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
            this.btnThemSV,
            this.btnSuaSV,
            this.btnXoaSV,
            this.btnGhiSV,
            this.btnPhucHoiSV,
            this.btnReloadSV,
            this.btnThoatSV});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(263, 147);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReloadSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatSV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemSV
            // 
            this.btnThemSV.Caption = "Thêm";
            this.btnThemSV.Id = 0;
            this.btnThemSV.ImageOptions.Image = global::QLDSV.Properties.Resources.Button_Add_24_icon;
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemSV_ItemClick);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Caption = "Sửa";
            this.btnSuaSV.Id = 1;
            this.btnSuaSV.ImageOptions.Image = global::QLDSV.Properties.Resources.edit;
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaSV_ItemClick);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Caption = "Xóa";
            this.btnXoaSV.Id = 2;
            this.btnXoaSV.ImageOptions.Image = global::QLDSV.Properties.Resources.Delete_2_icon_24;
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaSV_ItemClick);
            // 
            // btnGhiSV
            // 
            this.btnGhiSV.Caption = "Ghi";
            this.btnGhiSV.Id = 3;
            this.btnGhiSV.ImageOptions.Image = global::QLDSV.Properties.Resources.Save_icon_24;
            this.btnGhiSV.Name = "btnGhiSV";
            this.btnGhiSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiSV_ItemClick);
            // 
            // btnPhucHoiSV
            // 
            this.btnPhucHoiSV.Caption = "Phục hồi";
            this.btnPhucHoiSV.Id = 4;
            this.btnPhucHoiSV.ImageOptions.Image = global::QLDSV.Properties.Resources.Undo_icon_24;
            this.btnPhucHoiSV.Name = "btnPhucHoiSV";
            this.btnPhucHoiSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiSV_ItemClick);
            // 
            // btnReloadSV
            // 
            this.btnReloadSV.Caption = "Refresh";
            this.btnReloadSV.Id = 5;
            this.btnReloadSV.ImageOptions.Image = global::QLDSV.Properties.Resources.Button_Refresh_icon_24;
            this.btnReloadSV.Name = "btnReloadSV";
            this.btnReloadSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadSV_ItemClick);
            // 
            // btnThoatSV
            // 
            this.btnThoatSV.Caption = "Thoát";
            this.btnThoatSV.Id = 6;
            this.btnThoatSV.ImageOptions.Image = global::QLDSV.Properties.Resources.exit;
            this.btnThoatSV.Name = "btnThoatSV";
            this.btnThoatSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatSV_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1412, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 851);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1412, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 819);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1412, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 819);
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(120, 12);
            this.cbxKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(420, 25);
            this.cbxKhoa.TabIndex = 4;
            this.cbxKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên Khoa";
            // 
            // ds_QLDSV
            // 
            this.ds_QLDSV.DataSetName = "ds_QLDSV";
            this.ds_QLDSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "SINHVIEN";
            this.bdsSinhVien.DataSource = this.ds_QLDSV;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.ds_QLDSVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcSinhVien
            // 
            this.gcSinhVien.DataSource = this.bdsSinhVien;
            this.gcSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSinhVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcSinhVien.Location = new System.Drawing.Point(0, 92);
            this.gcSinhVien.MainView = this.gridView1;
            this.gcSinhVien.MenuManager = this.barManager1;
            this.gcSinhVien.Name = "gcSinhVien";
            this.gcSinhVien.Size = new System.Drawing.Size(1412, 361);
            this.gcSinhVien.TabIndex = 7;
            this.gcSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colMALOP,
            this.colPHAI,
            this.colNGAYSINH,
            this.colNOISINH,
            this.colDIACHI,
            this.colGHICHU,
            this.colNGHIHOC});
            this.gridView1.GridControl = this.gcSinhVien;
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã sinh viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 3;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            // 
            // colNOISINH
            // 
            this.colNOISINH.Caption = "Nơi sinh";
            this.colNOISINH.FieldName = "NOISINH";
            this.colNOISINH.Name = "colNOISINH";
            this.colNOISINH.Visible = true;
            this.colNOISINH.VisibleIndex = 6;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 7;
            // 
            // colGHICHU
            // 
            this.colGHICHU.Caption = "Ghi chú";
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 8;
            // 
            // colNGHIHOC
            // 
            this.colNGHIHOC.Caption = "Nghỉ học";
            this.colNGHIHOC.FieldName = "NGHIHOC";
            this.colNGHIHOC.Name = "colNGHIHOC";
            this.colNGHIHOC.Visible = true;
            this.colNGHIHOC.VisibleIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxMaLop);
            this.groupBox1.Controls.Add(this.pHAICheckBox);
            this.groupBox1.Controls.Add(nGHIHOCLabel);
            this.groupBox1.Controls.Add(this.nGHIHOCCheckBox);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(nOISINHLabel);
            this.groupBox1.Controls.Add(this.txtNoiSinh);
            this.groupBox1.Controls.Add(nGAYSINHLabel);
            this.groupBox1.Controls.Add(this.dtPNgaySinh);
            this.groupBox1.Controls.Add(pHAILabel);
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.txtTenSV);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.txtHoSV);
            this.groupBox1.Controls.Add(mASVLabel);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 453);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1412, 566);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // cbxMaLop
            // 
            this.cbxMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.cbxMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaLop.FormattingEnabled = true;
            this.cbxMaLop.Location = new System.Drawing.Point(159, 218);
            this.cbxMaLop.Name = "cbxMaLop";
            this.cbxMaLop.Size = new System.Drawing.Size(252, 25);
            this.cbxMaLop.TabIndex = 19;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.ds_QLDSV;
            // 
            // pHAICheckBox
            // 
            this.pHAICheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsSinhVien, "PHAI", true));
            this.pHAICheckBox.Location = new System.Drawing.Point(632, 62);
            this.pHAICheckBox.Name = "pHAICheckBox";
            this.pHAICheckBox.Size = new System.Drawing.Size(104, 24);
            this.pHAICheckBox.TabIndex = 18;
            this.pHAICheckBox.Text = "Nữ";
            this.pHAICheckBox.UseVisualStyleBackColor = true;
            // 
            // nGHIHOCCheckBox
            // 
            this.nGHIHOCCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsSinhVien, "NGHIHOC", true));
            this.nGHIHOCCheckBox.Location = new System.Drawing.Point(632, 266);
            this.nGHIHOCCheckBox.Name = "nGHIHOCCheckBox";
            this.nGHIHOCCheckBox.Size = new System.Drawing.Size(104, 24);
            this.nGHIHOCCheckBox.TabIndex = 17;
            this.nGHIHOCCheckBox.Text = "đã nghỉ";
            this.nGHIHOCCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(632, 213);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(185, 25);
            this.txtDiaChi.TabIndex = 15;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "NOISINH", true));
            this.txtNoiSinh.Location = new System.Drawing.Point(632, 168);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(185, 25);
            this.txtNoiSinh.TabIndex = 13;
            // 
            // dtPNgaySinh
            // 
            this.dtPNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsSinhVien, "NGAYSINH", true));
            this.dtPNgaySinh.Location = new System.Drawing.Point(632, 120);
            this.dtPNgaySinh.Name = "dtPNgaySinh";
            this.dtPNgaySinh.Size = new System.Drawing.Size(384, 25);
            this.dtPNgaySinh.TabIndex = 11;
            // 
            // txtTenSV
            // 
            this.txtTenSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "TEN", true));
            this.txtTenSV.Location = new System.Drawing.Point(159, 168);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(252, 25);
            this.txtTenSV.TabIndex = 5;
            // 
            // txtHoSV
            // 
            this.txtHoSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "HO", true));
            this.txtHoSV.Location = new System.Drawing.Point(159, 117);
            this.txtHoSV.Name = "txtHoSV";
            this.txtHoSV.Size = new System.Drawing.Size(252, 25);
            this.txtHoSV.TabIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(159, 61);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(252, 25);
            this.txtMaSV.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxKhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 60);
            this.panel1.TabIndex = 13;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDiem
            // 
            this.bdsDiem.DataMember = "FK_DIEM_SINHVIEN";
            this.bdsDiem.DataSource = this.bdsSinhVien;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // frmSinhVien
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 851);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcSinhVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSinhVien";
            this.Text = "Sinh Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLDSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiem)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnThemSV;
        private DevExpress.XtraBars.BarButtonItem btnSuaSV;
        private DevExpress.XtraBars.BarButtonItem btnXoaSV;
        private DevExpress.XtraBars.BarButtonItem btnGhiSV;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiSV;
        private DevExpress.XtraBars.BarButtonItem btnReloadSV;
        private DevExpress.XtraBars.BarButtonItem btnThoatSV;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private ds_QLDSV ds_QLDSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private ds_QLDSVTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private ds_QLDSVTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox nGHIHOCCheckBox;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.DateTimePicker dtPNgaySinh;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtHoSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOISINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGHIHOC;
        private System.Windows.Forms.CheckBox pHAICheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private ds_QLDSVTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox cbxMaLop;
        private System.Windows.Forms.BindingSource bdsDiem;
        private ds_QLDSVTableAdapters.DIEMTableAdapter dIEMTableAdapter;
    }
}
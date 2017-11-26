namespace QLDSV
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemDiem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.sttFrmMain = new System.Windows.Forms.StatusStrip();
            this.MaGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.Nhom = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.sttFrmMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barDangNhap,
            this.btnThoat,
            this.btnLop,
            this.btnSinhVien,
            this.btnMonHoc,
            this.btnDiem,
            this.btnXemDiem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.rbpDanhMuc});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1168, 143);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // barDangNhap
            // 
            this.barDangNhap.Caption = "Đăng Nhập";
            this.barDangNhap.Id = 1;
            this.barDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barDangNhap.ImageOptions.Image")));
            this.barDangNhap.Name = "barDangNhap";
            this.barDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDangNhap_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 2;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Id = 3;
            this.btnLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLop.ImageOptions.Image")));
            this.btnLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLop.ImageOptions.LargeImage")));
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh Viên";
            this.btnSinhVien.Id = 4;
            this.btnSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.ImageOptions.LargeImage")));
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn Học";
            this.btnMonHoc.Id = 5;
            this.btnMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.LargeImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnDiem
            // 
            this.btnDiem.Caption = "Điểm";
            this.btnDiem.Id = 6;
            this.btnDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDiem.ImageOptions.Image")));
            this.btnDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDiem.ImageOptions.LargeImage")));
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDiem_ItemClick);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Caption = "Xem Điểm";
            this.btnXemDiem.Id = 7;
            this.btnXemDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDiem.ImageOptions.Image")));
            this.btnXemDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemDiem.ImageOptions.LargeImage")));
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemDiem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản trị";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // rbpDanhMuc
            // 
            this.rbpDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.rbpDanhMuc.Name = "rbpDanhMuc";
            this.rbpDanhMuc.Text = "Danh Mục";
            this.rbpDanhMuc.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLop);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSinhVien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDiem);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnXemDiem);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // sttFrmMain
            // 
            this.sttFrmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaGV,
            this.HoTen,
            this.Nhom});
            this.sttFrmMain.Location = new System.Drawing.Point(0, 641);
            this.sttFrmMain.Name = "sttFrmMain";
            this.sttFrmMain.Size = new System.Drawing.Size(1168, 22);
            this.sttFrmMain.TabIndex = 2;
            this.sttFrmMain.Text = "statusStrip1";
            // 
            // MaGV
            // 
            this.MaGV.Name = "MaGV";
            this.MaGV.Size = new System.Drawing.Size(24, 17);
            this.MaGV.Text = "Ma";
            // 
            // HoTen
            // 
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(43, 17);
            this.HoTen.Text = "HoTen";
            // 
            // Nhom
            // 
            this.Nhom.Name = "Nhom";
            this.Nhom.Size = new System.Drawing.Size(41, 17);
            this.Nhom.Text = "Nhom";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 663);
            this.Controls.Add(this.sttFrmMain);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QLDSV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.sttFrmMain.ResumeLayout(false);
            this.sttFrmMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barDangNhap;
        public System.Windows.Forms.ToolStripStatusLabel MaGV;
        public System.Windows.Forms.ToolStripStatusLabel HoTen;
        public System.Windows.Forms.ToolStripStatusLabel Nhom;
        public DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip sttFrmMain;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbpDanhMuc;
        private DevExpress.XtraBars.BarButtonItem btnXemDiem;
    }
}



namespace THUVIEN
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label gIOITINHLabel;
            System.Windows.Forms.Label cCCDLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label tRANGTHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new THUVIEN.QUANLYTHUVIENDataSet();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIOITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCCCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl_NV = new System.Windows.Forms.Panel();
            this.checkTrangThai = new DevExpress.XtraEditors.CheckEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtCCCD = new DevExpress.XtraEditors.TextEdit();
            this.checkGioiTinh = new DevExpress.XtraEditors.CheckEdit();
            this.deNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            mANVLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            cCCDLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            tRANGTHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelControl_NV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(51, 56);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(133, 19);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "MÃ NHÂN VIÊN:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(51, 112);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(45, 19);
            tENLabel.TabIndex = 2;
            tENLabel.Text = "TÊN:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYSINHLabel.Location = new System.Drawing.Point(51, 173);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(101, 19);
            nGAYSINHLabel.TabIndex = 4;
            nGAYSINHLabel.Text = "NGÀY SINH:";
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gIOITINHLabel.Location = new System.Drawing.Point(51, 230);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(144, 19);
            gIOITINHLabel.TabIndex = 6;
            gIOITINHLabel.Text = "GIỚI TÍNH (NAM):";
            // 
            // cCCDLabel
            // 
            cCCDLabel.AutoSize = true;
            cCCDLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cCCDLabel.Location = new System.Drawing.Point(489, 56);
            cCCDLabel.Name = "cCCDLabel";
            cCCDLabel.Size = new System.Drawing.Size(59, 19);
            cCCDLabel.TabIndex = 8;
            cCCDLabel.Text = "CCCD:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(489, 112);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(43, 19);
            sDTLabel.TabIndex = 10;
            sDTLabel.Text = "SDT:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMAILLabel.Location = new System.Drawing.Point(489, 173);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(65, 19);
            eMAILLabel.TabIndex = 12;
            eMAILLabel.Text = "EMAIL:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(489, 230);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(73, 19);
            dIACHILabel.TabIndex = 14;
            dIACHILabel.Text = "ĐỊA CHỈ:";
            // 
            // tRANGTHAILabel
            // 
            tRANGTHAILabel.AutoSize = true;
            tRANGTHAILabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRANGTHAILabel.Location = new System.Drawing.Point(830, 56);
            tRANGTHAILabel.Name = "tRANGTHAILabel";
            tRANGTHAILabel.Size = new System.Drawing.Size(161, 19);
            tRANGTHAILabel.TabIndex = 16;
            tRANGTHAILabel.Text = "ĐANG HOẠT ĐỘNG:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnLuu,
            this.btnPhucHoi,
            this.btnReload,
            this.btnChuyenChiNhanh,
            this.btnThoat,
            this.btnTaoTaiKhoan});
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaoTaiKhoan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHieuChinh.ImageOptions.SvgImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 2;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Id = 8;
            this.btnTaoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.SvgImage")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1329, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 791);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1329, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 761);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1329, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 761);
            // 
            // btnChuyenChiNhanh
            // 
            this.btnChuyenChiNhanh.Caption = "Chuyển chi nhánh nhân viên";
            this.btnChuyenChiNhanh.Id = 6;
            this.btnChuyenChiNhanh.Name = "btnChuyenChiNhanh";
            // 
            // DS
            // 
            this.DS.DataSetName = "QUANLYTHUVIENDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NHANVIEN";
            this.bdsNV.DataSource = this.DS;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.NHAXUATBANTableAdapter = null;
            this.tableAdapterManager.PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.QUYENTableAdapter = null;
            this.tableAdapterManager.SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.THETHUVIENTableAdapter = null;
            this.tableAdapterManager.TINHTRANGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.DataSource = this.bdsNV;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcNhanVien.Location = new System.Drawing.Point(0, 30);
            this.gcNhanVien.MainView = this.gridView1;
            this.gcNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.gcNhanVien.MenuManager = this.barManager1;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1329, 326);
            this.gcNhanVien.TabIndex = 5;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTEN,
            this.colNGAYSINH,
            this.colGIOITINH,
            this.colCCCD,
            this.colSDT,
            this.colEMAIL,
            this.colDIACHI,
            this.colMANV,
            this.colTRANGTHAI});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcNhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMANV, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colTEN
            // 
            this.colTEN.Caption = "TÊN NHÂN VIÊN";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.OptionsColumn.AllowFocus = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 1;
            this.colTEN.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "NGÀY SINH";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.OptionsColumn.AllowFocus = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 2;
            this.colNGAYSINH.Width = 94;
            // 
            // colGIOITINH
            // 
            this.colGIOITINH.Caption = "GIỚI TÍNH";
            this.colGIOITINH.FieldName = "GIOITINH";
            this.colGIOITINH.MinWidth = 25;
            this.colGIOITINH.Name = "colGIOITINH";
            this.colGIOITINH.OptionsColumn.AllowEdit = false;
            this.colGIOITINH.OptionsColumn.AllowFocus = false;
            this.colGIOITINH.Visible = true;
            this.colGIOITINH.VisibleIndex = 3;
            this.colGIOITINH.Width = 94;
            // 
            // colCCCD
            // 
            this.colCCCD.Caption = "CCCD";
            this.colCCCD.FieldName = "CCCD";
            this.colCCCD.MinWidth = 25;
            this.colCCCD.Name = "colCCCD";
            this.colCCCD.OptionsColumn.AllowEdit = false;
            this.colCCCD.OptionsColumn.AllowFocus = false;
            this.colCCCD.Visible = true;
            this.colCCCD.VisibleIndex = 4;
            this.colCCCD.Width = 94;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "SỐ ĐIỆN THOẠI";
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsColumn.AllowEdit = false;
            this.colSDT.OptionsColumn.AllowFocus = false;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 5;
            this.colSDT.Width = 94;
            // 
            // colEMAIL
            // 
            this.colEMAIL.Caption = "EMAIL";
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.MinWidth = 25;
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.OptionsColumn.AllowEdit = false;
            this.colEMAIL.OptionsColumn.AllowFocus = false;
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 6;
            this.colEMAIL.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "ĐỊA CHỈ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.OptionsColumn.AllowFocus = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 7;
            this.colDIACHI.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "MÃ NHÂN VIÊN";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.OptionsColumn.AllowFocus = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 94;
            // 
            // colTRANGTHAI
            // 
            this.colTRANGTHAI.Caption = "TRẠNG THÁI";
            this.colTRANGTHAI.FieldName = "TRANGTHAI";
            this.colTRANGTHAI.MinWidth = 25;
            this.colTRANGTHAI.Name = "colTRANGTHAI";
            this.colTRANGTHAI.OptionsColumn.AllowEdit = false;
            this.colTRANGTHAI.OptionsColumn.AllowFocus = false;
            this.colTRANGTHAI.Visible = true;
            this.colTRANGTHAI.VisibleIndex = 8;
            this.colTRANGTHAI.Width = 94;
            // 
            // panelControl_NV
            // 
            this.panelControl_NV.Controls.Add(tRANGTHAILabel);
            this.panelControl_NV.Controls.Add(this.checkTrangThai);
            this.panelControl_NV.Controls.Add(dIACHILabel);
            this.panelControl_NV.Controls.Add(this.txtDiaChi);
            this.panelControl_NV.Controls.Add(eMAILLabel);
            this.panelControl_NV.Controls.Add(this.txtEmail);
            this.panelControl_NV.Controls.Add(sDTLabel);
            this.panelControl_NV.Controls.Add(this.txtSDT);
            this.panelControl_NV.Controls.Add(cCCDLabel);
            this.panelControl_NV.Controls.Add(this.txtCCCD);
            this.panelControl_NV.Controls.Add(gIOITINHLabel);
            this.panelControl_NV.Controls.Add(this.checkGioiTinh);
            this.panelControl_NV.Controls.Add(nGAYSINHLabel);
            this.panelControl_NV.Controls.Add(this.deNgaySinh);
            this.panelControl_NV.Controls.Add(tENLabel);
            this.panelControl_NV.Controls.Add(this.txtTen);
            this.panelControl_NV.Controls.Add(mANVLabel);
            this.panelControl_NV.Controls.Add(this.txtMaNV);
            this.panelControl_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_NV.Location = new System.Drawing.Point(0, 356);
            this.panelControl_NV.Name = "panelControl_NV";
            this.panelControl_NV.Size = new System.Drawing.Size(1329, 435);
            this.panelControl_NV.TabIndex = 6;
            // 
            // checkTrangThai
            // 
            this.checkTrangThai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TRANGTHAI", true));
            this.checkTrangThai.Location = new System.Drawing.Point(1009, 54);
            this.checkTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.checkTrangThai.MenuManager = this.barManager1;
            this.checkTrangThai.Name = "checkTrangThai";
            this.checkTrangThai.Properties.Caption = "";
            this.checkTrangThai.Size = new System.Drawing.Size(31, 24);
            this.checkTrangThai.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(568, 227);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(367, 26);
            this.txtDiaChi.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "EMAIL", true));
            this.txtEmail.Location = new System.Drawing.Point(568, 170);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MenuManager = this.barManager1;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(229, 26);
            this.txtEmail.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(568, 109);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(121, 26);
            this.txtSDT.TabIndex = 11;
            // 
            // txtCCCD
            // 
            this.txtCCCD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "CCCD", true));
            this.txtCCCD.Location = new System.Drawing.Point(568, 53);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCCD.MenuManager = this.barManager1;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Properties.Appearance.Options.UseFont = true;
            this.txtCCCD.Size = new System.Drawing.Size(135, 26);
            this.txtCCCD.TabIndex = 9;
            // 
            // checkGioiTinh
            // 
            this.checkGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "GIOITINH", true));
            this.checkGioiTinh.Location = new System.Drawing.Point(217, 228);
            this.checkGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.checkGioiTinh.MenuManager = this.barManager1;
            this.checkGioiTinh.Name = "checkGioiTinh";
            this.checkGioiTinh.Properties.Caption = "";
            this.checkGioiTinh.Size = new System.Drawing.Size(25, 24);
            this.checkGioiTinh.TabIndex = 7;
            // 
            // deNgaySinh
            // 
            this.deNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "NGAYSINH", true));
            this.deNgaySinh.EditValue = null;
            this.deNgaySinh.Location = new System.Drawing.Point(204, 170);
            this.deNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.deNgaySinh.MenuManager = this.barManager1;
            this.deNgaySinh.Name = "deNgaySinh";
            this.deNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.deNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgaySinh.Size = new System.Drawing.Size(156, 26);
            this.deNgaySinh.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(204, 109);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(192, 26);
            this.txtTen.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(204, 53);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(156, 26);
            this.txtMaNV.TabIndex = 1;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 811);
            this.Controls.Add(this.panelControl_NV);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelControl_NV.ResumeLayout(false);
            this.panelControl_NV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private System.Windows.Forms.BindingSource bdsNV;
        private QUANLYTHUVIENDataSet DS;
        private QUANLYTHUVIENDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panelControl_NV;
        private DevExpress.XtraEditors.CheckEdit checkTrangThai;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtCCCD;
        private DevExpress.XtraEditors.CheckEdit checkGioiTinh;
        private DevExpress.XtraEditors.DateEdit deNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colGIOITINH;
        private DevExpress.XtraGrid.Columns.GridColumn colCCCD;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANGTHAI;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
    }
}
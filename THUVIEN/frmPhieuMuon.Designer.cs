
namespace THUVIEN
{
    partial class frmPhieuMuon
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
            System.Windows.Forms.Label mATHELabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label nGAYMUONLabel;
            System.Windows.Forms.Label sOLUONGMUONTOIDALabel;
            System.Windows.Forms.Label mASACHLabel;
            System.Windows.Forms.Label hANTRALabel;
            System.Windows.Forms.Label gHICHULabel;
            System.Windows.Forms.Label mATINHTRANGLabel;
            System.Windows.Forms.Label tINHTRANGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuMuon));
            this.DS = new THUVIEN.QUANLYTHUVIENDataSet();
            this.bdsPhieuMuon = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUMUONTableAdapter = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.PHIEUMUONTableAdapter();
            this.tableAdapterManager = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager();
            this.cT_PHIEUMUONTableAdapter = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.CT_PHIEUMUONTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.gcPhieuMuon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPHIEUMUON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATHE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMUON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGMUONTOIDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelInput = new DevExpress.XtraEditors.PanelControl();
            this.cmbTinhTrang = new System.Windows.Forms.ComboBox();
            this.bdsTT = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTPM = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.btnChonSach = new System.Windows.Forms.Button();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtHanTra = new DevExpress.XtraEditors.DateEdit();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnChonThe = new System.Windows.Forms.Button();
            this.spnMaxSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txtNgayMuon = new DevExpress.XtraEditors.DateEdit();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.gcCTPM = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPHIEUMUON1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHANTRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemCT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiCT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaCT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHuyCT = new System.Windows.Forms.ToolStripMenuItem();
            this.tINHTRANGTableAdapter = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TINHTRANGTableAdapter();
            mATHELabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            nGAYMUONLabel = new System.Windows.Forms.Label();
            sOLUONGMUONTOIDALabel = new System.Windows.Forms.Label();
            mASACHLabel = new System.Windows.Forms.Label();
            hANTRALabel = new System.Windows.Forms.Label();
            gHICHULabel = new System.Windows.Forms.Label();
            mATINHTRANGLabel = new System.Windows.Forms.Label();
            tINHTRANGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHanTra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHanTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayMuon.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayMuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mATHELabel
            // 
            mATHELabel.AutoSize = true;
            mATHELabel.Location = new System.Drawing.Point(280, 33);
            mATHELabel.Name = "mATHELabel";
            mATHELabel.Size = new System.Drawing.Size(60, 17);
            mATHELabel.TabIndex = 2;
            mATHELabel.Text = "MÃ THẺ:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(12, 83);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(103, 17);
            mANVLabel.TabIndex = 4;
            mANVLabel.Text = "MÃ NHÂN VIÊN:";
            // 
            // nGAYMUONLabel
            // 
            nGAYMUONLabel.AutoSize = true;
            nGAYMUONLabel.Location = new System.Drawing.Point(251, 84);
            nGAYMUONLabel.Name = "nGAYMUONLabel";
            nGAYMUONLabel.Size = new System.Drawing.Size(90, 17);
            nGAYMUONLabel.TabIndex = 6;
            nGAYMUONLabel.Text = "NGÀY MƯỢN:";
            // 
            // sOLUONGMUONTOIDALabel
            // 
            sOLUONGMUONTOIDALabel.AutoSize = true;
            sOLUONGMUONTOIDALabel.Location = new System.Drawing.Point(165, 142);
            sOLUONGMUONTOIDALabel.Name = "sOLUONGMUONTOIDALabel";
            sOLUONGMUONTOIDALabel.Size = new System.Drawing.Size(171, 17);
            sOLUONGMUONTOIDALabel.TabIndex = 8;
            sOLUONGMUONTOIDALabel.Text = "SỐ LƯỢNG MƯỢN TỐI ĐA:";
            // 
            // mASACHLabel
            // 
            mASACHLabel.AutoSize = true;
            mASACHLabel.Location = new System.Drawing.Point(276, 212);
            mASACHLabel.Name = "mASACHLabel";
            mASACHLabel.Size = new System.Drawing.Size(69, 17);
            mASACHLabel.TabIndex = 11;
            mASACHLabel.Text = "MÃ SÁCH:";
            // 
            // hANTRALabel
            // 
            hANTRALabel.AutoSize = true;
            hANTRALabel.Location = new System.Drawing.Point(276, 309);
            hANTRALabel.Name = "hANTRALabel";
            hANTRALabel.Size = new System.Drawing.Size(68, 17);
            hANTRALabel.TabIndex = 12;
            hANTRALabel.Text = "HẠN TRẢ:";
            // 
            // gHICHULabel
            // 
            gHICHULabel.AutoSize = true;
            gHICHULabel.Location = new System.Drawing.Point(279, 357);
            gHICHULabel.Name = "gHICHULabel";
            gHICHULabel.Size = new System.Drawing.Size(66, 17);
            gHICHULabel.TabIndex = 14;
            gHICHULabel.Text = "GHI CHÚ:";
            // 
            // mATINHTRANGLabel
            // 
            mATINHTRANGLabel.AutoSize = true;
            mATINHTRANGLabel.Location = new System.Drawing.Point(231, 261);
            mATINHTRANGLabel.Name = "mATINHTRANGLabel";
            mATINHTRANGLabel.Size = new System.Drawing.Size(112, 17);
            mATINHTRANGLabel.TabIndex = 17;
            mATINHTRANGLabel.Text = "MÃ TÌNH TRẠNG:";
            // 
            // tINHTRANGLabel
            // 
            tINHTRANGLabel.AutoSize = true;
            tINHTRANGLabel.Location = new System.Drawing.Point(12, 261);
            tINHTRANGLabel.Name = "tINHTRANGLabel";
            tINHTRANGLabel.Size = new System.Drawing.Size(86, 17);
            tINHTRANGLabel.TabIndex = 19;
            tINHTRANGLabel.Text = "TINHTRANG:";
            // 
            // DS
            // 
            this.DS.DataSetName = "QUANLYTHUVIENDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPhieuMuon
            // 
            this.bdsPhieuMuon.DataMember = "PHIEUMUON";
            this.bdsPhieuMuon.DataSource = this.DS;
            // 
            // pHIEUMUONTableAdapter
            // 
            this.pHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHIEUMUONTableAdapter = this.cT_PHIEUMUONTableAdapter;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAXUATBANTableAdapter = null;
            this.tableAdapterManager.PHIEUMUONTableAdapter = this.pHIEUMUONTableAdapter;
            this.tableAdapterManager.QUYENTableAdapter = null;
            this.tableAdapterManager.SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.THETHUVIENTableAdapter = null;
            this.tableAdapterManager.TINHTRANGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cT_PHIEUMUONTableAdapter
            // 
            this.cT_PHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnLuu,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnChuyenChiNhanh,
            this.btnThoat});
            this.barManager1.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
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
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1195, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 674);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1195, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 644);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1195, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 644);
            // 
            // btnChuyenChiNhanh
            // 
            this.btnChuyenChiNhanh.Caption = "Chuyển chi nhánh nhân viên";
            this.btnChuyenChiNhanh.Id = 6;
            this.btnChuyenChiNhanh.Name = "btnChuyenChiNhanh";
            // 
            // gcPhieuMuon
            // 
            this.gcPhieuMuon.DataSource = this.bdsPhieuMuon;
            this.gcPhieuMuon.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuMuon.Location = new System.Drawing.Point(0, 30);
            this.gcPhieuMuon.MainView = this.gridView1;
            this.gcPhieuMuon.MenuManager = this.barManager1;
            this.gcPhieuMuon.Name = "gcPhieuMuon";
            this.gcPhieuMuon.Size = new System.Drawing.Size(1195, 235);
            this.gcPhieuMuon.TabIndex = 4;
            this.gcPhieuMuon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPHIEUMUON,
            this.colMATHE,
            this.colMANV,
            this.colNGAYMUON,
            this.colSOLUONGMUONTOIDA});
            this.gridView1.GridControl = this.gcPhieuMuon;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPHIEUMUON
            // 
            this.colMAPHIEUMUON.Caption = "MÃ PHIẾU MƯỢN";
            this.colMAPHIEUMUON.FieldName = "MAPHIEUMUON";
            this.colMAPHIEUMUON.MinWidth = 25;
            this.colMAPHIEUMUON.Name = "colMAPHIEUMUON";
            this.colMAPHIEUMUON.OptionsColumn.AllowEdit = false;
            this.colMAPHIEUMUON.OptionsColumn.AllowFocus = false;
            this.colMAPHIEUMUON.Visible = true;
            this.colMAPHIEUMUON.VisibleIndex = 0;
            this.colMAPHIEUMUON.Width = 94;
            // 
            // colMATHE
            // 
            this.colMATHE.Caption = "MÃ THẺ";
            this.colMATHE.FieldName = "MATHE";
            this.colMATHE.MinWidth = 25;
            this.colMATHE.Name = "colMATHE";
            this.colMATHE.OptionsColumn.AllowEdit = false;
            this.colMATHE.OptionsColumn.AllowFocus = false;
            this.colMATHE.Visible = true;
            this.colMATHE.VisibleIndex = 1;
            this.colMATHE.Width = 94;
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
            this.colMANV.VisibleIndex = 2;
            this.colMANV.Width = 94;
            // 
            // colNGAYMUON
            // 
            this.colNGAYMUON.Caption = "NGÀY MƯỢN";
            this.colNGAYMUON.FieldName = "NGAYMUON";
            this.colNGAYMUON.MinWidth = 25;
            this.colNGAYMUON.Name = "colNGAYMUON";
            this.colNGAYMUON.OptionsColumn.AllowEdit = false;
            this.colNGAYMUON.OptionsColumn.AllowFocus = false;
            this.colNGAYMUON.Visible = true;
            this.colNGAYMUON.VisibleIndex = 3;
            this.colNGAYMUON.Width = 94;
            // 
            // colSOLUONGMUONTOIDA
            // 
            this.colSOLUONGMUONTOIDA.Caption = "SỐ LƯỢNG MƯỢN TỐI ĐA";
            this.colSOLUONGMUONTOIDA.FieldName = "SOLUONGMUONTOIDA";
            this.colSOLUONGMUONTOIDA.MinWidth = 25;
            this.colSOLUONGMUONTOIDA.Name = "colSOLUONGMUONTOIDA";
            this.colSOLUONGMUONTOIDA.OptionsColumn.AllowEdit = false;
            this.colSOLUONGMUONTOIDA.OptionsColumn.AllowFocus = false;
            this.colSOLUONGMUONTOIDA.Visible = true;
            this.colSOLUONGMUONTOIDA.VisibleIndex = 4;
            this.colSOLUONGMUONTOIDA.Width = 94;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(tINHTRANGLabel);
            this.panelInput.Controls.Add(this.cmbTinhTrang);
            this.panelInput.Controls.Add(mATINHTRANGLabel);
            this.panelInput.Controls.Add(this.txtMaTT);
            this.panelInput.Controls.Add(this.btnChonSach);
            this.panelInput.Controls.Add(gHICHULabel);
            this.panelInput.Controls.Add(this.txtGhiChu);
            this.panelInput.Controls.Add(hANTRALabel);
            this.panelInput.Controls.Add(this.txtHanTra);
            this.panelInput.Controls.Add(mASACHLabel);
            this.panelInput.Controls.Add(this.txtMaSach);
            this.panelInput.Controls.Add(this.separatorControl1);
            this.panelInput.Controls.Add(this.btnChonThe);
            this.panelInput.Controls.Add(sOLUONGMUONTOIDALabel);
            this.panelInput.Controls.Add(this.spnMaxSoLuong);
            this.panelInput.Controls.Add(nGAYMUONLabel);
            this.panelInput.Controls.Add(this.txtNgayMuon);
            this.panelInput.Controls.Add(mANVLabel);
            this.panelInput.Controls.Add(this.txtmaNV);
            this.panelInput.Controls.Add(mATHELabel);
            this.panelInput.Controls.Add(this.txtMaThe);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput.Location = new System.Drawing.Point(0, 265);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(560, 409);
            this.panelInput.TabIndex = 5;
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTT, "TINHTRANG", true));
            this.cmbTinhTrang.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsCTPM, "MATINHTRANG", true));
            this.cmbTinhTrang.FormattingEnabled = true;
            this.cmbTinhTrang.Location = new System.Drawing.Point(104, 258);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(121, 24);
            this.cmbTinhTrang.TabIndex = 20;
            this.cmbTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cmbTinhTrang_SelectedIndexChanged);
            // 
            // bdsTT
            // 
            this.bdsTT.DataMember = "TINHTRANG";
            this.bdsTT.DataSource = this.DS;
            // 
            // bdsCTPM
            // 
            this.bdsCTPM.DataMember = "FK_CT_PHIEUMUON_PHIEUMUON";
            this.bdsCTPM.DataSource = this.bdsPhieuMuon;
            // 
            // txtMaTT
            // 
            this.txtMaTT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPM, "MATINHTRANG", true));
            this.txtMaTT.Enabled = false;
            this.txtMaTT.Location = new System.Drawing.Point(346, 258);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(154, 23);
            this.txtMaTT.TabIndex = 18;
            // 
            // btnChonSach
            // 
            this.btnChonSach.Enabled = false;
            this.btnChonSach.Location = new System.Drawing.Point(72, 205);
            this.btnChonSach.Name = "btnChonSach";
            this.btnChonSach.Size = new System.Drawing.Size(127, 31);
            this.btnChonSach.TabIndex = 16;
            this.btnChonSach.Text = "Chọn sách";
            this.btnChonSach.UseVisualStyleBackColor = true;
            this.btnChonSach.Click += new System.EventHandler(this.btnChonSach_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPM, "GHICHU", true));
            this.txtGhiChu.Location = new System.Drawing.Point(347, 354);
            this.txtGhiChu.MenuManager = this.barManager1;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(155, 22);
            this.txtGhiChu.TabIndex = 15;
            // 
            // txtHanTra
            // 
            this.txtHanTra.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPM, "HANTRA", true));
            this.txtHanTra.EditValue = null;
            this.txtHanTra.Location = new System.Drawing.Point(346, 306);
            this.txtHanTra.MenuManager = this.barManager1;
            this.txtHanTra.Name = "txtHanTra";
            this.txtHanTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHanTra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHanTra.Size = new System.Drawing.Size(155, 22);
            this.txtHanTra.TabIndex = 13;
            // 
            // txtMaSach
            // 
            this.txtMaSach.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPM, "MASACH", true));
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Location = new System.Drawing.Point(347, 209);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(154, 23);
            this.txtMaSach.TabIndex = 12;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(13, 168);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(527, 23);
            this.separatorControl1.TabIndex = 11;
            // 
            // btnChonThe
            // 
            this.btnChonThe.Location = new System.Drawing.Point(72, 26);
            this.btnChonThe.Name = "btnChonThe";
            this.btnChonThe.Size = new System.Drawing.Size(127, 31);
            this.btnChonThe.TabIndex = 10;
            this.btnChonThe.Text = " Chọn thẻ";
            this.btnChonThe.UseVisualStyleBackColor = true;
            this.btnChonThe.Click += new System.EventHandler(this.btnChonThe_Click);
            // 
            // spnMaxSoLuong
            // 
            this.spnMaxSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuMuon, "SOLUONGMUONTOIDA", true));
            this.spnMaxSoLuong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnMaxSoLuong.Location = new System.Drawing.Point(342, 138);
            this.spnMaxSoLuong.MenuManager = this.barManager1;
            this.spnMaxSoLuong.Name = "spnMaxSoLuong";
            this.spnMaxSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnMaxSoLuong.Properties.IsFloatValue = false;
            this.spnMaxSoLuong.Properties.Mask.EditMask = "N00";
            this.spnMaxSoLuong.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.spnMaxSoLuong.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnMaxSoLuong.Size = new System.Drawing.Size(159, 24);
            this.spnMaxSoLuong.TabIndex = 9;
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuMuon, "NGAYMUON", true));
            this.txtNgayMuon.EditValue = null;
            this.txtNgayMuon.Enabled = false;
            this.txtNgayMuon.Location = new System.Drawing.Point(342, 81);
            this.txtNgayMuon.MenuManager = this.barManager1;
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayMuon.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayMuon.Size = new System.Drawing.Size(159, 22);
            this.txtNgayMuon.TabIndex = 7;
            // 
            // txtmaNV
            // 
            this.txtmaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuMuon, "MANV", true));
            this.txtmaNV.Enabled = false;
            this.txtmaNV.Location = new System.Drawing.Point(121, 80);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(92, 23);
            this.txtmaNV.TabIndex = 5;
            this.txtmaNV.TextChanged += new System.EventHandler(this.txtmaNV_TextChanged);
            // 
            // txtMaThe
            // 
            this.txtMaThe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuMuon, "MATHE", true));
            this.txtMaThe.Enabled = false;
            this.txtMaThe.Location = new System.Drawing.Point(342, 30);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(159, 23);
            this.txtMaThe.TabIndex = 3;
            // 
            // gcCTPM
            // 
            this.gcCTPM.DataSource = this.bdsCTPM;
            this.gcCTPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPM.Location = new System.Drawing.Point(560, 265);
            this.gcCTPM.MainView = this.gridView2;
            this.gcCTPM.MenuManager = this.barManager1;
            this.gcCTPM.Name = "gcCTPM";
            this.gcCTPM.Size = new System.Drawing.Size(635, 409);
            this.gcCTPM.TabIndex = 6;
            this.gcCTPM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPHIEUMUON1,
            this.colMASACH,
            this.colMATINHTRANG,
            this.colHANTRA,
            this.colGHICHU});
            this.gridView2.GridControl = this.gcCTPM;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPHIEUMUON1
            // 
            this.colMAPHIEUMUON1.Caption = "MÃ PHIẾU MƯỢN";
            this.colMAPHIEUMUON1.FieldName = "MAPHIEUMUON";
            this.colMAPHIEUMUON1.MinWidth = 25;
            this.colMAPHIEUMUON1.Name = "colMAPHIEUMUON1";
            this.colMAPHIEUMUON1.OptionsColumn.AllowEdit = false;
            this.colMAPHIEUMUON1.OptionsColumn.AllowFocus = false;
            this.colMAPHIEUMUON1.Visible = true;
            this.colMAPHIEUMUON1.VisibleIndex = 0;
            this.colMAPHIEUMUON1.Width = 94;
            // 
            // colMASACH
            // 
            this.colMASACH.Caption = "MÃ SÁCH";
            this.colMASACH.FieldName = "MASACH";
            this.colMASACH.MinWidth = 25;
            this.colMASACH.Name = "colMASACH";
            this.colMASACH.OptionsColumn.AllowEdit = false;
            this.colMASACH.OptionsColumn.AllowFocus = false;
            this.colMASACH.Visible = true;
            this.colMASACH.VisibleIndex = 1;
            this.colMASACH.Width = 94;
            // 
            // colMATINHTRANG
            // 
            this.colMATINHTRANG.Caption = "TÌNH TRẠNG";
            this.colMATINHTRANG.FieldName = "MATINHTRANG";
            this.colMATINHTRANG.MinWidth = 25;
            this.colMATINHTRANG.Name = "colMATINHTRANG";
            this.colMATINHTRANG.OptionsColumn.AllowEdit = false;
            this.colMATINHTRANG.OptionsColumn.AllowFocus = false;
            this.colMATINHTRANG.Visible = true;
            this.colMATINHTRANG.VisibleIndex = 2;
            this.colMATINHTRANG.Width = 94;
            // 
            // colHANTRA
            // 
            this.colHANTRA.Caption = "HẠN TRẢ";
            this.colHANTRA.FieldName = "HANTRA";
            this.colHANTRA.MinWidth = 25;
            this.colHANTRA.Name = "colHANTRA";
            this.colHANTRA.OptionsColumn.AllowEdit = false;
            this.colHANTRA.OptionsColumn.AllowFocus = false;
            this.colHANTRA.Visible = true;
            this.colHANTRA.VisibleIndex = 3;
            this.colHANTRA.Width = 94;
            // 
            // colGHICHU
            // 
            this.colGHICHU.Caption = "GHI CHÚ";
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.MinWidth = 25;
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.OptionsColumn.AllowEdit = false;
            this.colGHICHU.OptionsColumn.AllowFocus = false;
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 4;
            this.colGHICHU.Width = 94;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemCT,
            this.btnGhiCT,
            this.btnXoaCT,
            this.btnHuyCT});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 100);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(164, 24);
            this.btnThemCT.Text = "Thêm chi tiết";
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // btnGhiCT
            // 
            this.btnGhiCT.Name = "btnGhiCT";
            this.btnGhiCT.Size = new System.Drawing.Size(164, 24);
            this.btnGhiCT.Text = "Ghi chi tiết";
            this.btnGhiCT.Click += new System.EventHandler(this.btnGhiCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(164, 24);
            this.btnXoaCT.Text = "Xoá chi tiết";
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnHuyCT
            // 
            this.btnHuyCT.Enabled = false;
            this.btnHuyCT.Name = "btnHuyCT";
            this.btnHuyCT.Size = new System.Drawing.Size(164, 24);
            this.btnHuyCT.Text = "Huỷ";
            this.btnHuyCT.Click += new System.EventHandler(this.btnHuyCT_Click);
            // 
            // tINHTRANGTableAdapter
            // 
            this.tINHTRANGTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 674);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gcCTPM);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.gcPhieuMuon);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuMuon";
            this.Text = "frmPhieuMuon";
            this.Load += new System.EventHandler(this.frmPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHanTra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHanTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayMuon.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayMuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QUANLYTHUVIENDataSet DS;
        private System.Windows.Forms.BindingSource bdsPhieuMuon;
        private QUANLYTHUVIENDataSetTableAdapters.PHIEUMUONTableAdapter pHIEUMUONTableAdapter;
        private QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcPhieuMuon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHIEUMUON;
        private DevExpress.XtraGrid.Columns.GridColumn colMATHE;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMUON;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGMUONTOIDA;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private QUANLYTHUVIENDataSetTableAdapters.CT_PHIEUMUONTableAdapter cT_PHIEUMUONTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelInput;
        private System.Windows.Forms.BindingSource bdsCTPM;
        private DevExpress.XtraGrid.GridControl gcCTPM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHIEUMUON1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASACH;
        private DevExpress.XtraGrid.Columns.GridColumn colMATINHTRANG;
        private DevExpress.XtraGrid.Columns.GridColumn colHANTRA;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private System.Windows.Forms.Button btnChonThe;
        private DevExpress.XtraEditors.SpinEdit spnMaxSoLuong;
        private DevExpress.XtraEditors.DateEdit txtNgayMuon;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.TextBox txtMaThe;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemCT;
        private System.Windows.Forms.ToolStripMenuItem btnGhiCT;
        private System.Windows.Forms.ToolStripMenuItem btnXoaCT;
        private System.Windows.Forms.ToolStripMenuItem btnHuyCT;
        private System.Windows.Forms.Button btnChonSach;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.DateEdit txtHanTra;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.BindingSource bdsTT;
        private QUANLYTHUVIENDataSetTableAdapters.TINHTRANGTableAdapter tINHTRANGTableAdapter;
        private System.Windows.Forms.ComboBox cmbTinhTrang;
    }
}
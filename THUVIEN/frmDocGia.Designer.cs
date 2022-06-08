
namespace THUVIEN
{
    partial class frmDocGia
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
            System.Windows.Forms.Label mADOCGIALabel;
            System.Windows.Forms.Label mATHELabel;
            System.Windows.Forms.Label tENDOCGIALabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label gIOITINHLabel;
            System.Windows.Forms.Label cCCDLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocGia));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new THUVIEN.QUANLYTHUVIENDataSet();
            this.bdsDocGia = new System.Windows.Forms.BindingSource(this.components);
            this.dOCGIATableAdapter = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.DOCGIATableAdapter();
            this.tableAdapterManager = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager();
            this.gcDocGia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADOCGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATHE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENDOCGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIOITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCCCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl_DocGia = new System.Windows.Forms.Panel();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtCCCD = new DevExpress.XtraEditors.TextEdit();
            this.checkGioiTinh = new DevExpress.XtraEditors.CheckEdit();
            this.deNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtTenDocGia = new DevExpress.XtraEditors.TextEdit();
            this.txtMaThe = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDocGia = new DevExpress.XtraEditors.TextEdit();
            mADOCGIALabel = new System.Windows.Forms.Label();
            mATHELabel = new System.Windows.Forms.Label();
            tENDOCGIALabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            cCCDLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelControl_DocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDocGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaThe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDocGia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mADOCGIALabel
            // 
            mADOCGIALabel.AutoSize = true;
            mADOCGIALabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mADOCGIALabel.Location = new System.Drawing.Point(64, 41);
            mADOCGIALabel.Name = "mADOCGIALabel";
            mADOCGIALabel.Size = new System.Drawing.Size(111, 19);
            mADOCGIALabel.TabIndex = 0;
            mADOCGIALabel.Text = "MÃ ĐỘC GIẢ:";
            // 
            // mATHELabel
            // 
            mATHELabel.AutoSize = true;
            mATHELabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mATHELabel.Location = new System.Drawing.Point(64, 99);
            mATHELabel.Name = "mATHELabel";
            mATHELabel.Size = new System.Drawing.Size(75, 19);
            mATHELabel.TabIndex = 2;
            mATHELabel.Text = "MÃ THẺ:";
            // 
            // tENDOCGIALabel
            // 
            tENDOCGIALabel.AutoSize = true;
            tENDOCGIALabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENDOCGIALabel.Location = new System.Drawing.Point(64, 161);
            tENDOCGIALabel.Name = "tENDOCGIALabel";
            tENDOCGIALabel.Size = new System.Drawing.Size(116, 19);
            tENDOCGIALabel.TabIndex = 4;
            tENDOCGIALabel.Text = "TÊN ĐỘC GIẢ:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYSINHLabel.Location = new System.Drawing.Point(64, 221);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(101, 19);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "NGÀY SINH:";
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gIOITINHLabel.Location = new System.Drawing.Point(64, 276);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(90, 19);
            gIOITINHLabel.TabIndex = 8;
            gIOITINHLabel.Text = "GIỚI TÍNH:";
            // 
            // cCCDLabel
            // 
            cCCDLabel.AutoSize = true;
            cCCDLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cCCDLabel.Location = new System.Drawing.Point(401, 41);
            cCCDLabel.Name = "cCCDLabel";
            cCCDLabel.Size = new System.Drawing.Size(59, 19);
            cCCDLabel.TabIndex = 10;
            cCCDLabel.Text = "CCCD:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(401, 99);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(131, 19);
            sDTLabel.TabIndex = 12;
            sDTLabel.Text = "SỐ ĐIỆN THOẠI:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMAILLabel.Location = new System.Drawing.Point(401, 161);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(65, 19);
            eMAILLabel.TabIndex = 14;
            eMAILLabel.Text = "EMAIL:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(401, 221);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(73, 19);
            dIACHILabel.TabIndex = 16;
            dIACHILabel.Text = "ĐỊA CHỈ:";
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
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnChuyenChiNhanh,
            this.btnThoat});
            this.barManager1.MaxItemId = 8;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1033, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 650);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1033, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 620);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1033, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 620);
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
            // bdsDocGia
            // 
            this.bdsDocGia.DataMember = "DOCGIA";
            this.bdsDocGia.DataSource = this.DS;
            // 
            // dOCGIATableAdapter
            // 
            this.dOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = this.dOCGIATableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
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
            // gcDocGia
            // 
            this.gcDocGia.DataSource = this.bdsDocGia;
            this.gcDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDocGia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcDocGia.Location = new System.Drawing.Point(0, 30);
            this.gcDocGia.MainView = this.gridView1;
            this.gcDocGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcDocGia.MenuManager = this.barManager1;
            this.gcDocGia.Name = "gcDocGia";
            this.gcDocGia.Size = new System.Drawing.Size(1033, 350);
            this.gcDocGia.TabIndex = 5;
            this.gcDocGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADOCGIA,
            this.colMATHE,
            this.colTENDOCGIA,
            this.colNGAYSINH,
            this.colGIOITINH,
            this.colCCCD,
            this.colSDT,
            this.colEMAIL,
            this.colDIACHI});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcDocGia;
            this.gridView1.Name = "gridView1";
            // 
            // colMADOCGIA
            // 
            this.colMADOCGIA.Caption = "MÃ ĐỘC GIẢ";
            this.colMADOCGIA.FieldName = "MADOCGIA";
            this.colMADOCGIA.MinWidth = 31;
            this.colMADOCGIA.Name = "colMADOCGIA";
            this.colMADOCGIA.OptionsColumn.AllowEdit = false;
            this.colMADOCGIA.OptionsColumn.AllowFocus = false;
            this.colMADOCGIA.Visible = true;
            this.colMADOCGIA.VisibleIndex = 0;
            this.colMADOCGIA.Width = 117;
            // 
            // colMATHE
            // 
            this.colMATHE.Caption = "MÃ THẺ";
            this.colMATHE.FieldName = "MATHE";
            this.colMATHE.MinWidth = 31;
            this.colMATHE.Name = "colMATHE";
            this.colMATHE.OptionsColumn.AllowEdit = false;
            this.colMATHE.OptionsColumn.AllowFocus = false;
            this.colMATHE.Visible = true;
            this.colMATHE.VisibleIndex = 1;
            this.colMATHE.Width = 117;
            // 
            // colTENDOCGIA
            // 
            this.colTENDOCGIA.Caption = "TÊN ĐỘC GIẢ";
            this.colTENDOCGIA.FieldName = "TENDOCGIA";
            this.colTENDOCGIA.MinWidth = 31;
            this.colTENDOCGIA.Name = "colTENDOCGIA";
            this.colTENDOCGIA.OptionsColumn.AllowEdit = false;
            this.colTENDOCGIA.OptionsColumn.AllowFocus = false;
            this.colTENDOCGIA.Visible = true;
            this.colTENDOCGIA.VisibleIndex = 2;
            this.colTENDOCGIA.Width = 117;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "NGÀY SINH";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 31;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.OptionsColumn.AllowFocus = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            this.colNGAYSINH.Width = 117;
            // 
            // colGIOITINH
            // 
            this.colGIOITINH.Caption = "GIỚI TÍNH";
            this.colGIOITINH.FieldName = "GIOITINH";
            this.colGIOITINH.MinWidth = 31;
            this.colGIOITINH.Name = "colGIOITINH";
            this.colGIOITINH.OptionsColumn.AllowEdit = false;
            this.colGIOITINH.OptionsColumn.AllowFocus = false;
            this.colGIOITINH.Visible = true;
            this.colGIOITINH.VisibleIndex = 4;
            this.colGIOITINH.Width = 117;
            // 
            // colCCCD
            // 
            this.colCCCD.FieldName = "CCCD";
            this.colCCCD.MinWidth = 31;
            this.colCCCD.Name = "colCCCD";
            this.colCCCD.OptionsColumn.AllowEdit = false;
            this.colCCCD.OptionsColumn.AllowFocus = false;
            this.colCCCD.Visible = true;
            this.colCCCD.VisibleIndex = 5;
            this.colCCCD.Width = 117;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "SỐ ĐIỆN THOẠI";
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 31;
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsColumn.AllowEdit = false;
            this.colSDT.OptionsColumn.AllowFocus = false;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 6;
            this.colSDT.Width = 117;
            // 
            // colEMAIL
            // 
            this.colEMAIL.Caption = "EMAIL";
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.MinWidth = 31;
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.OptionsColumn.AllowEdit = false;
            this.colEMAIL.OptionsColumn.AllowFocus = false;
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 7;
            this.colEMAIL.Width = 117;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "ĐỊA CHỈ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 31;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.OptionsColumn.AllowFocus = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 8;
            this.colDIACHI.Width = 117;
            // 
            // panelControl_DocGia
            // 
            this.panelControl_DocGia.Controls.Add(dIACHILabel);
            this.panelControl_DocGia.Controls.Add(this.txtDiaChi);
            this.panelControl_DocGia.Controls.Add(eMAILLabel);
            this.panelControl_DocGia.Controls.Add(this.txtEmail);
            this.panelControl_DocGia.Controls.Add(sDTLabel);
            this.panelControl_DocGia.Controls.Add(this.txtSDT);
            this.panelControl_DocGia.Controls.Add(cCCDLabel);
            this.panelControl_DocGia.Controls.Add(this.txtCCCD);
            this.panelControl_DocGia.Controls.Add(gIOITINHLabel);
            this.panelControl_DocGia.Controls.Add(this.checkGioiTinh);
            this.panelControl_DocGia.Controls.Add(nGAYSINHLabel);
            this.panelControl_DocGia.Controls.Add(this.deNgaySinh);
            this.panelControl_DocGia.Controls.Add(tENDOCGIALabel);
            this.panelControl_DocGia.Controls.Add(this.txtTenDocGia);
            this.panelControl_DocGia.Controls.Add(mATHELabel);
            this.panelControl_DocGia.Controls.Add(this.txtMaThe);
            this.panelControl_DocGia.Controls.Add(mADOCGIALabel);
            this.panelControl_DocGia.Controls.Add(this.txtMaDocGia);
            this.panelControl_DocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_DocGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl_DocGia.Location = new System.Drawing.Point(0, 380);
            this.panelControl_DocGia.Name = "panelControl_DocGia";
            this.panelControl_DocGia.Size = new System.Drawing.Size(1033, 270);
            this.panelControl_DocGia.TabIndex = 6;
            this.panelControl_DocGia.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(546, 218);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(336, 26);
            this.txtDiaChi.TabIndex = 17;
            this.txtDiaChi.EditValueChanged += new System.EventHandler(this.dIACHITextEdit_EditValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "EMAIL", true));
            this.txtEmail.Location = new System.Drawing.Point(546, 158);
            this.txtEmail.MenuManager = this.barManager1;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(194, 26);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.EditValueChanged += new System.EventHandler(this.eMAILTextEdit_EditValueChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(546, 96);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(125, 26);
            this.txtSDT.TabIndex = 13;
            this.txtSDT.EditValueChanged += new System.EventHandler(this.sDTTextEdit_EditValueChanged);
            // 
            // txtCCCD
            // 
            this.txtCCCD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "CCCD", true));
            this.txtCCCD.Location = new System.Drawing.Point(546, 38);
            this.txtCCCD.MenuManager = this.barManager1;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Properties.Appearance.Options.UseFont = true;
            this.txtCCCD.Size = new System.Drawing.Size(125, 26);
            this.txtCCCD.TabIndex = 11;
            this.txtCCCD.EditValueChanged += new System.EventHandler(this.cCCDTextEdit_EditValueChanged);
            // 
            // checkGioiTinh
            // 
            this.checkGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "GIOITINH", true));
            this.checkGioiTinh.Location = new System.Drawing.Point(196, 274);
            this.checkGioiTinh.MenuManager = this.barManager1;
            this.checkGioiTinh.Name = "checkGioiTinh";
            this.checkGioiTinh.Properties.Caption = "";
            this.checkGioiTinh.Size = new System.Drawing.Size(27, 24);
            this.checkGioiTinh.TabIndex = 9;
            // 
            // deNgaySinh
            // 
            this.deNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "NGAYSINH", true));
            this.deNgaySinh.EditValue = null;
            this.deNgaySinh.Location = new System.Drawing.Point(196, 218);
            this.deNgaySinh.MenuManager = this.barManager1;
            this.deNgaySinh.Name = "deNgaySinh";
            this.deNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.deNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgaySinh.Size = new System.Drawing.Size(125, 26);
            this.deNgaySinh.TabIndex = 7;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "TENDOCGIA", true));
            this.txtTenDocGia.Location = new System.Drawing.Point(196, 158);
            this.txtTenDocGia.MenuManager = this.barManager1;
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDocGia.Properties.Appearance.Options.UseFont = true;
            this.txtTenDocGia.Size = new System.Drawing.Size(199, 26);
            this.txtTenDocGia.TabIndex = 5;
            this.txtTenDocGia.EditValueChanged += new System.EventHandler(this.tENDOCGIATextEdit_EditValueChanged);
            // 
            // txtMaThe
            // 
            this.txtMaThe.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "MATHE", true));
            this.txtMaThe.Location = new System.Drawing.Point(196, 96);
            this.txtMaThe.MenuManager = this.barManager1;
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThe.Properties.Appearance.Options.UseFont = true;
            this.txtMaThe.Size = new System.Drawing.Size(45, 26);
            this.txtMaThe.TabIndex = 3;
            this.txtMaThe.EditValueChanged += new System.EventHandler(this.mATHETextEdit_EditValueChanged);
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "MADOCGIA", true));
            this.txtMaDocGia.Location = new System.Drawing.Point(196, 38);
            this.txtMaDocGia.MenuManager = this.barManager1;
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDocGia.Properties.Appearance.Options.UseFont = true;
            this.txtMaDocGia.Size = new System.Drawing.Size(40, 26);
            this.txtMaDocGia.TabIndex = 1;
            this.txtMaDocGia.EditValueChanged += new System.EventHandler(this.mADOCGIATextEdit_EditValueChanged);
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 670);
            this.Controls.Add(this.panelControl_DocGia);
            this.Controls.Add(this.gcDocGia);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDocGia";
            this.Text = "frmDocGia";
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelControl_DocGia.ResumeLayout(false);
            this.panelControl_DocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDocGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaThe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDocGia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDocGia;
        private QUANLYTHUVIENDataSet DS;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private QUANLYTHUVIENDataSetTableAdapters.DOCGIATableAdapter dOCGIATableAdapter;
        private QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panelControl_DocGia;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtCCCD;
        private DevExpress.XtraEditors.CheckEdit checkGioiTinh;
        private DevExpress.XtraEditors.DateEdit deNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtTenDocGia;
        private DevExpress.XtraEditors.TextEdit txtMaThe;
        private DevExpress.XtraEditors.TextEdit txtMaDocGia;
        private DevExpress.XtraGrid.GridControl gcDocGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADOCGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colMATHE;
        private DevExpress.XtraGrid.Columns.GridColumn colTENDOCGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colGIOITINH;
        private DevExpress.XtraGrid.Columns.GridColumn colCCCD;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
    }
}

namespace THUVIEN
{
    partial class frmTacGia
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
            System.Windows.Forms.Label mATACGIALabel;
            System.Windows.Forms.Label tENTACGIALabel;
            System.Windows.Forms.Label tIEUSULabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTacGia));
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
            this.bdsTacGia = new System.Windows.Forms.BindingSource(this.components);
            this.tACGIATableAdapter = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TACGIATableAdapter();
            this.tableAdapterManager = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager();
            this.gcTacGia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMATACGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTACGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIEUSU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl_TacGia = new System.Windows.Forms.Panel();
            this.txtTieuSu = new System.Windows.Forms.TextBox();
            this.txtTenTacGia = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTacGia = new DevExpress.XtraEditors.TextEdit();
            this.bdsSach = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.SACHTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            mATACGIALabel = new System.Windows.Forms.Label();
            tENTACGIALabel = new System.Windows.Forms.Label();
            tIEUSULabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelControl_TacGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTacGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTacGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mATACGIALabel
            // 
            mATACGIALabel.AutoSize = true;
            mATACGIALabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mATACGIALabel.Location = new System.Drawing.Point(67, 49);
            mATACGIALabel.Name = "mATACGIALabel";
            mATACGIALabel.Size = new System.Drawing.Size(107, 19);
            mATACGIALabel.TabIndex = 0;
            mATACGIALabel.Text = "MÃ TÁC GIẢ:";
            // 
            // tENTACGIALabel
            // 
            tENTACGIALabel.AutoSize = true;
            tENTACGIALabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENTACGIALabel.Location = new System.Drawing.Point(420, 49);
            tENTACGIALabel.Name = "tENTACGIALabel";
            tENTACGIALabel.Size = new System.Drawing.Size(112, 19);
            tENTACGIALabel.TabIndex = 2;
            tENTACGIALabel.Text = "TÊN TÁC GIẢ:";
            // 
            // tIEUSULabel
            // 
            tIEUSULabel.AutoSize = true;
            tIEUSULabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tIEUSULabel.Location = new System.Drawing.Point(67, 132);
            tIEUSULabel.Name = "tIEUSULabel";
            tIEUSULabel.Size = new System.Drawing.Size(76, 19);
            tIEUSULabel.TabIndex = 4;
            tIEUSULabel.Text = "TIỂU SỬ:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1102, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 667);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1102, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 637);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1102, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 637);
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
            // bdsTacGia
            // 
            this.bdsTacGia.DataMember = "TACGIA";
            this.bdsTacGia.DataSource = this.DS;
            // 
            // tACGIATableAdapter
            // 
            this.tACGIATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAXUATBANTableAdapter = null;
            this.tableAdapterManager.PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.QUYENTableAdapter = null;
            this.tableAdapterManager.SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = this.tACGIATableAdapter;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.THETHUVIENTableAdapter = null;
            this.tableAdapterManager.TINHTRANGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcTacGia
            // 
            this.gcTacGia.DataSource = this.bdsTacGia;
            this.gcTacGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTacGia.Location = new System.Drawing.Point(0, 30);
            this.gcTacGia.MainView = this.gridView1;
            this.gcTacGia.MenuManager = this.barManager1;
            this.gcTacGia.Name = "gcTacGia";
            this.gcTacGia.Size = new System.Drawing.Size(1102, 294);
            this.gcTacGia.TabIndex = 5;
            this.gcTacGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMATACGIA,
            this.colTENTACGIA,
            this.colTIEUSU});
            this.gridView1.GridControl = this.gcTacGia;
            this.gridView1.Name = "gridView1";
            // 
            // colMATACGIA
            // 
            this.colMATACGIA.Caption = "MÃ TÁC GIẢ";
            this.colMATACGIA.FieldName = "MATACGIA";
            this.colMATACGIA.MinWidth = 25;
            this.colMATACGIA.Name = "colMATACGIA";
            this.colMATACGIA.OptionsColumn.AllowEdit = false;
            this.colMATACGIA.OptionsColumn.AllowFocus = false;
            this.colMATACGIA.Visible = true;
            this.colMATACGIA.VisibleIndex = 0;
            this.colMATACGIA.Width = 94;
            // 
            // colTENTACGIA
            // 
            this.colTENTACGIA.Caption = "TÊN TÁC GIẢ";
            this.colTENTACGIA.FieldName = "TENTACGIA";
            this.colTENTACGIA.MinWidth = 25;
            this.colTENTACGIA.Name = "colTENTACGIA";
            this.colTENTACGIA.OptionsColumn.AllowEdit = false;
            this.colTENTACGIA.OptionsColumn.AllowFocus = false;
            this.colTENTACGIA.Visible = true;
            this.colTENTACGIA.VisibleIndex = 1;
            this.colTENTACGIA.Width = 94;
            // 
            // colTIEUSU
            // 
            this.colTIEUSU.Caption = "TIỂU SỬ";
            this.colTIEUSU.FieldName = "TIEUSU";
            this.colTIEUSU.MinWidth = 25;
            this.colTIEUSU.Name = "colTIEUSU";
            this.colTIEUSU.OptionsColumn.AllowEdit = false;
            this.colTIEUSU.OptionsColumn.AllowFocus = false;
            this.colTIEUSU.Visible = true;
            this.colTIEUSU.VisibleIndex = 2;
            this.colTIEUSU.Width = 94;
            // 
            // panelControl_TacGia
            // 
            this.panelControl_TacGia.Controls.Add(tIEUSULabel);
            this.panelControl_TacGia.Controls.Add(this.txtTieuSu);
            this.panelControl_TacGia.Controls.Add(tENTACGIALabel);
            this.panelControl_TacGia.Controls.Add(this.txtTenTacGia);
            this.panelControl_TacGia.Controls.Add(mATACGIALabel);
            this.panelControl_TacGia.Controls.Add(this.txtMaTacGia);
            this.panelControl_TacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_TacGia.Location = new System.Drawing.Point(0, 324);
            this.panelControl_TacGia.Name = "panelControl_TacGia";
            this.panelControl_TacGia.Size = new System.Drawing.Size(1102, 343);
            this.panelControl_TacGia.TabIndex = 6;
            // 
            // txtTieuSu
            // 
            this.txtTieuSu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTacGia, "TIEUSU", true));
            this.txtTieuSu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuSu.Location = new System.Drawing.Point(164, 129);
            this.txtTieuSu.Multiline = true;
            this.txtTieuSu.Name = "txtTieuSu";
            this.txtTieuSu.Size = new System.Drawing.Size(633, 176);
            this.txtTieuSu.TabIndex = 5;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTacGia, "TENTACGIA", true));
            this.txtTenTacGia.Location = new System.Drawing.Point(604, 46);
            this.txtTenTacGia.MenuManager = this.barManager1;
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTacGia.Properties.Appearance.Options.UseFont = true;
            this.txtTenTacGia.Size = new System.Drawing.Size(173, 26);
            this.txtTenTacGia.TabIndex = 3;
            this.txtTenTacGia.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenTacGia_Validating);
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTacGia, "MATACGIA", true));
            this.txtMaTacGia.Location = new System.Drawing.Point(251, 46);
            this.txtMaTacGia.MenuManager = this.barManager1;
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTacGia.Properties.Appearance.Options.UseFont = true;
            this.txtMaTacGia.Size = new System.Drawing.Size(97, 26);
            this.txtMaTacGia.TabIndex = 1;
            // 
            // bdsSach
            // 
            this.bdsSach.DataMember = "FK__SACH__MATACGIA__32E0915F";
            this.bdsSach.DataSource = this.bdsTacGia;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 687);
            this.Controls.Add(this.panelControl_TacGia);
            this.Controls.Add(this.gcTacGia);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTacGia";
            this.Text = "frmTacGia";
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelControl_TacGia.ResumeLayout(false);
            this.panelControl_TacGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTacGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTacGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsTacGia;
        private QUANLYTHUVIENDataSet DS;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private QUANLYTHUVIENDataSetTableAdapters.TACGIATableAdapter tACGIATableAdapter;
        private QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTacGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panelControl_TacGia;
        private DevExpress.XtraEditors.TextEdit txtTenTacGia;
        private DevExpress.XtraEditors.TextEdit txtMaTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn colMATACGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTACGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colTIEUSU;
        private System.Windows.Forms.BindingSource bdsSach;
        private QUANLYTHUVIENDataSetTableAdapters.SACHTableAdapter sACHTableAdapter;
        private System.Windows.Forms.TextBox txtTieuSu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
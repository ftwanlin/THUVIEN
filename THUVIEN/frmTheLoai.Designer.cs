
namespace THUVIEN
{
    partial class frmTheLoai
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
            System.Windows.Forms.Label mATHELOAILabel;
            System.Windows.Forms.Label tENTHELOAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheLoai));
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
            this.bdsTheLoai = new System.Windows.Forms.BindingSource(this.components);
            this.tHELOAITableAdapter = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.THELOAITableAdapter();
            this.tableAdapterManager = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager();
            this.gcTheLoai = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMATHELOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTHELOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl_TheLoai = new System.Windows.Forms.Panel();
            this.txtTenTheLoai = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTheLoai = new DevExpress.XtraEditors.TextEdit();
            this.bdsSach = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.SACHTableAdapter();
            mATHELOAILabel = new System.Windows.Forms.Label();
            tENTHELOAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelControl_TheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).BeginInit();
            this.SuspendLayout();
            // 
            // mATHELOAILabel
            // 
            mATHELOAILabel.AutoSize = true;
            mATHELOAILabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mATHELOAILabel.Location = new System.Drawing.Point(52, 49);
            mATHELOAILabel.Name = "mATHELOAILabel";
            mATHELOAILabel.Size = new System.Drawing.Size(117, 19);
            mATHELOAILabel.TabIndex = 0;
            mATHELOAILabel.Text = "MÃ THỂ LOẠI:";
            // 
            // tENTHELOAILabel
            // 
            tENTHELOAILabel.AutoSize = true;
            tENTHELOAILabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENTHELOAILabel.Location = new System.Drawing.Point(52, 124);
            tENTHELOAILabel.Name = "tENTHELOAILabel";
            tENTHELOAILabel.Size = new System.Drawing.Size(122, 19);
            tENTHELOAILabel.TabIndex = 2;
            tENTHELOAILabel.Text = "TÊN THỂ LOẠI:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1142, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 620);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1142, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 590);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1142, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 590);
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
            // bdsTheLoai
            // 
            this.bdsTheLoai.DataMember = "THELOAI";
            this.bdsTheLoai.DataSource = this.DS;
            // 
            // tHELOAITableAdapter
            // 
            this.tHELOAITableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = this.tHELOAITableAdapter;
            this.tableAdapterManager.THETHUVIENTableAdapter = null;
            this.tableAdapterManager.TINHTRANGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcTheLoai
            // 
            this.gcTheLoai.DataSource = this.bdsTheLoai;
            this.gcTheLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTheLoai.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcTheLoai.Location = new System.Drawing.Point(0, 30);
            this.gcTheLoai.MainView = this.gridView1;
            this.gcTheLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcTheLoai.MenuManager = this.barManager1;
            this.gcTheLoai.Name = "gcTheLoai";
            this.gcTheLoai.Size = new System.Drawing.Size(1142, 338);
            this.gcTheLoai.TabIndex = 5;
            this.gcTheLoai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMATHELOAI,
            this.colTENTHELOAI});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcTheLoai;
            this.gridView1.Name = "gridView1";
            // 
            // colMATHELOAI
            // 
            this.colMATHELOAI.Caption = "MÃ THỂ LOẠI";
            this.colMATHELOAI.FieldName = "MATHELOAI";
            this.colMATHELOAI.MinWidth = 31;
            this.colMATHELOAI.Name = "colMATHELOAI";
            this.colMATHELOAI.OptionsColumn.AllowEdit = false;
            this.colMATHELOAI.OptionsColumn.AllowFocus = false;
            this.colMATHELOAI.Visible = true;
            this.colMATHELOAI.VisibleIndex = 0;
            this.colMATHELOAI.Width = 434;
            // 
            // colTENTHELOAI
            // 
            this.colTENTHELOAI.Caption = "TÊN THỂ LOẠI";
            this.colTENTHELOAI.FieldName = "TENTHELOAI";
            this.colTENTHELOAI.MinWidth = 31;
            this.colTENTHELOAI.Name = "colTENTHELOAI";
            this.colTENTHELOAI.OptionsColumn.AllowEdit = false;
            this.colTENTHELOAI.OptionsColumn.AllowFocus = false;
            this.colTENTHELOAI.Visible = true;
            this.colTENTHELOAI.VisibleIndex = 1;
            this.colTENTHELOAI.Width = 956;
            // 
            // panelControl_TheLoai
            // 
            this.panelControl_TheLoai.Controls.Add(tENTHELOAILabel);
            this.panelControl_TheLoai.Controls.Add(this.txtTenTheLoai);
            this.panelControl_TheLoai.Controls.Add(mATHELOAILabel);
            this.panelControl_TheLoai.Controls.Add(this.txtMaTheLoai);
            this.panelControl_TheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_TheLoai.Location = new System.Drawing.Point(0, 368);
            this.panelControl_TheLoai.Name = "panelControl_TheLoai";
            this.panelControl_TheLoai.Size = new System.Drawing.Size(1142, 252);
            this.panelControl_TheLoai.TabIndex = 10;
            // 
            // txtTenTheLoai
            // 
            this.txtTenTheLoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTheLoai, "TENTHELOAI", true));
            this.txtTenTheLoai.Location = new System.Drawing.Point(191, 121);
            this.txtTenTheLoai.MenuManager = this.barManager1;
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTheLoai.Properties.Appearance.Options.UseFont = true;
            this.txtTenTheLoai.Size = new System.Drawing.Size(222, 26);
            this.txtTenTheLoai.TabIndex = 3;
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTheLoai, "MATHELOAI", true));
            this.txtMaTheLoai.Location = new System.Drawing.Point(191, 46);
            this.txtMaTheLoai.MenuManager = this.barManager1;
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTheLoai.Properties.Appearance.Options.UseFont = true;
            this.txtMaTheLoai.Size = new System.Drawing.Size(67, 26);
            this.txtMaTheLoai.TabIndex = 1;
            // 
            // bdsSach
            // 
            this.bdsSach.DataMember = "FK__SACH__MATHELOAI__31EC6D26";
            this.bdsSach.DataSource = this.bdsTheLoai;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // frmTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 640);
            this.Controls.Add(this.panelControl_TheLoai);
            this.Controls.Add(this.gcTheLoai);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTheLoai";
            this.Text = "frmTheLoai";
            this.Load += new System.EventHandler(this.frmTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelControl_TheLoai.ResumeLayout(false);
            this.panelControl_TheLoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private System.Windows.Forms.BindingSource bdsTheLoai;
        private QUANLYTHUVIENDataSet DS;
        private QUANLYTHUVIENDataSetTableAdapters.THELOAITableAdapter tHELOAITableAdapter;
        private QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTheLoai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panelControl_TheLoai;
        private DevExpress.XtraEditors.TextEdit txtTenTheLoai;
        private DevExpress.XtraEditors.TextEdit txtMaTheLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colMATHELOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTHELOAI;
        private System.Windows.Forms.BindingSource bdsSach;
        private QUANLYTHUVIENDataSetTableAdapters.SACHTableAdapter sACHTableAdapter;
    }
}
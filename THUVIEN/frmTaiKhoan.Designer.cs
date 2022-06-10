
namespace THUVIEN
{
    partial class frmTaiKhoan
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
            System.Windows.Forms.Label tENDANGNHAPLabel;
            System.Windows.Forms.Label mAQUYENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new THUVIEN.QUANLYTHUVIENDataSet();
            this.bdsTaiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANTableAdapter = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TAIKHOANTableAdapter();
            this.tableAdapterManager = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager();
            this.gcTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAQUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENDANGNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl_TK = new System.Windows.Forms.Panel();
            this.mAQUYENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENDANGNHAPTextEdit = new DevExpress.XtraEditors.TextEdit();
            tENDANGNHAPLabel = new System.Windows.Forms.Label();
            mAQUYENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelControl_TK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAQUYENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENDANGNHAPTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENDANGNHAPLabel
            // 
            tENDANGNHAPLabel.AutoSize = true;
            tENDANGNHAPLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENDANGNHAPLabel.Location = new System.Drawing.Point(49, 94);
            tENDANGNHAPLabel.Name = "tENDANGNHAPLabel";
            tENDANGNHAPLabel.Size = new System.Drawing.Size(145, 19);
            tENDANGNHAPLabel.TabIndex = 0;
            tENDANGNHAPLabel.Text = "TÊN ĐĂNG NHẬP:";
            // 
            // mAQUYENLabel
            // 
            mAQUYENLabel.AutoSize = true;
            mAQUYENLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAQUYENLabel.Location = new System.Drawing.Point(49, 152);
            mAQUYENLabel.Name = "mAQUYENLabel";
            mAQUYENLabel.Size = new System.Drawing.Size(101, 19);
            mAQUYENLabel.TabIndex = 2;
            mAQUYENLabel.Text = "MÃ QUYỀN:";
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
            this.btnPhucHoi,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1010, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 630);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1010, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 600);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1010, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 600);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
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
            // bdsTaiKhoan
            // 
            this.bdsTaiKhoan.DataMember = "TAIKHOAN";
            this.bdsTaiKhoan.DataSource = this.DS;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TAIKHOANTableAdapter = this.tAIKHOANTableAdapter;
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.THETHUVIENTableAdapter = null;
            this.tableAdapterManager.TINHTRANGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcTaiKhoan
            // 
            this.gcTaiKhoan.DataSource = this.bdsTaiKhoan;
            this.gcTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTaiKhoan.Location = new System.Drawing.Point(0, 30);
            this.gcTaiKhoan.MainView = this.gridView1;
            this.gcTaiKhoan.MenuManager = this.barManager1;
            this.gcTaiKhoan.Name = "gcTaiKhoan";
            this.gcTaiKhoan.Size = new System.Drawing.Size(1010, 220);
            this.gcTaiKhoan.TabIndex = 5;
            this.gcTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAQUYEN,
            this.colTENDANGNHAP});
            this.gridView1.GridControl = this.gcTaiKhoan;
            this.gridView1.Name = "gridView1";
            // 
            // colMAQUYEN
            // 
            this.colMAQUYEN.Caption = "MÃ QUYỀN";
            this.colMAQUYEN.FieldName = "MAQUYEN";
            this.colMAQUYEN.MinWidth = 25;
            this.colMAQUYEN.Name = "colMAQUYEN";
            this.colMAQUYEN.OptionsColumn.AllowEdit = false;
            this.colMAQUYEN.OptionsColumn.AllowFocus = false;
            this.colMAQUYEN.Visible = true;
            this.colMAQUYEN.VisibleIndex = 1;
            this.colMAQUYEN.Width = 453;
            // 
            // colTENDANGNHAP
            // 
            this.colTENDANGNHAP.Caption = "TÀI KHOẢN";
            this.colTENDANGNHAP.FieldName = "TENDANGNHAP";
            this.colTENDANGNHAP.MinWidth = 25;
            this.colTENDANGNHAP.Name = "colTENDANGNHAP";
            this.colTENDANGNHAP.OptionsColumn.AllowEdit = false;
            this.colTENDANGNHAP.OptionsColumn.AllowFocus = false;
            this.colTENDANGNHAP.Visible = true;
            this.colTENDANGNHAP.VisibleIndex = 0;
            this.colTENDANGNHAP.Width = 349;
            // 
            // panelControl_TK
            // 
            this.panelControl_TK.Controls.Add(this.mAQUYENTextEdit);
            this.panelControl_TK.Controls.Add(mAQUYENLabel);
            this.panelControl_TK.Controls.Add(tENDANGNHAPLabel);
            this.panelControl_TK.Controls.Add(this.tENDANGNHAPTextEdit);
            this.panelControl_TK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_TK.Location = new System.Drawing.Point(0, 250);
            this.panelControl_TK.Name = "panelControl_TK";
            this.panelControl_TK.Size = new System.Drawing.Size(1010, 380);
            this.panelControl_TK.TabIndex = 6;
            // 
            // mAQUYENTextEdit
            // 
            this.mAQUYENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTaiKhoan, "MAQUYEN", true));
            this.mAQUYENTextEdit.Location = new System.Drawing.Point(220, 149);
            this.mAQUYENTextEdit.MenuManager = this.barManager1;
            this.mAQUYENTextEdit.Name = "mAQUYENTextEdit";
            this.mAQUYENTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAQUYENTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mAQUYENTextEdit.Size = new System.Drawing.Size(125, 26);
            this.mAQUYENTextEdit.TabIndex = 4;
            // 
            // tENDANGNHAPTextEdit
            // 
            this.tENDANGNHAPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTaiKhoan, "TENDANGNHAP", true));
            this.tENDANGNHAPTextEdit.Location = new System.Drawing.Point(220, 91);
            this.tENDANGNHAPTextEdit.MenuManager = this.barManager1;
            this.tENDANGNHAPTextEdit.Name = "tENDANGNHAPTextEdit";
            this.tENDANGNHAPTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENDANGNHAPTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENDANGNHAPTextEdit.Size = new System.Drawing.Size(88, 26);
            this.tENDANGNHAPTextEdit.TabIndex = 1;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 650);
            this.Controls.Add(this.panelControl_TK);
            this.Controls.Add(this.gcTaiKhoan);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelControl_TK.ResumeLayout(false);
            this.panelControl_TK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAQUYENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENDANGNHAPTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsTaiKhoan;
        private QUANLYTHUVIENDataSet DS;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private QUANLYTHUVIENDataSetTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panelControl_TK;
        private DevExpress.XtraEditors.TextEdit tENDANGNHAPTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colMAQUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTENDANGNHAP;
        private DevExpress.XtraEditors.TextEdit mAQUYENTextEdit;
    }
}
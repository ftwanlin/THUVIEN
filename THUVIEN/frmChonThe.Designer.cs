
namespace THUVIEN
{
    partial class frmChonThe
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
            this.qUANLYTHUVIENDataSet = new THUVIEN.QUANLYTHUVIENDataSet();
            this.bdsTTV = new System.Windows.Forms.BindingSource(this.components);
            this.tHETHUVIENTableAdapter = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.THETHUVIENTableAdapter();
            this.tableAdapterManager = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager();
            this.tHETHUVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMATHE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTHUVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHETHUVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qUANLYTHUVIENDataSet
            // 
            this.qUANLYTHUVIENDataSet.DataSetName = "QUANLYTHUVIENDataSet";
            this.qUANLYTHUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTTV
            // 
            this.bdsTTV.DataMember = "THETHUVIEN";
            this.bdsTTV.DataSource = this.qUANLYTHUVIENDataSet;
            // 
            // tHETHUVIENTableAdapter
            // 
            this.tHETHUVIENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.THETHUVIENTableAdapter = this.tHETHUVIENTableAdapter;
            this.tableAdapterManager.TINHTRANGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tHETHUVIENGridControl
            // 
            this.tHETHUVIENGridControl.DataSource = this.bdsTTV;
            this.tHETHUVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tHETHUVIENGridControl.Location = new System.Drawing.Point(0, 0);
            this.tHETHUVIENGridControl.MainView = this.gridView1;
            this.tHETHUVIENGridControl.Name = "tHETHUVIENGridControl";
            this.tHETHUVIENGridControl.Size = new System.Drawing.Size(802, 255);
            this.tHETHUVIENGridControl.TabIndex = 1;
            this.tHETHUVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMATHE,
            this.colNGAYCAP,
            this.colHSD});
            this.gridView1.GridControl = this.tHETHUVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMATHE
            // 
            this.colMATHE.Caption = "MÃ THẺ";
            this.colMATHE.FieldName = "MATHE";
            this.colMATHE.MinWidth = 25;
            this.colMATHE.Name = "colMATHE";
            this.colMATHE.OptionsColumn.AllowEdit = false;
            this.colMATHE.OptionsColumn.AllowFocus = false;
            this.colMATHE.OptionsColumn.ReadOnly = true;
            this.colMATHE.Visible = true;
            this.colMATHE.VisibleIndex = 0;
            this.colMATHE.Width = 94;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.Caption = "NGÀY CẤP";
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 25;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.OptionsColumn.AllowEdit = false;
            this.colNGAYCAP.OptionsColumn.AllowFocus = false;
            this.colNGAYCAP.OptionsColumn.ReadOnly = true;
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 1;
            this.colNGAYCAP.Width = 94;
            // 
            // colHSD
            // 
            this.colHSD.Caption = "HẠN SỬ DỤNG";
            this.colHSD.FieldName = "HSD";
            this.colHSD.MinWidth = 25;
            this.colHSD.Name = "colHSD";
            this.colHSD.OptionsColumn.AllowEdit = false;
            this.colHSD.OptionsColumn.AllowFocus = false;
            this.colHSD.OptionsColumn.ReadOnly = true;
            this.colHSD.Visible = true;
            this.colHSD.VisibleIndex = 2;
            this.colHSD.Width = 94;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Huỷ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmChonThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 397);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tHETHUVIENGridControl);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChonThe";
            this.Text = "frmChonThe";
            this.Load += new System.EventHandler(this.frmChonThe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTHUVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHETHUVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QUANLYTHUVIENDataSet qUANLYTHUVIENDataSet;
        private System.Windows.Forms.BindingSource bdsTTV;
        private QUANLYTHUVIENDataSetTableAdapters.THETHUVIENTableAdapter tHETHUVIENTableAdapter;
        private QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl tHETHUVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMATHE;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colHSD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
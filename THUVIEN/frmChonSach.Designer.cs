
namespace THUVIEN
{
    partial class frmChonSach
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
            this.bdsSach = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.SACHTableAdapter();
            this.tableAdapterManager = new THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager();
            this.gcSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENSACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANHSACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGDAUSACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGHIENTAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTHUVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qUANLYTHUVIENDataSet
            // 
            this.qUANLYTHUVIENDataSet.DataSetName = "QUANLYTHUVIENDataSet";
            this.qUANLYTHUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSach
            // 
            this.bdsSach.DataMember = "SACH";
            this.bdsSach.DataSource = this.qUANLYTHUVIENDataSet;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SACHTableAdapter = this.sACHTableAdapter;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.THETHUVIENTableAdapter = null;
            this.tableAdapterManager.TINHTRANGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THUVIEN.QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcSach
            // 
            this.gcSach.DataSource = this.bdsSach;
            this.gcSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSach.Location = new System.Drawing.Point(0, 0);
            this.gcSach.MainView = this.gridView1;
            this.gcSach.Name = "gcSach";
            this.gcSach.Size = new System.Drawing.Size(953, 282);
            this.gcSach.TabIndex = 1;
            this.gcSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASACH,
            this.colTENSACH,
            this.colANHSACH,
            this.colNAMXB,
            this.colGIA,
            this.colSOLUONGDAUSACH,
            this.colSOLUONGHIENTAI});
            this.gridView1.GridControl = this.gcSach;
            this.gridView1.Name = "gridView1";
            // 
            // colMASACH
            // 
            this.colMASACH.FieldName = "MASACH";
            this.colMASACH.MinWidth = 25;
            this.colMASACH.Name = "colMASACH";
            this.colMASACH.OptionsColumn.ReadOnly = true;
            this.colMASACH.Visible = true;
            this.colMASACH.VisibleIndex = 0;
            this.colMASACH.Width = 94;
            // 
            // colTENSACH
            // 
            this.colTENSACH.FieldName = "TENSACH";
            this.colTENSACH.MinWidth = 25;
            this.colTENSACH.Name = "colTENSACH";
            this.colTENSACH.OptionsColumn.ReadOnly = true;
            this.colTENSACH.Visible = true;
            this.colTENSACH.VisibleIndex = 1;
            this.colTENSACH.Width = 94;
            // 
            // colANHSACH
            // 
            this.colANHSACH.FieldName = "ANHSACH";
            this.colANHSACH.MinWidth = 25;
            this.colANHSACH.Name = "colANHSACH";
            this.colANHSACH.OptionsColumn.ReadOnly = true;
            this.colANHSACH.Visible = true;
            this.colANHSACH.VisibleIndex = 2;
            this.colANHSACH.Width = 94;
            // 
            // colNAMXB
            // 
            this.colNAMXB.FieldName = "NAMXB";
            this.colNAMXB.MinWidth = 25;
            this.colNAMXB.Name = "colNAMXB";
            this.colNAMXB.OptionsColumn.ReadOnly = true;
            this.colNAMXB.Visible = true;
            this.colNAMXB.VisibleIndex = 3;
            this.colNAMXB.Width = 94;
            // 
            // colGIA
            // 
            this.colGIA.FieldName = "GIA";
            this.colGIA.MinWidth = 25;
            this.colGIA.Name = "colGIA";
            this.colGIA.OptionsColumn.ReadOnly = true;
            this.colGIA.Visible = true;
            this.colGIA.VisibleIndex = 4;
            this.colGIA.Width = 94;
            // 
            // colSOLUONGDAUSACH
            // 
            this.colSOLUONGDAUSACH.FieldName = "SOLUONGDAUSACH";
            this.colSOLUONGDAUSACH.MinWidth = 25;
            this.colSOLUONGDAUSACH.Name = "colSOLUONGDAUSACH";
            this.colSOLUONGDAUSACH.OptionsColumn.ReadOnly = true;
            this.colSOLUONGDAUSACH.Visible = true;
            this.colSOLUONGDAUSACH.VisibleIndex = 5;
            this.colSOLUONGDAUSACH.Width = 94;
            // 
            // colSOLUONGHIENTAI
            // 
            this.colSOLUONGHIENTAI.FieldName = "SOLUONGHIENTAI";
            this.colSOLUONGHIENTAI.MinWidth = 25;
            this.colSOLUONGHIENTAI.Name = "colSOLUONGHIENTAI";
            this.colSOLUONGHIENTAI.OptionsColumn.ReadOnly = true;
            this.colSOLUONGHIENTAI.Visible = true;
            this.colSOLUONGHIENTAI.VisibleIndex = 6;
            this.colSOLUONGHIENTAI.Width = 94;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = " Huỷ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmChonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 442);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gcSach);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChonSach";
            this.Text = "frmChonSach";
            this.Load += new System.EventHandler(this.frmChonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTHUVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QUANLYTHUVIENDataSet qUANLYTHUVIENDataSet;
        private System.Windows.Forms.BindingSource bdsSach;
        private QUANLYTHUVIENDataSetTableAdapters.SACHTableAdapter sACHTableAdapter;
        private QUANLYTHUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASACH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENSACH;
        private DevExpress.XtraGrid.Columns.GridColumn colANHSACH;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMXB;
        private DevExpress.XtraGrid.Columns.GridColumn colGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGDAUSACH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGHIENTAI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
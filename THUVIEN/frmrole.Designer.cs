namespace THUVIEN
{
    partial class frmrole
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
            this.btnadd = new System.Windows.Forms.Button();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.btnXoaa = new System.Windows.Forms.Button();
            this.btnaddrole = new System.Windows.Forms.Button();
            this.btndroprole = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(83, 82);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(129, 50);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Thêm Role";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(244, 88);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(140, 22);
            this.txtadd.TabIndex = 1;
            // 
            // btnXoaa
            // 
            this.btnXoaa.Location = new System.Drawing.Point(83, 200);
            this.btnXoaa.Name = "btnXoaa";
            this.btnXoaa.Size = new System.Drawing.Size(129, 51);
            this.btnXoaa.TabIndex = 2;
            this.btnXoaa.Text = "Xoá Role";
            this.btnXoaa.UseVisualStyleBackColor = true;
            this.btnXoaa.Click += new System.EventHandler(this.btnXoaa_Click);
            // 
            // btnaddrole
            // 
            this.btnaddrole.Location = new System.Drawing.Point(631, 122);
            this.btnaddrole.Name = "btnaddrole";
            this.btnaddrole.Size = new System.Drawing.Size(123, 52);
            this.btnaddrole.TabIndex = 3;
            this.btnaddrole.Text = "Addrolemember";
            this.btnaddrole.UseVisualStyleBackColor = true;
            // 
            // btndroprole
            // 
            this.btndroprole.Location = new System.Drawing.Point(631, 321);
            this.btndroprole.Name = "btndroprole";
            this.btndroprole.Size = new System.Drawing.Size(123, 52);
            this.btndroprole.TabIndex = 4;
            this.btndroprole.Text = "Droprolemember";
            this.btndroprole.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(244, 214);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(541, 53);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(728, 52);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 7;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(541, 252);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 8;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(728, 251);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 24);
            this.comboBox6.TabIndex = 9;
            // 
            // frmrole
            // 
            this.ClientSize = new System.Drawing.Size(866, 478);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btndroprole);
            this.Controls.Add(this.btnaddrole);
            this.Controls.Add(this.btnXoaa);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.btnadd);
            this.Name = "frmrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem btnXoaRole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button drop;
        private QUANLYTHUVIENDataSet qUANLYTHUVIENDataSet;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private QUANLYTHUVIENDataSetTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private System.Windows.Forms.ComboBox cbbdsall;
        private System.Windows.Forms.TextBox txtThem;
        private System.Windows.Forms.ComboBox cbbdsht;
        private System.Windows.Forms.ComboBox cbball;
        private System.Windows.Forms.ComboBox cbbds;
        private System.Windows.Forms.ComboBox cbbht;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Button btnXoaa;
        private System.Windows.Forms.Button btnaddrole;
        private System.Windows.Forms.Button btndroprole;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
    }
}

namespace THUVIEN
{
    partial class frmPhucHoi
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.cmbBackup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(384, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 67);
            this.button2.TabIndex = 7;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Lime;
            this.btnRestore.Location = new System.Drawing.Point(176, 237);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(104, 67);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "PHỤC HỒI";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // cmbBackup
            // 
            this.cmbBackup.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBackup.FormattingEnabled = true;
            this.cmbBackup.Items.AddRange(new object[] {
            "Full",
            "Differential"});
            this.cmbBackup.Location = new System.Drawing.Point(335, 101);
            this.cmbBackup.Name = "cmbBackup";
            this.cmbBackup.Size = new System.Drawing.Size(151, 27);
            this.cmbBackup.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHỌN LOẠI PHỤC HỒI:";
            // 
            // frmPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 409);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.cmbBackup);
            this.Controls.Add(this.label1);
            this.Name = "frmPhucHoi";
            this.Text = "frmPhucHoi";
            this.Load += new System.EventHandler(this.frmPhucHoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ComboBox cmbBackup;
        private System.Windows.Forms.Label label1;
    }
}
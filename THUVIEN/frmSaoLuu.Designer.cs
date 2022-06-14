
namespace THUVIEN
{
    partial class frmSaoLuu
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBackup = new System.Windows.Forms.ComboBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỌN LOẠI SAO LƯU:";
            // 
            // cmbBackup
            // 
            this.cmbBackup.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBackup.FormattingEnabled = true;
            this.cmbBackup.Items.AddRange(new object[] {
            "Full",
            "Differential"});
            this.cmbBackup.Location = new System.Drawing.Point(339, 104);
            this.cmbBackup.Name = "cmbBackup";
            this.cmbBackup.Size = new System.Drawing.Size(151, 27);
            this.cmbBackup.TabIndex = 1;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Lime;
            this.btnBackup.Location = new System.Drawing.Point(147, 234);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(104, 67);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(355, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmSaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 409);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.cmbBackup);
            this.Controls.Add(this.label1);
            this.Name = "frmSaoLuu";
            this.Text = "frmSaoLuu";
            this.Load += new System.EventHandler(this.frmSaoLuu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBackup;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button button2;
    }
}
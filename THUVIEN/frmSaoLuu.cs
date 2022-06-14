using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUVIEN
{
    public partial class frmSaoLuu : Form
    {
        public frmSaoLuu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            if (MessageBox.Show("Xác nhận sao lưu dữ liệu?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string str = "USE QUANLYTHUVIEN;";
                string str1;
                if (cmbBackup.SelectedIndex == 0)
                {
                    str1 = "BACKUP DATABASE QUANLYTHUVIEN TO DISK = 'D:\\backupQLTV.Bak' WITH FORMAT;";
                }
                else
                {
                    str1 = "BACKUP DATABASE QUANLYTHUVIEN TO DISK = 'D:\\backupQLTV_diff.Bak' WITH DIFFERENTIAL;";
                }
                
                SqlCommand cmd1 = new SqlCommand(str, Program.conn);
                SqlCommand cmd2 = new SqlCommand(str1, Program.conn);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Backup thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void frmSaoLuu_Load(object sender, EventArgs e)
        {
            cmbBackup.SelectedIndex = 0;
        }
    }
}

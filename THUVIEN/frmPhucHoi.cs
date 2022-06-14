using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUVIEN
{
    public partial class frmPhucHoi : Form
    {
        public frmPhucHoi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            if (!File.Exists(@"D:\\backupQLTV.Bak") || !File.Exists(@"D:\\backupQLTV_diff.Bak"))
            {
                MessageBox.Show("Chưa có file sao lưu, không thể khôi phục dữ liệu\n Vui lòng sao lưu trước khi khôi phục dữ liệu!");
                return;
            }
            if (MessageBox.Show("Xác nhận sao lưu dữ liệu?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string str = "USE master;";
                string str1 = "ALTER DATABASE QUANLYTHUVIEN SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                string str2;
                if (cmbBackup.SelectedIndex == 0)
                {
                    str2 = "RESTORE DATABASE QUANLYTHUVIEN FROM DISK = 'D:\\backupQLTV.Bak' WITH REPLACE ";
                }
                else
                {
                    str2 = "RESTORE DATABASE QUANLYTHUVIEN FROM DISK = 'D:\\backupQLTV.Bak' WITH NORECOVERY\n" +
                        "RESTORE DATABASE QUANLYTHUVIEN FROM DISK = 'D:\\backupQLTV_diff.Bak'";
                }

                SqlCommand cmd = new SqlCommand(str, Program.conn);
                SqlCommand cmd1 = new SqlCommand(str1, Program.conn);
                SqlCommand cmd2 = new SqlCommand(str2, Program.conn);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Restore thành công, ứng dụng sẽ khởi động lại! ", "Thông báo", MessageBoxButtons.OK);
                Application.Restart();
                this.Hide();
            }
        }

        private void frmPhucHoi_Load(object sender, EventArgs e)
        {
            cmbBackup.SelectedIndex = 0;
        }
    }
}

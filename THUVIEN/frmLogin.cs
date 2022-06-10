using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUVIEN
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "N1";
            txtPassword.Text = "1234";
        }

        private void btnLogin_OK_Click(object sender, EventArgs e)
        {
            Program.mlogin = txtUsername.Text;
            Program.password = txtPassword.Text;
            if (Program.KetNoi() == 0) return;

            String sql = "EXEC dbo.SP_Lay_Thong_Tin_NV_Tu_Login " + Program.mlogin;
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            Program.mHoten = Program.myReader.GetString(0);
            Program.mGroup = Program.myReader.GetString(1);
            bool tt = Program.myReader.GetBoolean(2);
            if (tt == false)
            {
                MessageBox.Show("Sai thông tin đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.username = Program.mlogin;
            Program.myReader.Close();
            Program.conn.Close();
            MessageBox.Show("Nhân viên - Nhóm : " + Program.mHoten + " - " + Program.mGroup
               , "Đăng nhập thành công!"
               , MessageBoxButtons.OK, MessageBoxIcon.Information);

            Program.frmChinh.HienThiMenu();
            this.Close();
        }
    }
}

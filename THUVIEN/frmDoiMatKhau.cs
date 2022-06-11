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
    public partial class frmDoiMatKhau : Form
    {
        SqlConnection conn = new SqlConnection();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnLogin_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtPassword1.Text != txtPassword2.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword1.Text == "" || txtPassword2.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String sql = "ALTER LOGIN " + Program.mlogin + "\nWITH PASSWORD = '" + txtPassword1.Text + "'";
            String sql2 = "UPDATE TAIKHOAN SET MATKHAU = '" + txtPassword1.Text + "' WHERE TENDANGNHAP = '" + Program.mlogin + "'";
            conn.ConnectionString = Program.conn_publisher;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Closed) conn.Open();
            cmd = new SqlCommand(sql2, conn);
            cmd.ExecuteNonQuery();

            Program.connstr = "Data Source=DESKTOP-0HBRCG9" + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
            Program.conn.ConnectionString = Program.connstr;
            conn.Close();

            MessageBox.Show("Đổi mật khẩu thành công!");
        }
    }
}

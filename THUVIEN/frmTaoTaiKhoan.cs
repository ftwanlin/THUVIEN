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
    public partial class frmTaoTaiKhoan : Form
    {
        public delegate void getDATA(String role);
        public getDATA data;
        SqlConnection conn = new SqlConnection();
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void LayDSQuyen(String cmd)
        {
            DataTable dt = new DataTable();
            conn.ConnectionString = Program.conn_publisher;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();

            cmbQuyen.DataSource = dt;
            cmbQuyen.ValueMember = "MAQUYEN";
            cmbQuyen.DisplayMember = "TENQUYEN";
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            LayDSQuyen("SELECT * FROM VIEW_QUYEN");
            //cmbQuyen.SelectedIndex = 1;
            cmbQuyen.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            data(cmbQuyen.SelectedValue.ToString());
        }
    }
}

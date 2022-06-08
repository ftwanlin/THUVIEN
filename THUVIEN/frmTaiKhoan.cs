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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void tAIKHOANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTaiKhoan.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qUANLYTHUVIENDataSet);

        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            this.tAIKHOANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tAIKHOANTableAdapter.Fill(this.qUANLYTHUVIENDataSet.TAIKHOAN);

            gcTaiKhoan.Enabled = true;
            panelControl_TK.Enabled = false;

            btnThoat.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}

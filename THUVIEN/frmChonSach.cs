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
    public partial class frmChonSach : Form
    {
        public frmChonSach()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void sACHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSach.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qUANLYTHUVIENDataSet);

        }

        private void frmChonSach_Load(object sender, EventArgs e)
        {
            this.qUANLYTHUVIENDataSet.EnforceConstraints = false;

            this.sACHTableAdapter.Connection = Program.conn;
            this.sACHTableAdapter.Fill(this.qUANLYTHUVIENDataSet.SACH);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currQty = int.Parse(((DataRowView)bdsSach[bdsSach.Position])["SOLUONGHIENTAI"].ToString());

            if(currQty == 0)
            {
                MessageBox.Show("Só lượng sách này đã hết, hãy chọn sách khác!");
                return;
            }

            Program.maSachDaChon = ((DataRowView)bdsSach[bdsSach.Position])["MASACH"].ToString();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

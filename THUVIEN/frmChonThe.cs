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
    public partial class frmChonThe : Form
    {
        public frmChonThe()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void tHETHUVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTTV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qUANLYTHUVIENDataSet);

        }

        private void frmChonThe_Load(object sender, EventArgs e)
        {
            this.tHETHUVIENTableAdapter.Connection = Program.conn;
            this.tHETHUVIENTableAdapter.Fill(this.qUANLYTHUVIENDataSet.THETHUVIEN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime hsd = DateTime.Parse(((DataRowView)bdsTTV[bdsTTV.Position])["HSD"].ToString());

            if(hsd.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Thẻ đã hết hạn, hãy chọn thẻ khác!");
                return;
            }

            Program.maTheDaChon = ((DataRowView)bdsTTV[bdsTTV.Position])["MATHE"].ToString();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

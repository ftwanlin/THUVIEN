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
    public partial class frmrole : Form
    {
        int index = 0;
        SqlConnection conn = new SqlConnection();
        public frmrole()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaa_Click(object sender, EventArgs e)
        {

        }
    }
}

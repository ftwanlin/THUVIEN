using DevExpress.XtraEditors;
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
        SqlConnection conn = new SqlConnection();
        public frmrole()
        {
            InitializeComponent();
        }
        private DataTable dt = new DataTable();
        private List<String> dsRole = new List<string>();
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void addRow(String roleInf)
        {
            DataRow newRow = dt.NewRow();
            newRow["name"] = roleInf;
            dt.Rows.Add(newRow);
            dt.AcceptChanges();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtadd.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa điền tên Role !", "Lỗi tạo role", MessageBoxButtons.OK);
                txtadd.Focus();
            }
            else if (listQuyen.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Bạn chưa chọn quyền cho Role !", "Lỗi tạo role", MessageBoxButtons.OK);
            }
            else
            {
                String strLenh = " EXEC    @return_value = sp_checkRoleName " + txtadd.Text.Trim();
                strLenh = " DECLARE @return_value int " + strLenh +
                        " SELECT  'Return Value' = @return_value ";

                int resultCheckLogin = Program.CheckDataHelper(strLenh);
                String message = "";
                if (resultCheckLogin == 1)
                {
                    if (dsRole.Count != 0)
                    {
                        //thu hoi quyen
                        foreach (var i in dsRole)
                            Program.ExecSqlNonQuery("exec sp_droprolemember " + i + ", " + txtadd.Text.Trim());

                        //cap quyen
                        foreach (String i in listQuyen.SelectedItems)
                        {
                            strLenh = "exec sp_addrolemember " + i + ", " + txtadd.Text.Trim();
                            Program.ExecSqlNonQuery(strLenh);
                        }
                        message = "Sửa Role thành công !!!";
                    }
                }
                else
                {
                    strLenh = "exec sp_addrole " + txtadd.Text;
                    Program.ExecSqlNonQuery(strLenh);
                    foreach (String i in listQuyen.SelectedItems)
                    {
                        strLenh = "exec sp_addrolemember " + i + ", " + txtadd.Text.Trim();
                        Program.ExecSqlNonQuery(strLenh);
                    }

                    addRow(txtadd.Text.Trim());
                    dgvRoles.CurrentCell = dgvRoles.Rows[dgvRoles.Rows.Count - 1].Cells[0];
                    
                    txtadd.Text = "";
                    message = "Thêm Role thành công !!!";
                    listQuyen.SelectionMode = SelectionMode.None;
                    listQuyen.SelectionMode = SelectionMode.MultiSimple;
                }
                XtraMessageBox.Show(message, "", MessageBoxButtons.OK);
            }
        }
        private void btnXoaa_Click(object sender, EventArgs e)
        {

        }

        private void frmrole_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            Lay_Role("select * from V_DANH_SACH_TAT_CA_ROLE");
        }
        private void Lay_Role(String cmd)
        {
            dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            dgvRoles.DataSource = dt;
            this.dgvRoles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvRoles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvDSRole.AutoSize = true;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaddrole_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndroprole_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbblist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgvRoles.CurrentCell.RowIndex;
            String roleName = dgvRoles.CurrentRow.Cells[0].Value.ToString();
            String strLenh = " EXEC    @return_value = sp_checkRoleUsed " + roleName;
            strLenh = " DECLARE @return_value int " + strLenh +
                    " SELECT  'Return Value' = @return_value ";
            int resultCheckLogin = Program.CheckDataHelper(strLenh);

            if (resultCheckLogin == 0)
            {
                dgvRoles.Rows.RemoveAt(index);
                strLenh = "exec sp_droprole " + roleName;
                Program.ExecSqlNonQuery(strLenh);
            }
            else
            {
                XtraMessageBox.Show("Role " + roleName + " đã được sử dụng !!!", "", MessageBoxButtons.OK);
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtadd.Text = "";
            frmrole_Load(sender, e);    
        }

        private void reloadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtadd.Text = "";
            frmrole_Load(sender, e);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            listQuyen.SelectionMode = SelectionMode.None;
            listQuyen.SelectionMode = SelectionMode.MultiSimple;


            String roleName = dgvRoles.CurrentRow.Cells[0].Value.ToString();
            txtadd.Text = roleName;
            String strLenh = "exec sp_getRoleParent " + roleName;
            SqlDataReader myReader = Program.ExecSqlDataReader(strLenh);
            dsRole.Clear();
            while (myReader.Read())
            {
                roleName = myReader.GetString(0);
                dsRole.Add(roleName);
                for (int i = 0; i < listQuyen.Items.Count; i++)
                {
                    if (listQuyen.Items[i].ToString().Equals(roleName))
                        listQuyen.SetSelected(i, true);
                }
            }

            //XtraMessageBox.Show(roleName, "", MessageBoxButtons.OK);
            myReader.Close();
        }
    }
}

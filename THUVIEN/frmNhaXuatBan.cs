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
    public partial class frmNhaXuatBan : Form
    {
        int index = 0;
        SqlConnection conn = new SqlConnection();
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }

        private void nHAXUATBANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNXB.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            DS.EnforceConstraints = false;
            this.nHAXUATBANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHAXUATBANTableAdapter.Fill(this.DS.NHAXUATBAN);
            this.sACHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sACHTableAdapter.Fill(this.DS.SACH);
            gcNXB.Enabled = true;
            panelControl_NXB.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nHAXUATBANTableAdapter.Fill(this.DS.NHAXUATBAN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNXB.CancelEdit();
            this.nHAXUATBANTableAdapter.Fill(this.DS.NHAXUATBAN);
            if (btnThem.Enabled == false) bdsNXB.Position = index;

            gcNXB.Enabled = true;
            panelControl_NXB.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsNXB.Position;
            panelControl_NXB.Enabled = true;
            bdsNXB.AddNew();
            // txtMaSach.Text = "";
            txtMaNXB.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcNXB.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsNXB.Position;
            panelControl_NXB.Enabled = true;
            txtMaNXB.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcNXB.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Program.KetNoi() == 0) return;
                int maNXB = int.Parse(txtMaNXB.Text.Trim());

                String sql;

                if (maNXB <= 0)
                {
                    sql = "INSERT INTO NHAXUATBAN(TENNXB, SDT, EMAIL, DIACHI) VALUES(N'" + txtTenNXB.Text + "', '" + txtSDT.Text + "', '" + txtEmail.Text + "', N'" + txtDiaChi.Text + "')";
                }
                else
                {
                    sql = "UPDATE NHAXUATBAN\n" +
                        "SET TENNXB = N'" + txtTenNXB.Text + "',\n" +
                        "SDT = '" + txtSDT.Text + "',\n" +
                        "EMAIL = '" + txtEmail.Text + "',\n" +
                        "DIACHI = N'" + txtDiaChi.Text + "'\n" +
                        "WHERE MANXB = " + txtMaNXB.Text;
                }
                if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                       // MessageBox.Show(sql);
                        
                        conn.ConnectionString = Program.connstr;
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        if (conn.State == ConnectionState.Open) conn.Close();

                        this.nHAXUATBANTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.nHAXUATBANTableAdapter.Fill(this.DS.NHAXUATBAN);
                        gcNXB.Enabled = true;
                        panelControl_NXB.Enabled = false;

                        btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnXoa.Enabled = true;
                        btnLuu.Enabled = btnPhucHoi.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        bdsNXB.RemoveCurrent();
                        MessageBox.Show("Lỗi ghi nhà xuất bản: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maNXB = "";
            if (bdsSach.Count > 0)
            {
                MessageBox.Show("Không thể xoá nhà xuất bản này vì đã đã có sách trong thư viện!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhà xuất bản này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    maNXB = ((DataRowView)bdsNXB[bdsNXB.Position])["MANXB"].ToString();
                    bdsNXB.RemoveCurrent();
                    this.nHAXUATBANTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nHAXUATBANTableAdapter.Update(this.DS.NHAXUATBAN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa nhà xuất bản: " + ex.Message, "Thống báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.nHAXUATBANTableAdapter.Fill(this.DS.NHAXUATBAN);
                    bdsNXB.Position = bdsNXB.Find("MANXB", maNXB);
                }
            }
            gcNXB.Enabled = true;
            panelControl_NXB.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
            if (bdsNXB.Count == 0) btnXoa.Enabled = false;
        }

        private void txtTenNXB_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenNXB.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTenNXB, "Tên NXB không được để trống!");
                txtTenNXB.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTenNXB, "");
            }
        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSDT.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSDT, "Tên NXB không được để trống!");
                txtSDT.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtSDT, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Tên NXB không được để trống!");
                txtEmail.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmail, "");
            }
        }

    }
}

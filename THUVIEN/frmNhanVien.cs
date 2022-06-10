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
    public partial class frmNhanVien : Form
    {
        int index = 0;
        SqlConnection conn = new SqlConnection();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            DS.EnforceConstraints = false;
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);

            gcNhanVien.Enabled = true;
            panelControl_NV.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnTaoTaiKhoan.Enabled = true;
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
                this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            if (btnThem.Enabled == false) bdsNV.Position = index;

            gcNhanVien.Enabled = true;
            panelControl_NV.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnTaoTaiKhoan.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsNV.Position;
            panelControl_NV.Enabled = true;
            bdsNV.AddNew();
            txtMaNV.Enabled = true;
            checkTrangThai.Checked = true;
            checkTrangThai.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnTaoTaiKhoan.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsNV.Position;
            panelControl_NV.Enabled = true;
            txtMaNV.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnTaoTaiKhoan.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Program.KetNoi() == 0) return;
               // String sql;

                //String maNV = ((DataRowView)bdsNV[bdsNV.Position])["TRANGTHAI"].ToString();

                int result_value = Program.ExecSqlKiemTra1("SP_TimNV", txtMaNV.Text.Trim());

                int indexMaNV = bdsNV.Find("MANV", txtMaNV.Text);
                int indexCurrent = bdsNV.Position;

                if (result_value == 1 && (indexMaNV != indexCurrent))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        MessageBox.Show(txtMaNV.Text);
                        bdsNV.EndEdit();
                        bdsNV.ResetCurrentItem();
                        this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.nHANVIENTableAdapter.Update(this.DS.NHANVIEN);
                        gcNhanVien.Enabled = true;
                        panelControl_NV.Enabled = false;

                        btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnTaoTaiKhoan.Enabled = true;
                        btnLuu.Enabled = btnPhucHoi.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        bdsNV.RemoveCurrent();
                        MessageBox.Show("Lỗi ghi độc giả: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String trangThai = (((DataRowView)bdsNV[bdsNV.Position])["TRANGTHAI"].ToString());
            if (trangThai == "True")
            {
                frmTaoTaiKhoan ttk = new frmTaoTaiKhoan();
                ttk.data = new frmTaoTaiKhoan.getDATA(getDATA);
                ttk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nhân viên hiện không hoạt động!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void getDATA(String role)
        {
            

            String maNV = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
            String sql = "EXEC dbo.SP_TaoTaiKhoan '" + maNV  + "', '" + role + "'";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null)
            {
                MessageBox.Show("Nhân viên đã có tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Program.myReader.Read();
            Program.myReader.Close();
            Program.conn.Close();
        }

        private void txtMaNV_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaNV.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtMaNV, "Mã nhân viên không được để trống!");
                txtMaNV.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtMaNV, "");
            }
        }

        private void txtTen_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTen.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTen, "Tên nhân viên không được để trống!");
                txtTen.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTen, "");
            }
        }

        private void deNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(deNgaySinh.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTen, "Ngày sinh không được để trống!");
                txtTen.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTen, "");
            }
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtCCCD.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCCCD, "CCCD không được để trống!");
                txtCCCD.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCCCD, "");
            }
        }

        private void txtSDT_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSDT.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSDT, "Số điện thoại không được để trống!");
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
                errorProvider.SetError(txtEmail, "Email không được để trống!");
                txtEmail.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmail, "");
            }
        }

        private void txtDiaChi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtDiaChi.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtDiaChi, "Địa chỉ không được để trống!");
                txtDiaChi.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDiaChi, "");
            }
        }
    }
}

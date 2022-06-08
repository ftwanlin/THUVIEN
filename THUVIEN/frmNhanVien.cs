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
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);

            gcNhanVien.Enabled = true;
            panelControl_NV.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
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

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsNV.Position;
            panelControl_NV.Enabled = true;
            bdsNV.AddNew();
            // txtMaSach.Text = "";
            txtMaNV.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsNV.Position;
            panelControl_NV.Enabled = true;
            txtMaNV.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Program.KetNoi() == 0) return;
                int maNV = int.Parse(txtMaNV.Text.Trim());

                String sql;

                if (maNV <= 0)
                {
                    sql = "INSERT INTO NHANVIEN(TEN, NGAYSINH, GIOITINH, CCCD, SDT, EMAIL, DIACHI, TRANGTHAI) VALUES(N'" + txtTen.Text + "', '" + deNgaySinh.Text + "', '" + checkGioiTinh.Checked.ToString() + "', '" + txtCCCD.Text + "', '" + txtSDT.Text + "', '" + txtEmail.Text + "', N'" + txtDiaChi.Text + "', '" + checkTrangThai.Checked.ToString() + "')";
                }
                else
                {
                    sql = "UPDATE NHANVIEN\n" +
                        "SET TEN = N'" + txtTen.Text + "',\n" +
                        "NGAYSINH = '" + deNgaySinh.Text + "',\n" +
                        "GIOITINH = '" + checkGioiTinh.Checked.ToString() + "',\n" +
                        "CCCD = '" + txtCCCD.Text + "',\n" +
                        "SDT = '" + txtSDT.Text + "',\n" +
                        "EMAIL = '" + txtEmail.Text + "',\n" +
                        "DIACHI = N'" + txtDiaChi.Text + "',\n" +
                        "TRANGTHAI = '" + checkTrangThai.Checked.ToString() + "'\n" +
                        "WHERE MANV = " + maNV;
                }
                if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        MessageBox.Show(sql);
                        //return;
                        conn.ConnectionString = Program.connstr;
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        if (conn.State == ConnectionState.Open) conn.Close();

                        this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                        gcNhanVien.Enabled = true;
                        panelControl_NV.Enabled = false;

                        btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
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

    }
}

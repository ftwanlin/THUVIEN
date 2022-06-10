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
            txtMaNV.Enabled = true;

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
                        //MessageBox.Show(sql);
                        //return;
                        //conn.ConnectionString = Program.connstr;
                        //if (conn.State == ConnectionState.Closed) conn.Open();
                        //SqlCommand cmd = new SqlCommand(sql, conn);
                        //cmd.ExecuteNonQuery();
                        //if (conn.State == ConnectionState.Open) conn.Close();
                        bdsNV.EndEdit();
                        bdsNV.ResetCurrentItem();
                        this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.nHANVIENTableAdapter.Update(this.DS.NHANVIEN);
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
            //if (index != Program.mChiNhanh)
            //{
            //    String maCN = "";
            //    if (index == 1) maCN = "TANDINH";
            //    else if (index == 0) maCN = "BENTHANH";

            //    String maNV = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
            //    String sql = "EXEC dbo.SP_ChuyenNhanVien '" + maNV + "', '" + maCN + "', '" + maNVNew + "'";
            //    Program.myReader = Program.ExecSqlDataReader(sql);
            //    if (Program.myReader == null) return;
            //    else
            //    {
            //        MessageBox.Show("Chuyển nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            //    }
            //    Program.myReader.Read();
            //    Program.myReader.Close();
            //    Program.conn.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn chi nhánh khác chi nhánh hiện tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            String maNV = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
            String sql = "EXEC dbo.SP_TaoTaiKhoan '" + maNV  + "', '" + role + "'";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return;
            else
            {
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Program.myReader.Read();
            Program.myReader.Close();
            Program.conn.Close();
        }
    }
}

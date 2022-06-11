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
    public partial class frmDocGia : Form
    {
        int index = 0;
        SqlConnection conn = new SqlConnection();
        bool isThemClick = false;
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void dOCGIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDocGia.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            DS.EnforceConstraints = false;
            this.dOCGIATableAdapter.Connection.ConnectionString = Program.connstr;
            this.dOCGIATableAdapter.Fill(this.DS.DOCGIA);

            gcDocGia.Enabled = true;
            panelControl_DocGia.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mATHETextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mADOCGIATextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tENDOCGIATextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void eMAILTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dIACHITextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void sDTTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cCCDTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.dOCGIATableAdapter.Fill(this.DS.DOCGIA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDocGia.CancelEdit();
            this.dOCGIATableAdapter.Fill(this.DS.DOCGIA);
            if (btnThem.Enabled == false) bdsDocGia.Position = index;

            gcDocGia.Enabled = true;
            panelControl_DocGia.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isThemClick = true;
            index = bdsDocGia.Position;
            panelControl_DocGia.Enabled = true;
            bdsDocGia.AddNew();
            // txtMaSach.Text = "";
            txtMaDocGia.Enabled = false;
            txtMaThe.Enabled = true;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcDocGia.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsDocGia.Position;
            panelControl_DocGia.Enabled = true;
            txtMaDocGia.Enabled = false;
            txtMaThe.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcDocGia.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Program.KetNoi() == 0) return;
                int maDocGia = int.Parse(txtMaDocGia.Text.Trim());


                if (isThemClick == true)
                {
                    int ret = Program.ExecSqlKiemTra1("SP_TimTheThuVien", txtMaThe.Text);
                    if (ret == 1)
                    {
                        MessageBox.Show("Thẻ thư viện này đã được người khác sử dụng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                

                String sql;

                if (maDocGia <= 0)
                {
                    sql = "INSERT INTO DOCGIA(MATHE, TENDOCGIA, NGAYSINH, GIOITINH, CCCD, SDT, EMAIL, DIACHI) VALUES(" + txtMaThe.Text + ", N'" + txtTenDocGia.Text + "', '" + deNgaySinh.Text + "', '" + checkGioiTinh.Checked.ToString() + "', '" + txtCCCD.Text + "', '" + txtSDT.Text + "', '" + txtEmail.Text + "', N'" + txtDiaChi.Text + "')";
                }
                else
                {
                    sql = "UPDATE DOCGIA\n" +
                        "SET TENDOCGIA = N'" + txtTenDocGia.Text + "',\n" +
                        "NGAYSINH = '" + deNgaySinh.Text + "',\n" +
                        "GIOITINH = '" + checkGioiTinh.Checked.ToString() + "',\n" +
                        "CCCD = '" + txtCCCD.Text + "',\n" +
                        "SDT = '" + txtSDT.Text + "',\n" +
                        "EMAIL = '" + txtEmail.Text + "',\n" +
                        "DIACHI = N'" + txtDiaChi.Text + "'\n" +
                        "WHERE MADOCGIA = " + txtMaDocGia.Text;
                }
                if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        //MessageBox.Show(sql);
                        //return;
                        conn.ConnectionString = Program.connstr;
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        if (conn.State == ConnectionState.Open) conn.Close();

                        this.dOCGIATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.dOCGIATableAdapter.Fill(this.DS.DOCGIA);
                        gcDocGia.Enabled = true;
                        panelControl_DocGia.Enabled = false;

                        btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnXoa.Enabled = true;
                        btnLuu.Enabled = btnPhucHoi.Enabled = false;

                        isThemClick = false;

                    }
                    catch (Exception ex)
                    {
                        bdsDocGia.RemoveCurrent();
                        MessageBox.Show("Lỗi ghi độc giả: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maDocGia = "";
            if (MessageBox.Show("Bạn có thật sự muốn xoá độc giả này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    maDocGia = ((DataRowView)bdsDocGia[bdsDocGia.Position])["MADOCGIA"].ToString();
                    bdsDocGia.RemoveCurrent();
                    this.dOCGIATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dOCGIATableAdapter.Update(this.DS.DOCGIA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa độc giả: " + ex.Message, "Thống báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.dOCGIATableAdapter.Fill(this.DS.DOCGIA);
                    bdsDocGia.Position = bdsDocGia.Find("MADOCGIA", maDocGia);
                }
            }
            gcDocGia.Enabled = true;
            panelControl_DocGia.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
            if (bdsDocGia.Count == 0) btnXoa.Enabled = false;
        }

        private void txtMaThe_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaThe.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtMaThe, "Mã thẻ không được để trống!");
                txtMaThe.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtMaThe, "");
            }
        }

        private void txtTenDocGia_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenDocGia.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTenDocGia, "Tên độc giả không được để trống!");
                txtTenDocGia.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTenDocGia, "");
            }
        }

        private void deNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(deNgaySinh.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(deNgaySinh, "Mã thẻ không được để trống!");
                deNgaySinh.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(deNgaySinh, "");
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

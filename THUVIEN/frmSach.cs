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
    public partial class frmSach : Form
    {
        int index = 0;
        SqlConnection conn = new SqlConnection();
        public frmSach()
        {
            InitializeComponent();
        }

        private void sACHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSach.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void LayDSTheLoai(String cmd)
        {
            DataTable dt = new DataTable();
            conn.ConnectionString = Program.conn_publisher;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();

            cmbTheLoai.DataSource = dt;
            cmbTheLoai.ValueMember = "MATHELOAI";
            cmbTheLoai.DisplayMember = "TENTHELOAI";
        }

        private void LayDSNhaXuatBan(String cmd)
        {
            DataTable dt = new DataTable();
            conn.ConnectionString = Program.conn_publisher;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();

            cmbNhaXuatBan.DataSource = dt;
            cmbNhaXuatBan.ValueMember = "MANXB";
            cmbNhaXuatBan.DisplayMember = "TENNXB";
        }

        private void LayDSTacGia(String cmd)
        {
            DataTable dt = new DataTable();
            conn.ConnectionString = Program.conn_publisher;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();

            cmbTacGia.DataSource = dt;
            cmbTacGia.ValueMember = "MATACGIA";
            cmbTacGia.DisplayMember = "TENTACGIA";
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            DS.EnforceConstraints = false;
            this.nHAXUATBANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHAXUATBANTableAdapter.Fill(this.DS.NHAXUATBAN);
            this.tACGIATableAdapter.Connection.ConnectionString = Program.connstr;
            this.tACGIATableAdapter.Fill(this.DS.TACGIA);
            this.tHELOAITableAdapter.Connection.ConnectionString = Program.connstr;
            this.tHELOAITableAdapter.Fill(this.DS.THELOAI);
            this.sACHTableAdapter.Connection.ConnectionString = Program.connstr;           
            this.sACHTableAdapter.Fill(this.DS.SACH);

            panelControl_Sach.Enabled = false;
            gcSach.Enabled = true;
            //LayDSNhaXuatBan("SELECT * FROM VIEW_NHAXUATBAN");
            //LayDSTacGia("SELECT * FROM VIEW_TACGIA");
            //LayDSTheLoai("SELECT * FROM VIEW_THELOAI");

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsSach.Position;
            panelControl_Sach.Enabled = true;
            bdsSach.AddNew();
            
            txtMaSach.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcSach.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsSach.Position;
            panelControl_Sach.Enabled = true;
            txtMaSach.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcSach.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sACHTableAdapter.Fill(this.DS.SACH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSach.CancelEdit();
            this.sACHTableAdapter.Fill(this.DS.SACH);
            if (btnThem.Enabled == false) bdsSach.Position = index;

            gcSach.Enabled = true;
            panelControl_Sach.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maSach = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa sách này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    maSach = ((DataRowView)bdsSach[bdsSach.Position])["MASACH"].ToString();
                    bdsSach.RemoveCurrent();
                    this.sACHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sACHTableAdapter.Update(this.DS.SACH);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa sách: " + ex.Message, "Thống báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.sACHTableAdapter.Fill(this.DS.SACH);
                    bdsSach.Position = bdsSach.Find("MASACH", maSach);
                }
            }
            if (bdsSach.Count == 0) btnXoa.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Program.KetNoi() == 0) return;
                int maSach = int.Parse(txtMaSach.Text.Trim());

                int indexSach = bdsSach.Find("MASACH", maSach);
                int indexCurrent = bdsSach.Position;

                //MessageBox.Show(indexSach.ToString() + " " + indexCurrent.ToString());
                //MessageBox.Show(txtMaSach.Text);
                //return;

                String sql;

                if (maSach <= 0)
                {
                    sql = "INSERT INTO SACH(MATHELOAI, MATACGIA, MANXB, TENSACH, NAMXB, GIA, SOLUONGDAUSACH, SOLUONGHIENTAI, TOMTAT) " +
                        "VALUES(" + cmbTheLoai.SelectedValue + ", " + cmbTacGia.SelectedValue + ", " + cmbNhaXuatBan.SelectedValue + ", N'" + txtTenSach.Text + "', '" + txtNamXuatBan.Text + "', " + seGia.Text + ", " + seSoLuongSach.Text + ", " + seSoLuongHienTai.Text + ", N'" + txtTomTat.Text + "')";
                }
                else sql = "UPDATE SACH\n" +
                        "SET MATHELOAI = " + cmbTheLoai.SelectedValue + ",\n" +
                        "MATACGIA = " + cmbTacGia.SelectedValue + ",\n" +
                        "MANXB = " + cmbNhaXuatBan.SelectedValue + ",\n" +
                        "TENSACH = N'" + txtTenSach.Text + "',\n" +
                        "NAMXB = '" + txtNamXuatBan.Text + "',\n" +
                        "GIA = " + seGia.Text + ",\n" +
                        "SOLUONGDAUSACH = " + seSoLuongSach.Text + ",\n" +
                        "SOLUONGHIENTAI = " + seSoLuongHienTai.Text + ",\n" +
                        "TOMTAT = N'" + txtTomTat.Text + "'\n" +
                        "WHERE MASACH = " + maSach;

                if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        //MessageBox.Show(sql);
                        conn.ConnectionString = Program.connstr;
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                         if (conn.State == ConnectionState.Open) conn.Close();

                        this.sACHTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sACHTableAdapter.Fill(this.DS.SACH);
                        gcSach.Enabled = true;
                        panelControl_Sach.Enabled = false;

                        btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnXoa.Enabled = true;
                        btnLuu.Enabled = btnPhucHoi.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        bdsSach.RemoveCurrent();
                        MessageBox.Show("Lỗi ghi sách: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
                gcSach.Enabled = true;
                panelControl_Sach.Enabled = false;

                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnLuu.Enabled = btnPhucHoi.Enabled = false;
                if (bdsSach.Count > 0) btnXoa.Enabled = true;
            }
        }

        private void panelControl_Sach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTheLoai_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cmbTheLoai.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cmbTheLoai, "Thể loại không được để trống!");
                cmbTheLoai.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbTheLoai, "");
            }
        }

        private void cmbTacGia_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cmbTacGia.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cmbTacGia, "Tác giả không được để trống!");
                cmbTacGia.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbTacGia, "");
            }
        }

        private void cmbNhaXuatBan_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cmbNhaXuatBan.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cmbNhaXuatBan, "Tác giả không được để trống!");
                cmbNhaXuatBan.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbNhaXuatBan, "");
            }
        }

        private void txtTenSach_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenSach.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTenSach, "Tên sách không được để trống!");
                txtTenSach.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTenSach, "");
            }
        }

        private void txtNamXuatBan_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNamXuatBan.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNamXuatBan, "Tên sách không được để trống!");
                txtNamXuatBan.Focus();
            }
            else if (txtNamXuatBan.Text.Length < 4) 
            {
                e.Cancel = true;
                errorProvider.SetError(txtNamXuatBan, "Năm phải đủ 4 chữ số!");
                txtNamXuatBan.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNamXuatBan, "");
            }
        }

        private void seGia_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(seGia.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(seGia, "Giá không được để trống!");
                seGia.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(seGia, "");
            }
        }

        private void seSoLuongSach_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(seSoLuongSach.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(seSoLuongSach, "Số lượng không được để trống!");
                seSoLuongSach.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(seSoLuongSach, "");
            }
        }

    }
}

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
    public partial class frmTacGia : Form
    {
        int index = 0;
        SqlConnection conn = new SqlConnection();
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void tACGIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTacGia.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            DS.EnforceConstraints = false;
            this.tACGIATableAdapter.Connection.ConnectionString = Program.connstr;
            this.tACGIATableAdapter.Fill(this.DS.TACGIA);
            this.sACHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sACHTableAdapter.Fill(this.DS.SACH);

            gcTacGia.Enabled = true;
            panelControl_TacGia.Enabled = false;

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
                this.tACGIATableAdapter.Fill(this.DS.TACGIA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTacGia.CancelEdit();
            this.tACGIATableAdapter.Fill(this.DS.TACGIA);
            if (btnThem.Enabled == false) bdsTacGia.Position = index;

            gcTacGia.Enabled = true;
            panelControl_TacGia.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsTacGia.Position;
            panelControl_TacGia.Enabled = true;
            bdsTacGia.AddNew();
            // txtMaSach.Text = "";
            txtMaTacGia.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcTacGia.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsTacGia.Position;
            panelControl_TacGia.Enabled = true;
            txtMaTacGia.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcTacGia.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Program.KetNoi() == 0) return;
                int maTacGia = int.Parse(txtMaTacGia.Text.Trim());

                String sql;

                if (maTacGia <= 0)
                {
                    sql = "INSERT INTO TACGIA(TENTACGIA, TIEUSU) VALUES(N'" + txtTenTacGia.Text + "', N'" + txtTieuSu.Text + "')";
                }
                else
                {
                    sql = "UPDATE TACGIA SET TENTACGIA = N'" + txtTenTacGia.Text + "', TIEUSU = N'" + txtTieuSu.Text + "' WHERE MATACGIA = " + txtMaTacGia.Text;
                }
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

                        this.tACGIATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.tACGIATableAdapter.Fill(this.DS.TACGIA);
                        gcTacGia.Enabled = true;
                        panelControl_TacGia.Enabled = false;

                        btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnXoa.Enabled = true;
                        btnLuu.Enabled = btnPhucHoi.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        bdsTacGia.RemoveCurrent();
                        MessageBox.Show("Lỗi ghi tác giả: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maTacGia = "";
            if (bdsSach.Count > 0)
            {
                MessageBox.Show("Không thể xoá tác giả này vì đã đã có sách trong thư viện!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn tác giả này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    maTacGia = ((DataRowView)bdsTacGia[bdsTacGia.Position])["MATACGIA"].ToString();
                    bdsTacGia.RemoveCurrent();
                    this.tACGIATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.tACGIATableAdapter.Update(this.DS.TACGIA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa sách: " + ex.Message, "Thống báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.tACGIATableAdapter.Fill(this.DS.TACGIA);
                    bdsTacGia.Position = bdsTacGia.Find("MATACGIA", maTacGia);
                }
            }
            gcTacGia.Enabled = true;
            panelControl_TacGia.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
            if (bdsTacGia.Count == 0) btnXoa.Enabled = false;
        }

        private void txtTenTacGia_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenTacGia.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTenTacGia, "Tên tác giả không được để trống!");
                txtTenTacGia.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTenTacGia, "");
            }
        }
    }
}

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
    public partial class frmTheLoai : Form
    {
        int index = 0;
        SqlConnection conn = new SqlConnection();
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void tHELOAIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTheLoai.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            DS.EnforceConstraints = false;
            this.tHELOAITableAdapter.Connection.ConnectionString = Program.connstr;
            this.tHELOAITableAdapter.Fill(this.DS.THELOAI);
            this.sACHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sACHTableAdapter.Fill(this.DS.SACH);
            gcTheLoai.Enabled = true;
            panelControl_TheLoai.Enabled = false;

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
                this.tHELOAITableAdapter.Fill(this.DS.THELOAI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTheLoai.CancelEdit();
            this.tHELOAITableAdapter.Fill(this.DS.THELOAI);
            if (btnThem.Enabled == false) bdsTheLoai.Position = index;

            gcTheLoai.Enabled = true;
            panelControl_TheLoai.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsTheLoai.Position;
            panelControl_TheLoai.Enabled = true;
            bdsTheLoai.AddNew();
            // txtMaSach.Text = "";
            txtMaTheLoai.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcTheLoai.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsTheLoai.Position;
            panelControl_TheLoai.Enabled = true;
            txtMaTheLoai.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcTheLoai.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Program.KetNoi() == 0) return;
                int maTheLoai = int.Parse(txtMaTheLoai.Text.Trim());

                String sql;

                if (maTheLoai <= 0)
                {
                    sql = "INSERT INTO THELOAI(TENTHELOAI) VALUES(N'" + txtTenTheLoai.Text + "')";
                }
                else
                {
                    sql = "UPDATE THELOAI SET TENTHELOAI = N'" + txtTenTheLoai.Text + "' WHERE MATHELOAI = " + txtMaTheLoai.Text;
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

                        this.tHELOAITableAdapter.Connection.ConnectionString = Program.connstr;
                        this.tHELOAITableAdapter.Fill(this.DS.THELOAI);
                        gcTheLoai.Enabled = true;
                        panelControl_TheLoai.Enabled = false;

                        btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnXoa.Enabled = true;
                        btnLuu.Enabled = btnPhucHoi.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        bdsTheLoai.RemoveCurrent();
                        MessageBox.Show("Lỗi ghi thể loại: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maTheLoai = "";
            if (bdsSach.Count > 0)
            {
                MessageBox.Show("Không thể xoá thể loại vì đã đã có sách trong thư viện!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn thể loại này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    maTheLoai = ((DataRowView)bdsTheLoai[bdsTheLoai.Position])["MATHELOAI"].ToString();
                    bdsTheLoai.RemoveCurrent();
                    this.tHELOAITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.tHELOAITableAdapter.Update(this.DS.THELOAI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa sách: " + ex.Message, "Thống báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.tHELOAITableAdapter.Fill(this.DS.THELOAI);
                    bdsTheLoai.Position = bdsTheLoai.Find("MATHELOAI", maTheLoai);
                }
            }
            gcTheLoai.Enabled = true;
            panelControl_TheLoai.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
            if (bdsTheLoai.Count == 0) btnXoa.Enabled = false;
        }

        private void txtTenTheLoai_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenTheLoai.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTenTheLoai, "Tên thể loại không được để trống!");
                txtTenTheLoai.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTenTheLoai, "");
            }
        }
    }
}

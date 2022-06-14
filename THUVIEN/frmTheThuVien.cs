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
    public partial class frmTheThuVien : Form
    {
        int index = 0;
        SqlConnection conn = new SqlConnection();
        public frmTheThuVien()
        {
            InitializeComponent();
        }

        private void tHETHUVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTheThuVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmTheThuVien_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            DS.EnforceConstraints = false;
            this.tHETHUVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tHETHUVIENTableAdapter.Fill(this.DS.THETHUVIEN);
            this.dOCGIATableAdapter.Connection.ConnectionString = Program.connstr;
            this.dOCGIATableAdapter.Fill(this.DS.DOCGIA);

            gcTheThuVien.Enabled = true;
            panelControl_TTV.Enabled = false;

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
                this.tHETHUVIENTableAdapter.Fill(this.DS.THETHUVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTheThuVien.CancelEdit();
            this.tHETHUVIENTableAdapter.Fill(this.DS.THETHUVIEN);
            if (btnThem.Enabled == false) bdsTheThuVien.Position = index;

            gcTheThuVien.Enabled = true;
            panelControl_TTV.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsTheThuVien.Position;
            panelControl_TTV.Enabled = true;
            bdsTheThuVien.AddNew();
            // txtMaSach.Text = "";
            txtMaThe.Enabled = false;
            deNgayCap.Text = DateTime.Now.ToString();
            deNgayCap.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcTheThuVien.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsTheThuVien.Position;
            panelControl_TTV.Enabled = true;
            txtMaThe.Enabled = false;
            deNgayCap.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcTheThuVien.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (deHanSuDung.DateTime <= deNgayCap.DateTime)
            {
                MessageBox.Show("Hạn sử dụng phải lớn hơn ngày cấp!");
                return;
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Program.KetNoi() == 0) return;
                int maThe = int.Parse(txtMaThe.Text.Trim());

                if (bdsDocGia.Count > 0)
                {
                    MessageBox.Show("Thẻ thư viện này đang được sử dụng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                String sql;

                if (maThe <= 0)
                {
                    sql = "INSERT INTO THETHUVIEN(NGAYCAP, HSD) VALUES('" + deNgayCap.Text + "', '" + deHanSuDung.Text + "')";
                }
                else
                {
                    sql = "UPDATE THETHUVIEN SET HSD = '" + deHanSuDung.Text + "' WHERE MATHE = " + maThe;
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

                        this.tHETHUVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.tHETHUVIENTableAdapter.Fill(this.DS.THETHUVIEN);
                        gcTheThuVien.Enabled = true;
                        panelControl_TTV.Enabled = false;

                        btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnXoa.Enabled = true;
                        btnLuu.Enabled = btnPhucHoi.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        bdsDocGia.RemoveCurrent();
                        MessageBox.Show("Lỗi ghi thẻ thư viện: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
            }
        }

        private void deHanSuDung_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(deHanSuDung.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(deHanSuDung, "Hạn sử dụng không được để trống");
                deHanSuDung.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(deHanSuDung, "");
            }
        }
    }
}

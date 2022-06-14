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
    public partial class frmPhieuMuon : Form
    {

        int index = 0;
        SqlConnection conn = new SqlConnection();
        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        private void pHIEUMUONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuMuon.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
   
            this.DS.EnforceConstraints = false;

            this.cT_PHIEUMUONTableAdapter.Connection = Program.conn;
            this.cT_PHIEUMUONTableAdapter.Fill(this.DS.CT_PHIEUMUON);

            this.pHIEUMUONTableAdapter.Connection = Program.conn;
            this.pHIEUMUONTableAdapter.Fill(this.DS.PHIEUMUON);

            this.tINHTRANGTableAdapter.Connection = Program.conn;
            this.tINHTRANGTableAdapter.Fill(this.DS.TINHTRANG);

            LayDSTinhTrang("SELECT * FROM VIEW_TINHTRANG");
        }

        private void LayDSTinhTrang(String cmd)
        {
            DataTable dt = new DataTable();
            conn.ConnectionString = Program.conn_publisher;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();

            cmbTinhTrang.DataSource = dt;
            cmbTinhTrang.ValueMember = "MATINHTRANG";
            cmbTinhTrang.DisplayMember = "TINHTRANG";
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnChonThe_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmChonThe));
            if (frm != null) frm.Activate();
            else
            {
                frmChonThe f = new frmChonThe();
                f.ShowDialog();

                txtMaThe.Text = Program.maTheDaChon;
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.pHIEUMUONTableAdapter.Fill(this.DS.PHIEUMUON);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPhieuMuon.CancelEdit();
            this.pHIEUMUONTableAdapter.Fill(this.DS.PHIEUMUON);
            if (btnThem.Enabled == false) bdsPhieuMuon.Position = index;

            gcPhieuMuon.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
            spnMaxSoLuong.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            index = bdsPhieuMuon.Position;

            bdsPhieuMuon.AddNew();
            btnChonThe.Focus();
            txtmaNV.Text = Program.mlogin;
            txtNgayMuon.DateTime = DateTime.Now.Date;
            spnMaxSoLuong.Enabled = true;
            spnMaxSoLuong.EditValue = 1;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            gcPhieuMuon.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*string manv = ((DataRowView)bdsPhieuMuon[bdsPhieuMuon.Position])["MANV"].ToString().Trim();

            if (Program.mlogin.Trim() != manv)
            {
                MessageBox.Show("Không phải phiếu mượn do chính mình tạo, không thể thao tác!");
                return;
            }*/

            if (txtMaThe.Text == "")
            {
                MessageBox.Show("Chưa chọn mã thẻ!");
                btnChonThe.Focus();
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bdsPhieuMuon.EndEdit();

                this.pHIEUMUONTableAdapter.Connection = Program.conn;
                this.pHIEUMUONTableAdapter.Update(this.DS.PHIEUMUON);

                gcPhieuMuon.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
                spnMaxSoLuong.Enabled = false;

                MessageBox.Show("Lưu thành công!");

            }
        }

        private void btnChonSach_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmChonSach));
            if (frm != null) frm.Activate();
            else
            {
                frmChonSach f = new frmChonSach();
                f.ShowDialog();

                txtMaSach.Text = Program.maSachDaChon;
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            string maPM = ((DataRowView)bdsPhieuMuon[bdsPhieuMuon.Position])["MAPHIEUMUON"].ToString().Trim();
            int ret = Program.ExecSqlKiemTra1("SP_KiemTraPhieuMuon", maPM);

            if (ret == 0)
            {
                MessageBox.Show("Phiếu mượn đã được trả, không thể thêm sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soLuongToiDa = int.Parse(((DataRowView)bdsPhieuMuon[bdsPhieuMuon.Position])["SOLUONGMUONTOIDA"].ToString().Trim());
            if (bdsCTPM.Count == soLuongToiDa)
            {
                MessageBox.Show("Số lượng sách đạt tối đa, không thể thêm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gcPhieuMuon.Enabled = false;

            bdsCTPM.AddNew();
            txtHanTra.DateTime = DateTime.Now.Date;
            cmbTinhTrang.SelectedIndex = 1; // chưa trả
            cmbTinhTrang.Enabled = false;

            gcCTPM.Enabled = false;
            btnThemCT.Enabled = btnXoaCT.Enabled = false;
            btnHuyCT.Enabled = btnChonSach.Enabled = true;

        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            gcPhieuMuon.Enabled = true;

            bdsCTPM.CancelEdit();

            gcCTPM.Enabled = true;
            btnThemCT.Enabled = btnXoaCT.Enabled = true;
            btnHuyCT.Enabled = btnChonSach.Enabled = false;
        }

        private void btnGhiCT_Click(object sender, EventArgs e)
        {
            string manv = ((DataRowView)bdsPhieuMuon[bdsPhieuMuon.Position])["MANV"].ToString().Trim();

            if (Program.mlogin.Trim() != manv)
            {
                MessageBox.Show("Không phải phiếu mượn do chính mình tạo, không thể thao tác!");
                return;
            }



            if (txtHanTra.DateTime.Date < txtNgayMuon.DateTime.Date)
            {
                MessageBox.Show("Ngày trả phải lớn hơn ngày mượn");
                return;
            }
            if(txtMaSach.Text == "")
            {
                MessageBox.Show("Chưa chọn sách!");
                btnChonSach.Focus();
                return;
            }

            //int tt = int.Parse(((DataRowView)bdsCTPM[bdsCTPM.Position])["MATINHTRANG"].ToString());
            //if (tt == 1)
            //{
            //    MessageBox.Show("Sách đã trả, không thể đổi trạng thái!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    bdsCTPM.EndEdit();

                    this.cT_PHIEUMUONTableAdapter.Connection = Program.conn;
                    this.cT_PHIEUMUONTableAdapter.Update(this.DS.CT_PHIEUMUON);

                    gcPhieuMuon.Enabled = true;
                    gcCTPM.Enabled = true;
                    btnThemCT.Enabled = btnXoaCT.Enabled = true;
                    btnHuyCT.Enabled = btnChonSach.Enabled = false;

                    MessageBox.Show("Ghi chi tiết thành công!");
                    cmbTinhTrang.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi ghi chi tiết sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void cmbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //int tt = int.Parse(((DataRowView)bdsCTPM[bdsCTPM.Position])["MATINHTRANG"].ToString());
                //if (tt == 1)
                //{
                //    MessageBox.Show("Sách đã trả, không thể đổi trạng thái!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                txtMaTT.Text = cmbTinhTrang.SelectedValue.ToString();

            }
            catch (Exception ex) { }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            string manv = ((DataRowView)bdsPhieuMuon[bdsPhieuMuon.Position])["MANV"].ToString().Trim();

            if(Program.mlogin.Trim() != manv)
            {
                MessageBox.Show("Không phải phiếu mượn do chính mình tạo, không thể thao tác!");
                return;
            }


            if (MessageBox.Show("Bạn có chắc muốn xoá chi tiết phiếu mượn này?", "Thông báo",
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                bdsCTPM.RemoveCurrent();
                this.cT_PHIEUMUONTableAdapter.Connection = Program.conn;
                this.cT_PHIEUMUONTableAdapter.Update(this.DS.CT_PHIEUMUON);

                MessageBox.Show("Xoá chi tiết thành công!");
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            string manv = ((DataRowView)bdsPhieuMuon[bdsPhieuMuon.Position])["MANV"].ToString().Trim();

            if (Program.mlogin.Trim() != manv)
            {
                MessageBox.Show("Không phải phiếu mượn do chính mình tạo, không thể thao tác!");
                return;
            }

            if (bdsCTPM.Count > 0)
            {
                MessageBox.Show("Phiếu mượn này đã có chi tiết, không thể xoá!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xoá phiếu mượn này?", "Thông báo",
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                bdsPhieuMuon.RemoveCurrent();

                this.pHIEUMUONTableAdapter.Connection = Program.conn;
                this.pHIEUMUONTableAdapter.Update(this.DS.PHIEUMUON);

                MessageBox.Show("Xoá phiếu mượn thành công!");
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = ((DataRowView)bdsPhieuMuon[bdsPhieuMuon.Position])["MANV"].ToString().Trim();

            if (Program.mlogin.Trim() != manv)
            {
                MessageBox.Show("Không phải phiếu mượn do chính mình tạo, không thể thao tác!");
                return;
            }
        }

        private void txtmaNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

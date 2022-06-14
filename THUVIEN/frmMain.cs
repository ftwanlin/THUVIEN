using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THUVIEN
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            btnDoiMatKhau.Enabled = false;
            btnDangXuat.Enabled = false;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSach));
            if (frm != null) frm.Activate();
            else
            {
                frmSach f = new frmSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTheLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTheLoai));
            if (frm != null) frm.Activate();
            else
            {
                frmTheLoai f = new frmTheLoai();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhaXuatBan));
            if (frm != null) frm.Activate();
            else
            {
                frmNhaXuatBan f = new frmNhaXuatBan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTacGia));
            if (frm != null) frm.Activate();
            else
            {
                frmTacGia f = new frmTacGia();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDocGia));
            if (frm != null) frm.Activate();
            else
            {
                frmDocGia f = new frmDocGia();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTheThuVien));
            if (frm != null) frm.Activate();
            else
            {
                frmTheThuVien f = new frmTheThuVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaiKhoan f = new frmTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSaoLuu));
            if (frm != null) frm.Activate();
            else
            {
                frmSaoLuu f = new frmSaoLuu();
                f.ShowDialog();

            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhucHoi));
            if (frm != null) frm.Activate();
            else
            {
                frmPhucHoi f = new frmPhucHoi();
                f.ShowDialog();

            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmLogin f = new frmLogin();
                //f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Program.username = "";
            Program.mHoten = "";
            Program.mGroup = "";
            btnDoiMatKhau.Enabled = false;
            btnDangXuat.Enabled = false;
            btnDangNhap.Enabled = true;
            ribbonPage_MuonSach.Visible = false;
            ribbonPage_QuanLySach.Visible = false;
            ribbonPage_DocGia.Visible = false;
            ribbonPage_NhanVien.Visible = false;
            ribbonPage_SaoLuuPhucHoi.Visible = false;
        }

        public void HienThiMenu()
        {
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnDangNhap.Enabled = false;
            ribbonPage_MuonSach.Visible = true;
            ribbonPage_QuanLySach.Visible = true;
            ribbonPage_DocGia.Visible = true;
            ribbonPage_NhanVien.Visible = true;
            ribbonPage_SaoLuuPhucHoi.Visible = true;

            if (Program.mGroup == "NHANVIEN")
            {
                ribbonPage_NhanVien.Visible = false;
                ribbonPage_SaoLuuPhucHoi.Visible = false;
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }

            Program.username = "";
            Program.mHoten = "";
            Program.mGroup = "";
            btnDoiMatKhau.Enabled = false;
            btnDangXuat.Enabled = false;
            btnDangNhap.Enabled = true;
            ribbonPage_MuonSach.Visible = false;
            ribbonPage_QuanLySach.Visible = false;
            ribbonPage_DocGia.Visible = false;
            ribbonPage_NhanVien.Visible = false;
            ribbonPage_SaoLuuPhucHoi.Visible = false;
        }

        private void btnPhieuMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuMuon));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuMuon f = new frmPhieuMuon();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDoiMatKhau));
            if (frm != null) frm.Activate();
            else
            {
                frmDoiMatKhau f = new frmDoiMatKhau();
                //f.MdiParent = this;
                f.Show();
            }
        }
    }
}

﻿using System;
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
            if (Program.KetNoi() == 0) return;
            //con is the connection string
            if (MessageBox.Show("Xác nhận sao lưu phần mềm?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                /*string aaa = @"Data Source=" + "ASUS-FX505DT-AL" + ";Integrated Security=True;Initial Catalog=" + "QLKS" + "";
                SqlConnection con = new SqlConnection(aaa);
                con.Open();*/
                string str = "USE QUANLYTHUVIEN;";
                string str1 = "BACKUP DATABASE QUANLYTHUVIEN TO DISK = 'D:\\backupQLTV.Bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of QUANLYTHUVIEN';";
                SqlCommand cmd1 = new SqlCommand(str, Program.conn);
                SqlCommand cmd2 = new SqlCommand(str1, Program.conn);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Backup thành công, file backup được lưu tại địa chỉ: D:\\backupQLTV.Bak !", "Thông báo", MessageBoxButtons.OK);
                /*con.Close();*/
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            //Bắt lỗi ko tồn tại file backup thì báo lỗi
            if (!File.Exists(@"D:\\backupQLTV.Bak"))
            {
                MessageBox.Show("Chưa có file sao lưu, không thể khôi phục dữ liệu\n Vui lòng sao lưu trước khi khôi phục dữ liệu!");
                return;
            }

            //con is the connection string
            if (MessageBox.Show("Xác nhận sao lưu phần mềm?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                /*string aaa = @"Data Source=" + "ASUS-FX505DT-AL" + ";Integrated Security=True;Initial Catalog=" + "QLKS" + "";
                SqlConnection con = new SqlConnection(aaa);
                con.Open();*/
                string str = "USE master;";
                string str1 = "ALTER DATABASE QUANLYTHUVIEN SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                string str3 = "RESTORE DATABASE QUANLYTHUVIEN FROM DISK = 'D:\\backupQLTV.Bak' WITH REPLACE ";
                SqlCommand cmd = new SqlCommand(str, Program.conn);
                SqlCommand cmd1 = new SqlCommand(str1, Program.conn);
                SqlCommand cmd3 = new SqlCommand(str3, Program.conn);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Restore thành công, ứng dụng sẽ khởi động lại! ", "Thông báo", MessageBoxButtons.OK);
                /*con.Close();*/
                Application.Restart();
                this.Hide();
            }
        }
    }
}

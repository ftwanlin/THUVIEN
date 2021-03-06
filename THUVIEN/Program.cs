using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;

namespace THUVIEN
{
    static class Program
    {
        public static String conn_publisher = "Data Source=DESKTOP-21NSQ5F;Initial Catalog=QUANLYTHUVIEN;Integrated Security=true";
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;

        public static SqlDataReader myReader;

        public static String database = "QUANLYTHUVIEN";
        public static String username = "";
        public static String password = "";

        public static String mlogin;
        public static String mGroup;
        public static String mHoten;
        //public static String mlogin = username;

        public static string maTheDaChon = "";
        public static string maSachDaChon = "";


        public static frmMain frmChinh;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=DESKTOP-21NSQ5F" + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;

            }

            catch (Exception e)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh,conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return ex.State;

            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                //MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int CheckDataHelper(String query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);

            // nếu null thì thoát luôn  ==> lỗi kết nối
            if (dataReader == null)
            {
                return -1;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            return result;
        }
        public static int ExecSqlKiemTra1(String tenSP, String a)
        {
            String sql = "DECLARE @return_value int " +
                         "EXEC @return_value = [dbo].[" + tenSP + "] " +
                         "@a " +
                         "SELECT 'Return Value' = @return_value";

            SqlCommand sqlCommand = new SqlCommand(sql, Program.conn);
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            sqlCommand.Parameters.AddWithValue("@a", a);
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                int result_value = int.Parse(dataReader.GetValue(0).ToString());
                conn.Close();
                return result_value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 5;
            }
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace Oracle_FinalProject_Group10
{
    public partial class FormShow : Form
    {
        public FormShow()
        {
            InitializeComponent();
        }
        OracleConnection conn = LoginForm.conn;
        OracleCommand cmd;
        OracleDataAdapter da;
        DataTable dt;
        string sql;
        string type;

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            this.dataGridView1.Columns.Clear();
            type = this.ShowCBB.Text;
            sql= "";
            
            cmd = conn.CreateCommand();
            if (type == "USER")
            {
                sql = "SELECT USERNAME, USER_ID, CREATED FROM ALL_USERS";
            }
            else if (type == "ROLE")
            {
                sql = "SELECT ROLE, ROLE_ID, PASSWORD_REQUIRED FROM DBA_ROLES";
            }
            else if (type == "USER PRIVILEGES")
            {
                sql = "SELECT GRANTEE, PRIVILEGE, ADMIN_OPTION FROM DBA_SYS_PRIVS";
            }
            else if (type == "TABLE NHANVIEN PRIVILEGES")
            {
                sql = "SELECT GRANTEE, OWNER, TABLE_NAME, GRANTOR, PRIVILEGE, GRANTABLE FROM DBA_TAB_PRIVS WHERE TABLE_NAME = 'NHANVIEN'";
                //sql = "SELECT DBA_TAB_PRIVS.GRANTEE, DBA_TAB_PRIVS.OWNER, DBA_TAB_PRIVS.TABLE_NAME, DBA_TAB_PRIVS.GRANTOR, DBA_TAB_PRIVS.PRIVILEGE, DBA_TAB_PRIVS.GRANTABLE, DBA_COL_PRIVS.column_name FROM DBA_TAB_PRIVS, DBA_COL_PRIVS WHERE DBA_TAB_PRIVS.TABLE_NAME = 'NHANVIEN' AND DBA_COL_PRIVS.TABLE_NAME = DBA_TAB_PRIVS.TABLE_NAME";
            }
            else if (type == "TABLE PHONGBAN PRIVILEGES")
            {
                sql = "SELECT GRANTEE, OWNER, TABLE_NAME, GRANTOR, PRIVILEGE, GRANTABLE FROM DBA_TAB_PRIVS WHERE TABLE_NAME = 'PHONGBAN'";
            }
            else if (type == "TABLE PHANCONG PRIVILEGES")
            {
                sql = "SELECT GRANTEE, OWNER, TABLE_NAME, GRANTOR, PRIVILEGE, GRANTABLE FROM DBA_TAB_PRIVS WHERE TABLE_NAME = 'PHANCONG'";
            }
            else if (type == "TABLE DEAN PRIVILEGES")
            {
                sql = "SELECT GRANTEE, OWNER, TABLE_NAME, GRANTOR, PRIVILEGE, GRANTABLE FROM DBA_TAB_PRIVS WHERE TABLE_NAME = 'DEAN'";
            }
            else if (type == "COLUMN NHANVIEN PRIVILEGES")
            {
                sql = "SELECT PRIVILEGE, GRANTEE, OWNER, TABLE_NAME,column_name FROM DBA_COL_PRIVS WHERE TABLE_NAME = 'NHANVIEN'";
            }
            else if (type == "COLUMN PHONGBAN PRIVILEGES")
            {
                sql = "SELECT PRIVILEGE, GRANTEE, OWNER, TABLE_NAME,column_name FROM DBA_COL_PRIVS WHERE TABLE_NAME = 'PHONGBAN'";
            }
            else if (type == "COLUMN PHANCONG PRIVILEGES")
            {
                sql = "SELECT PRIVILEGE, GRANTEE, OWNER, TABLE_NAME,column_name FROM DBA_COL_PRIVS WHERE TABLE_NAME = 'PHANCON'";
            }
            else if (type == "COLUMN DEAN PRIVILEGES")
            {
                sql = "SELECT PRIVILEGE, GRANTEE, OWNER, TABLE_NAME,column_name FROM DBA_COL_PRIVS WHERE TABLE_NAME = 'DEAN'";
            }
            else
            {
                sql = "SELECT GRANTEE, GRANTED_ROLE, ADMIN_OPTION FROM DBA_ROLE_PRIVS";
            }
            da = new OracleDataAdapter(sql, conn);
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;             
        }

        private void FormShow_Load(object sender, EventArgs e)
        {

        }

        private void FormShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                conn.Close();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("## ERROR: " + ex.Message);
                return;
            }
        }
    }
}

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_FinalProject_Group10
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        OracleConnection conn = LoginForm.conn;
        OracleCommand cmd;
        OracleDataAdapter da;
        DataTable dt;
        string sql;
        string type;
        string phong;

        private void buttonShow_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            this.dataGridView1.Columns.Clear();
            type = this.ShowCBB.Text;
            sql = "";

            cmd = conn.CreateCommand();
            if (type == "TABLE NHANVIEN")
            {
                sql = "SELECT MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, VAITRO, MANQL, PHG FROM matthew.NHANVIEN";
                da = new OracleDataAdapter(sql, conn);
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
            }
            else if (type == "TABLE PHANCONG")
            {
                sql = "SELECT * FROM matthew.PHANCONG";
                da = new OracleDataAdapter(sql, conn);
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
            }
            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void NhanVien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}

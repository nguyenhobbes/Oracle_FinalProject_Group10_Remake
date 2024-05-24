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

namespace Oracle_FinalProject_Group10
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }
        string host;
        string user;
        string password;
        string sv;
        int port;
        bool isDBA;
        public static OracleConnection conn;


        private void button1_Click(object sender, EventArgs e)
        {
            host = this.ServerIP.Text;
            user = this.User.Text;
            password = this.Password.Text;
            sv = this.Service.Text;
            port = 1521;
            isDBA = this.Dba.Checked;

            //host = "localhost";
            //user = "SYS";
            //password = "1";
            //sv = "XE";
            //port = 1521;
            //isDBA = true;

            conn = GetConnectionInfo.GetDBConnection(host, user, password, sv, port, isDBA);
            Console.WriteLine("Getting Connection to " + host);
            try
            {
                conn.Open();

                MessageBox.Show("Connection Successful");
                Console.WriteLine("Connected to " + host);
                if (isDBA)
                {
                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.ShowDialog();
                }
                else
                {
                    this.Hide();
                    NhanVien nv = new NhanVien();
                    nv.ShowDialog();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("## ERROR: " + ex.Message);
                Console.WriteLine("Connection Failed");
                return;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class FormCPass : Form
    {
        public FormCPass()
        {
            InitializeComponent();
        }
        OracleConnection conn = LoginForm.conn;
        OracleCommand cmd;
        string user;
        string password;
        string type;
        string temp;
        OracleDataAdapter da;

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            user = this.UserName.Text;
            password = this.Password.Text;
            type = this.Type.Text;
            if (type == "USER")
            {
                cmd = new OracleCommand("updateUser", conn);
            }
            else
            {
                cmd = new OracleCommand("updateRole", conn);
                if (password == "")
                    password = "NOT IDENTIFIED";
                else
                {
                    temp = "IDENTIFIED by " + password;
                    password = temp;
                }

            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("user", OracleDbType.Varchar2).Value = user;
            cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
            Console.WriteLine(cmd.CommandText);
            cmd.Parameters["user"].Direction = ParameterDirection.Input;
            cmd.Parameters["password"].Direction = ParameterDirection.Input;

            da = new OracleDataAdapter(cmd);
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("CHANGE PASS Successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show("## ERROR: " + ex.Message);
                return;
            }
        }

        private void FormCPass_Load(object sender, EventArgs e)
        {

        }

        private void FormCPass_FormClosing(object sender, FormClosingEventArgs e)
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

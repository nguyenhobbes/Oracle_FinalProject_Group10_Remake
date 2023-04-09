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
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }
        OracleConnection conn = LoginForm.conn;
        OracleCommand cmd;
        string user;
        string type;
        OracleDataAdapter da;

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            user = this.UserName.Text;
            
            type = this.Type.Text;
            if (type == "USER")
            {
                cmd = new OracleCommand("dropUser", conn);
            }
            else
            {
                cmd = new OracleCommand("dropRole", conn);
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("user", OracleDbType.Varchar2).Value = user;
            Console.WriteLine(cmd.CommandText);
            cmd.Parameters["user"].Direction = ParameterDirection.Input;

            da = new OracleDataAdapter(cmd);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("DROP Successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show("## ERROR: " + ex.Message);
                return;
            }
        }

        private void FormDelete_FormClosing(object sender, FormClosingEventArgs e)
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

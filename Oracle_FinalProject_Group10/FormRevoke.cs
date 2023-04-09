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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Oracle_FinalProject_Group10
{
    public partial class FormRevoke : Form
    {
        public FormRevoke()
        {
            InitializeComponent();
        }
        OracleConnection conn = LoginForm.conn;
        OracleCommand cmd;
        OracleDataAdapter da;
        string tabl;
        string user;
        string type;
        string priv;

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void FormRevoke_Load(object sender, EventArgs e)
        {
            
        }



        private void FormRevoke_FormClosing(object sender, FormClosingEventArgs e)
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
        private void buttonRevoke_Click(object sender, EventArgs e)
        {
            tabl = this.tableName.Text;
            user = this.UserName.Text;
            type = this.Type.Text;
            priv = this.Privilege.Text;
            if (type == "USER")
            {
                cmd = new OracleCommand("revokeUser", conn);

            }
            else if (type == "ROLE")
            {
                cmd = new OracleCommand("revokeRole", conn);
            }
            

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("user", OracleDbType.Varchar2).Value = user;
            cmd.Parameters.Add("priv", OracleDbType.Varchar2).Value = priv;
            cmd.Parameters.Add("tabl", OracleDbType.Varchar2).Value = tabl;

            Console.WriteLine(cmd.CommandText);

            cmd.Parameters["user"].Direction = ParameterDirection.Input;
            cmd.Parameters["priv"].Direction = ParameterDirection.Input;
            cmd.Parameters["tabl"].Direction = ParameterDirection.Input;



            da = new OracleDataAdapter(cmd);
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("REVOKE Successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show("## ERROR: " + ex.Message);
                return;
            }
        }
    }
}

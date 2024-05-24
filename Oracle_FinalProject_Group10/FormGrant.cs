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
    public partial class FormGrant : Form
    {
        public FormGrant()
        {
            InitializeComponent();
        }
        OracleConnection conn = LoginForm.conn;
        OracleCommand cmd;
        OracleDataAdapter da;
        DataTable dt;
        string tabl;
        string col;
        string user;
        string type;
        string priv;
        bool wgo;
        string wgoStr = "";
        string sql;
        string temp;


        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void tableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            this.columnName.DataSource = null;
            this.columnName.Items.Clear();
            tabl = this.tableName.Text;
            sql = "SELECT column_name FROM USER_TAB_COLUMNS WHERE table_name = '" + tabl + "'";
            cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            columnName.DataSource = dt;
            columnName.DisplayMember = dt.Columns[0].ColumnName;
            columnName.ValueMember = dt.Columns[0].ColumnName;

        }  

        private void FormGrant_Load(object sender, EventArgs e)
        {
            this.labelColumn.Visible = false;
            this.columnName.Visible = false;

        }

        private void FormGrant_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Privilege_SelectedIndexChanged(object sender, EventArgs e)
        {
            priv = this.Privilege.Text;
            if (priv == "INSERT" || priv == "UPDATE")
            {
                this.labelColumn.Visible = true;
                this.columnName.Visible = true;
            }
            else
            {
                this.labelColumn.Visible = false;
                this.columnName.Visible = false;
            }
        }

        private void buttonGrant_Click(object sender, EventArgs e)
        {
            tabl = this.tableName.Text;
            col = this.columnName.Text;
            user = this.UserName.Text;
            type = this.Type.Text;
            priv = this.Privilege.Text;
            wgo = this.withGrant.Checked;
            if (wgo)
            {
                if (type == "ROLE")
                    wgoStr = "WITH ADMIN OPTION";
                else 
                    wgoStr = "WITH GRANT OPTION";
            }
            if (type == "USER")
            {
                if (priv == "INSERT" || priv == "UPDATE")
                    cmd = new OracleCommand("grantUserIU", conn);
                else
                    cmd = new OracleCommand("grantUserSD", conn);

            }
            else if (type == "ROLE")
            {
                if (priv == "INSERT" || priv == "UPDATE")
                    cmd = new OracleCommand("grantRoleIU", conn);
                else
                    cmd = new OracleCommand("grantRoleSD", conn);

            }
            if (col != null)
            {
                temp = "(" + col + ")";
                col = temp;
            }

            cmd.CommandType = CommandType.StoredProcedure;
            if (cmd.CommandText == "grantUserIU" || cmd.CommandText == "grantRoleIU")
            {
                cmd.Parameters.Add("user", OracleDbType.Varchar2).Value = user;
                cmd.Parameters.Add("priv", OracleDbType.Varchar2).Value = priv;
                cmd.Parameters.Add("tabl", OracleDbType.Varchar2).Value = tabl;
                cmd.Parameters.Add("wgo", OracleDbType.Varchar2).Value = wgoStr;
                cmd.Parameters.Add("col", OracleDbType.Varchar2).Value = col;



                Console.WriteLine(cmd.CommandText);

                cmd.Parameters["user"].Direction = ParameterDirection.Input;
                cmd.Parameters["priv"].Direction = ParameterDirection.Input;
                cmd.Parameters["tabl"].Direction = ParameterDirection.Input;
                cmd.Parameters["wgo"].Direction = ParameterDirection.Input;
                cmd.Parameters["col"].Direction = ParameterDirection.Input;

            }
            else
            {
                cmd.Parameters.Add("user", OracleDbType.Varchar2).Value = user;
                cmd.Parameters.Add("priv", OracleDbType.Varchar2).Value = priv;
                cmd.Parameters.Add("tabl", OracleDbType.Varchar2).Value = tabl;
                cmd.Parameters.Add("wgo", OracleDbType.Varchar2).Value = wgoStr;

                Console.WriteLine(cmd.CommandText);

                cmd.Parameters["user"].Direction = ParameterDirection.Input;
                cmd.Parameters["priv"].Direction = ParameterDirection.Input;
                cmd.Parameters["tabl"].Direction = ParameterDirection.Input;
                cmd.Parameters["wgo"].Direction = ParameterDirection.Input;
                
            }  
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("GRANT Successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show("## ERROR: " + ex.Message);
                return;
            }

        }

        private void columnCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool check = this.columnCheck.Checked;
            if (check)
            {
                this.labelColumn.Visible = true;
                this.columnName.Visible = true;
            }
            else
            {
                this.labelColumn.Visible = false;
                this.columnName.Visible = false;
            }
        }
    }
}

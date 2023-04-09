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
    public partial class FormAdd : Form
    {

        public FormAdd()
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

        private void FormAdd_Load(object sender, EventArgs e)
        {
           
        }


        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            user = this.UserName.Text;
            password = this.Password.Text;
            type= this.Type.Text;
            if(type == "USER")
            {
                cmd = new OracleCommand("createUser", conn);
            }
            else
            {
                cmd = new OracleCommand("createRole", conn);
                if (password == "")
                    password = " NOT IDENTIFIED";
                else
                {
                    temp = "IDENTIFIED BY " + password;
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
                MessageBox.Show("CREATE Successful");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("## ERROR: " + ex.Message);
                return;
            }
            
            cmd.ExecuteNonQuery();

        }

        private void FormAdd_FormClosing(object sender, FormClosingEventArgs e)
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

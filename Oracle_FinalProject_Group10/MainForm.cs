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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        OracleConnection conn = LoginForm.conn;
        

        private void buttonShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormShow fs = new FormShow();
            fs.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdd fa = new FormAdd();
            fa.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDelete fd = new FormDelete();
            fd.ShowDialog();
        }

        private void buttonCPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCPass fp = new FormCPass();
            fp.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEdit fe = new FormEdit();
            fe.ShowDialog();
        }

        private void buttonGrant_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGrant fg = new FormGrant();
            fg.ShowDialog();
        }

        private void buttonRevoke_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRevoke fr = new FormRevoke();
            fr.ShowDialog();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                conn.Close();
                Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show("## ERROR: " + ex.Message);
                return;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("## ERROR: " + ex.Message);
                return;
            }
        }
    }
}

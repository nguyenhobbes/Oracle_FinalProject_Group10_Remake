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
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }
        OracleConnection conn = LoginForm.conn;

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            
        }

        private void FormEdit_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}

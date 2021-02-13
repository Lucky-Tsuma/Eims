using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Eims
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void gboMain_Enter(object sender, EventArgs e)
        {
            gboMain.Left = (this.Width - gboMain.Width) / 2;
            gboMain.Top = (this.Height - gboMain.Height) / 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") {
                MessageBox.Show("Ensure all fields are filled");
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled");
                txtPassword.Focus();
            }
            else {
                Conn connect = new Conn();
                string query = "SELECT * FROM  user WHERE  Username='" + txtUsername.Text.ToString() + "' AND Passsword='" + txtPassword.Text.ToString() + "' AND Status=1";

                if (connect.openConnection() == true) {
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        dashboard das = new dashboard();
                        das.Visible = true;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username/Password Mismatch. Please try again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtUsername.Focus();
                    }
                    connect.closeConnection();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}


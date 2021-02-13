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
    public partial class frmProgram : Form
    {
        private String query;
        private String progCode;
        public frmProgram()
        {
            InitializeComponent();
        }

        private void gboMain_Enter(object sender, EventArgs e)
        {
            gboMain.Left = (this.Width - gboMain.Width) / 2;
            gboMain.Top = (this.Height - gboMain.Height) / 2;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmProgram prg = new frmProgram();
            prg.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset() {
            txtProgramCode.Text = "";
            txtProgramName.Text = "";
            txtDepartmentCode.Text = "";
            txtDescription.Text = "";
            txtProgramCode.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (connect.openConnection() == true)
            {
                query = "SELECT * FROM programme WHERE Prog_Code='" + cboProgramCode.Text.ToString() + "' ORDER BY Prog_Code ASC";

                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //this.cboUniversityCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Prog_Code"].ToString().Replace(" ", "") != "")
                    {
                        txtProgramName.Text = dataReader["Prog_Name"].ToString();
                        txtDuration.Text = dataReader["Duration"].ToString();
                        txtDescription.Text = dataReader["Description"].ToString();
                        txtDepartmentCode.Text = dataReader["Dep_Code"].ToString();

                        progCode = dataReader["Prog_Code"].ToString();
                    }
                }
                connect.closeConnection();
            }
        }

        private void frmProgram_Load(object sender, EventArgs e)
        {
            cboProgramCode.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboProgramCode.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (txtProgramCode.Text == "" && cboProgramCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProgramCode.Focus();

            }
            else if (cboProgramCode.Text == "" && cboProgramCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProgramCode.Focus();

            }
            else if (txtProgramName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProgramName.Focus();

            }
            else if (txtDescription.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();

            }
            else if (txtDuration.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuration.Focus();

            }
            else if (txtDepartmentCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepartmentCode.Focus();

            }
            else
            {
                if (cboProgramCode.Visible == true && progCode != "")
                {
                    query = "UPDATE programme SET Prog_Code='" + cboProgramCode.Text.ToString() + "', Prog_Name='" + txtProgramName.Text.ToString() + "', Duration='" + txtDuration.Text.ToString() + "', Description='" + txtDescription.Text.ToString() + "', Dep_Code='" + txtDepartmentCode.Text.ToString() + "' WHERE Prog_Code= '" + progCode + "'";
                }
                else
                {
                    query = "INSERT INTO programme(Prog_Code, Prog_Name, Duration, Description, Dep_Code) VALUES('" + txtProgramCode.Text.ToString() + "', '" + txtProgramName.Text.ToString() + "','" + txtDuration.Text.ToString() + "', '" + txtDescription.Text.ToString() + "', '" + txtDepartmentCode.Text.ToString() + "')";
                }
                if (connect.openConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    cmd.ExecuteNonQuery();
                    connect.closeConnection();

                    MessageBox.Show("Record successfully saved", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetProgramCode();
                    Reset();
                }

            }
        }

        private void GetProgramCode() {
            Conn connect = new Conn();
            if (connect.openConnection() == true)
            {
                query = "SELECT * FROM programme ORDER BY Prog_Code ASC";

                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                this.cboProgramCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Prog_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboProgramCode.Items.Add(dataReader["Prog_Code"].ToString());
                    }
                }
                connect.closeConnection();
            }
        }
    }
}

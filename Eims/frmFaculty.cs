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
    public partial class frmFaculty : Form
    {
        private String facCode;
        private String query;
        public frmFaculty()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmFaculty fac = new frmFaculty();
            fac.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset() {
            txtFacultyCode.Text = "";
            txtFacultyName.Text = "";
            txtDescription.Text = "";
            txtFacultyCode.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboFacultyCode.Visible = true;
        }

        private void cboFacultyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (connect.openConnection() == true)
            {
                query = "SELECT * FROM faculty WHERE Faculty_Code='" + cboFacultyCode.Text.ToString() + "' ORDER BY Faculty_Code ASC";

                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //this.cboUniversityCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Faculty_Code"].ToString().Replace(" ", "") != "")
                    {
                        txtFacultyName.Text = dataReader["Faculty_Name"].ToString();
                        txtDescription.Text = dataReader["Description"].ToString();

                        facCode = dataReader["Faculty_Code"].ToString();
                    }
                }
                connect.closeConnection();
            }
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            cboFacultyCode.Visible = false;
            gboSearch.Visible = false;
            gboData.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (txtFacultyCode.Text == "" && cboFacultyCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFacultyCode.Focus();

            }
            else if (cboFacultyCode.Text == "" && cboFacultyCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFacultyCode.Focus();

            }
            else if (txtFacultyName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFacultyName.Focus();

            }
            else if (txtDescription.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();

            }
            else
            {
                if (cboFacultyCode.Visible == true && facCode != "")
                {
                    query = "UPDATE faculty SET Faculty_Code='" + cboFacultyCode.Text.ToString() + "', Faculty_Name='" + txtFacultyName.Text.ToString() + "', Description='" + txtDescription.Text.ToString() + "'";
                }
                else
                {
                    query = "INSERT INTO faculty(Faculty_Code, Faculty_Name, Description) VALUES('" + txtFacultyCode.Text.ToString() + "', '" + txtFacultyName.Text.ToString() + "','" + txtDescription.Text.ToString() + "')";
                }
                if (connect.openConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    cmd.ExecuteNonQuery();
                    connect.closeConnection();

                    MessageBox.Show("Record successfully saved", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetFacultyCode();
                    Reset();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (cboFacultyCode.Visible == true && cboFacultyCode.Text != "")
            {
                if (connect.openConnection() == true)
                {
                    query = "DELETE FROM faculty WHERE Faculty_Code='" + cboFacultyCode.Text.ToString() + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    cmd.ExecuteNonQuery();
                    connect.closeConnection();

                    MessageBox.Show("Record deleted successfully", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetFacultyCode();
                    this.cboFacultyCode.Items.Clear();
                    Reset();
                }
                connect.closeConnection();
            }
            else
            {
                cboFacultyCode.Visible = true;
            }
        }

        private void GetFacultyCode() {
            Conn connect = new Conn();
            if (connect.openConnection() == true)
            {
                query = "SELECT * FROM faculty ORDER BY Faculty_Code ASC";

                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                this.cboFacultyCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Faculty_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboFacultyCode.Items.Add(dataReader["Faculty_Code"].ToString());
                    }
                }
                connect.closeConnection();
            }
        }

        private void gboMain_Enter(object sender, EventArgs e)
        {
            gboMain.Left = (this.Width - gboMain.Width) / 2;
            gboMain.Top = (this.Height - gboMain.Height) / 2;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = true;
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdvSearch_Click(object sender, EventArgs e)
        {
            if (cboSearch.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSearch.Focus();
            }
            else if (txtValue.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValue.Focus();
            }
            else
            {
                query = "";
                if (cboSearch.Text == "Faculty Code")
                {
                    query = "SELECT * FROM faculty WHERE Faculty_Code LIKE '" + "%" + txtValue.Text.ToString() + "%" + "' ORDER BY Faculty_Code ASC";
                }
                else if (cboSearch.Text == "Faculty Name")
                {
                    query = "SELECT * FROM faculty WHERE Faculty_Name LIKE '" + "%" + txtValue.Text.ToString() + "%" + "' ORDER BY Faculty_Code ASC";
                }
                else
                {
                    MessageBox.Show("Invalid Criteria! Please try again", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboSearch.Focus();
                }
                if (query != "")
                {
                    Conn connect = new Conn();
                    if (connect.openConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        //Read the data and store them in the list
                        //this.cboUniversityCode.Items.Clear();
                        this.dataGridView1.Rows.Clear();
                        while (dataReader.Read())
                        {
                            if (dataReader["Faculty_Code"].ToString().Replace(" ", "") != "")
                            {
                                string[] row = new string[] { dataReader["Faculty_Code"].ToString(), dataReader["Faculty_Name"].ToString(), dataReader["Description"].ToString() };
                                dataGridView1.Rows.Add(row);
                            }
                        }
                        gboData.Visible = true;
                        connect.closeConnection();
                    }
                }

            }
        }

        private void btnAdvQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;
        }
    }
}

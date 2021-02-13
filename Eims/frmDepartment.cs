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
    public partial class frmDepartment : Form
    {
        private String query;
        private String depCode;
        public frmDepartment()
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
            frmDepartment dp = new frmDepartment();
            dp.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (txtDepartmentCode.Text == "" && cboDepartmentCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepartmentCode.Focus();

            }
            else if (cboDepartmentCode.Text == "" && cboDepartmentCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDepartmentCode.Focus();

            }
            else if (txtDepartmentName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepartmentName.Focus();

            }
            else if (txtDescription.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();

            }
            else if (txtFacultyCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFacultyCode.Focus();
            }
            else
            {
                if (cboDepartmentCode.Visible == true && depCode != "")
                {
                    query = "UPDATE department SET Dep_Code='" + cboDepartmentCode.Text.ToString() + "', Dep_Name='" + txtDepartmentName.Text.ToString() + "', Description='" + txtDescription.Text.ToString() + "', Faculty_Code='" + txtFacultyCode.Text.ToString() + "'";
                }
                else
                {
                    query = "INSERT INTO department(Dep_Code, Dep_Name, Description, Faculty_Code) VALUES('" + txtDepartmentCode.Text.ToString() + "', '" + txtDepartmentName.Text.ToString() + "','" + txtDescription.Text.ToString() + "', '" + txtFacultyCode.Text.ToString() + "')";
                }
                if (connect.openConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    cmd.ExecuteNonQuery();
                    connect.closeConnection();

                    MessageBox.Show("Record successfully saved", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetDepartmentCode();
                    Reset();
                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (cboDepartmentCode.Visible == true && cboDepartmentCode.Text != "")
            {
                if (connect.openConnection() == true)
                {
                    query = "DELETE FROM department WHERE Dep_Code='" + cboDepartmentCode.Text.ToString() + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    cmd.ExecuteNonQuery();
                    connect.closeConnection();

                    MessageBox.Show("Record deleted successfully", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetDepartmentCode();
                    this.cboDepartmentCode.Items.Clear();
                    Reset();
                }
                connect.closeConnection();
            }
            else
            {
                cboDepartmentCode.Visible = true;
            }
        }

        private void Reset() {
            txtDepartmentCode.Text = "";
            txtDepartmentName.Text = "";
            txtDescription.Text = "";
            txtFacultyCode.Text = "";
            txtDepartmentCode.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboDepartmentCode.Visible = true;
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            cboDepartmentCode.Visible = false;
            gboSearch.Visible = false;
            gboData.Visible = false;
        }

        private void GetDepartmentCode() {
            Conn connect = new Conn();
            if (connect.openConnection() == true)
            {
                query = "SELECT * FROM department ORDER BY Dep_Code ASC";

                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                this.cboDepartmentCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Dep_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboDepartmentCode.Items.Add(dataReader["Dep_Code"].ToString());
                    }
                }
                connect.closeConnection();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = true;
        }

        private void btnAdvQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;
        }

        private void btnAdvSearch_Click(object sender, EventArgs e)
        {
            if (cboCriteria.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCriteria.Focus();
            }
            else if (txtSearch.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
            }
            else
            {
                query = "";
                if (cboCriteria.Text == "Department Code")
                {
                    query = "SELECT * FROM department WHERE Dep_Code LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Dep_Code ASC";
                }
                else if (cboCriteria.Text == "Department Name")
                {
                    query = "SELECT * FROM department WHERE Dep_Name LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Dep_Code ASC";
                }
                else if (cboCriteria.Text == "Description")
                {
                    query = "SELECT * FROM department WHERE Description LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Dep_Code ASC";
                }
                else if (cboCriteria.Text == "Faculty Code")
                {
                    query = "SELECT * FROM department WHERE Faculty_Code LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Dep_Code ASC";
                }
                else if (cboCriteria.Text == "All")
                {
                    query = "SELECT * FROM department ORDER BY Dep_Code ASC";
                }
                else
                {
                    MessageBox.Show("Invalid Criteria! Please try again", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboCriteria.Focus();
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
                            if (dataReader["Dep_Code"].ToString().Replace(" ", "") != "")
                            {
                                string[] row = new string[] { dataReader["Dep_Code"].ToString(), dataReader["Dep_Name"].ToString(), dataReader["Description"].ToString(), dataReader["Faculty_Code"].ToString()};
                                dataGridView1.Rows.Add(row);
                            }
                        }
                        gboData.Visible = true;
                        connect.closeConnection();

                    }
                }

            }
        }
    }
}

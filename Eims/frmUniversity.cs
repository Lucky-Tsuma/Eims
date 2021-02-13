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
    public partial class frmUniversity : Form
    {
        public String query;
        public String uniCode;
        public frmUniversity()
        {
            InitializeComponent();
        }

        private void gboMain_Enter(object sender, EventArgs e)
        {
            gboMain.Left = (this.Width - gboMain.Width) / 2;
            gboMain.Top = (this.Height - gboMain.Height) / 2;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
            frmUniversity uni = new frmUniversity();
            uni.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (txtUniversityCode.Text == "" && cboUniversityCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUniversityCode.Focus();

            }
            else if (cboUniversityCode.Text == "" && cboUniversityCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboUniversityCode.Focus();

            }
            else if (txtUniversityName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUniversityName.Focus();

            }
            else if (txtLocation.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();

            }
            else if (txtPostalCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostalCode.Focus();

            }
            else if (txtTown.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();

            }
            else if (txtZipCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtZipCode.Focus();

            }
            else{
                if (cboUniversityCode.Visible == true && uniCode != "")
                {
                    query = "UPDATE university SET University_Code='" + cboUniversityCode.Text.ToString() + "', University_Name='" + txtUniversityName.Text.ToString() + "', Zip_Code='" + txtZipCode.Text.ToString() + "', Postal_Address='" + txtPostalCode.Text.ToString() + "', Town='" + txtTown.Text.ToString() + "' WHERE University_Code= '" + uniCode + "'";
                }
                else {
                    query = "INSERT INTO university(University_Code, University_Name, Location, Zip_Code, Postal_Address, Town) VALUES('" + txtUniversityCode.Text.ToString() + "', '" + txtUniversityName.Text.ToString() + "','" + txtLocation.Text.ToString() + "', '" + txtZipCode.Text.ToString() + "', '" + txtPostalCode.Text.ToString() + "', '" + txtTown.Text.ToString() + "' )";
                }
                if(connect.openConnection() == true) {
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    cmd.ExecuteNonQuery();
                    connect.closeConnection();

                    MessageBox.Show("Record successfully saved", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetUniversityCode();
                    Reset();
                }

            }
        }

        private void Reset() {
            txtUniversityCode.Text = "";
            txtUniversityName.Text = "";
            txtLocation.Text = "";
            txtPostalCode.Text = "";
            txtZipCode.Text = "";
            txtTown.Text = "";
            pBoxUniversityLogo.Image = null;
            txtUniversityCode.Focus();
        }

        private void frmUniversity_Load(object sender, EventArgs e)
        {
            GetUniversityCode();
            cboUniversityCode.Visible = false;

            gboSearch.Visible = false;
            gboData.Visible = false;
        }

        private void GetUniversityCode() {
            Conn connect = new Conn();
            if (connect.openConnection() == true) {
                query = "SELECT * FROM university ORDER BY University_Code ASC";

                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                this.cboUniversityCode.Items.Clear();
                while (dataReader.Read()) {
                    if (dataReader["University_Code"].ToString().Replace(" ", "") != "") {
                        this.cboUniversityCode.Items.Add(dataReader["University_Code"].ToString());
                    }
                }
                connect.closeConnection();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboUniversityCode.Visible = true;
        }

        private void cboUniversityCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (connect.openConnection() == true)
            {
                query = "SELECT * FROM university WHERE University_Code='"+cboUniversityCode.Text.ToString()+"' ORDER BY University_Code ASC";

                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //this.cboUniversityCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["University_Code"].ToString().Replace(" ", "") != "")
                    {
                        txtUniversityName.Text = dataReader["University_Name"].ToString();
                        txtLocation.Text = dataReader["Location"].ToString();
                        txtPostalCode.Text = dataReader["Postal_Address"].ToString();
                        txtZipCode.Text = dataReader["Zip_Code"].ToString();
                        txtTown.Text = dataReader["Town"].ToString();

                        uniCode = dataReader["University_Code"].ToString();
                    }
                }
                connect.closeConnection();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (cboUniversityCode.Visible == true && cboUniversityCode.Text != "")
            {
                if (connect.openConnection() == true)
                {
                    query = "DELETE FROM university WHERE University_Code='" + cboUniversityCode.Text.ToString() + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    cmd.ExecuteNonQuery();
                    connect.closeConnection();

                    MessageBox.Show("Record deleted successfully", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetUniversityCode();
                    this.cboUniversityCode.Items.Clear();
                    Reset();
                }
                connect.closeConnection();
            }else{
                cboUniversityCode.Visible = true;
            }
        }

        private void btnAdvQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = true;
        }

        private void btnAdvSearch_Click_1(object sender, EventArgs e)
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
                if (cboCriteria.Text == "University Code")
                {
                    query = "SELECT * FROM university WHERE University_Code LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY University_Code ASC";
                }
                else if (cboCriteria.Text == "University Name")
                {
                    query = "SELECT * FROM university WHERE University_Name LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY University_Code ASC";
                }
                else if (cboCriteria.Text == "Location")
                {
                    query = "SELECT * FROM university WHERE Location LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY University_Code ASC";
                }
                else if (cboCriteria.Text == "All")
                {
                    query = "SELECT * FROM university ORDER BY University_Code ASC";
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
                            if (dataReader["University_Code"].ToString().Replace(" ", "") != "")
                            {
                                string[] row = new string[] { dataReader["University_Code"].ToString(), dataReader["University_Name"].ToString(), dataReader["Location"].ToString(), dataReader["Postal_Address"].ToString(), dataReader["University_Name"].ToString(), dataReader["Location"].ToString(), dataReader["Town"].ToString() };
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

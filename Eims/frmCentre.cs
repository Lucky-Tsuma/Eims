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
    public partial class frmCentre : Form
    {
        public String query;
        public String centreCode;
        public frmCentre()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            gboMain.Left = (this.Width - gboMain.Width) / 2;
            gboMain.Top = (this.Height - gboMain.Height) / 2;
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
            frmCentre cn = new frmCentre();
            cn.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (txtCentreCode.Text == "" && cboCentreCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCentreCode.Focus();

            }
            else if (cboCentreCode.Text == "" && cboCentreCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCentreCode.Focus();

            }
            else if (txtCentreName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCentreName.Focus();
            }
            else if (txtLocation.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();
            }
            else if (txtUniversityCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUniversityCode.Focus();
            }
            else {
                if (cboCentreCode.Visible == true && centreCode != "")
                {
                    query = "UPDATE centre SET Centre_Code='" + cboCentreCode.Text.ToString() + "', Centre_Name='" + txtCentreName.Text.ToString() + "', Location='" + txtLocation.Text.ToString() + "', University_Code='" + txtUniversityCode.Text.ToString() + "'";
                }
                else
                {
                    query = "INSERT INTO centre(Centre_Code, Centre_Name, Location, University_Code) VALUES('" + txtCentreCode.Text.ToString() + "', '" + txtCentreName.Text.ToString() + "', '" + txtLocation.Text.ToString() + "', '" + txtUniversityCode.Text.ToString() + "')";
                }
                if (connect.openConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    cmd.ExecuteNonQuery();
                    connect.closeConnection();

                    MessageBox.Show("Record successfully saved", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetCentreCode();
                    Reset();
                }
            }
        }

        private void GetCentreCode()
        {
            Conn connect = new Conn();
            if (connect.openConnection() == true)
            {
                query = "SELECT * FROM centre ORDER BY Centre_Code ASC";

                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                this.cboCentreCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Centre_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboCentreCode.Items.Add(dataReader["Centre_Code"].ToString());
                    }
                }
                connect.closeConnection();
            }
        }


        private void Reset() {
            txtCentreCode.Text = "";
            txtCentreName.Text = "";
            txtLocation.Text = "";
            txtUniversityCode.Text = "";
            txtCentreCode.Focus();
        }

        private void frmCentre_Load(object sender, EventArgs e)
        {
            cboCentreCode.Visible = false;

            gboSearch.Visible = false;
            gboData.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboCentreCode.Visible = true;
        }

        private void cboCentreCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (connect.openConnection() == true)
            {
                query = "SELECT * FROM centre WHERE Centre_Code='" + cboCentreCode.Text.ToString() + "' ORDER BY Centre_Code ASC";

                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //this.cboUniversityCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Centre_Code"].ToString().Replace(" ", "") != "")
                    {
                        txtCentreName.Text = dataReader["Centre_Name"].ToString();
                        txtLocation.Text = dataReader["Location"].ToString();
                        txtUniversityCode.Text = dataReader["University_Code"].ToString();
                        centreCode = dataReader["Centre_Code"].ToString();
                    }
                }
                connect.closeConnection();
            }
        }

        private void advQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = true;
        }

        private void advSearch_Click(object sender, EventArgs e)
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
                    query = "SELECT * FROM centre WHERE University_Code LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Centre_Code ASC";
                }
                else if (cboCriteria.Text == "Centre Name")
                {
                    query = "SELECT * FROM centre WHERE Centre_Name LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Centre_Code ASC";
                }
                else if (cboCriteria.Text == "Location")
                {
                    query = "SELECT * FROM centre WHERE Location LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Centre_Code ASC";
                }
                else if (cboCriteria.Text == "All")
                {
                    query = "SELECT * FROM university ORDER BY Centre_Code ASC";
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
                            if (dataReader["Centre_Code"].ToString().Replace(" ", "") != "")
                            {
                                string[] row = new string[] { dataReader["Centre_Code"].ToString(), dataReader["Centre_Name"].ToString(), dataReader["Location"].ToString(), dataReader["University_Code"].ToString()};
                                dataGridView1.Rows.Add(row);


                            }
                        }
                        gboData.Visible = true;
                        connect.closeConnection();

                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (cboCentreCode.Visible == true && cboCentreCode.Text != "")
            {
                if (connect.openConnection() == true)
                {
                    query = "DELETE FROM centre WHERE Centre_Code='" + cboCentreCode.Text.ToString() + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    cmd.ExecuteNonQuery();
                    connect.closeConnection();

                    MessageBox.Show("Record deleted successfully", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetCentreCode();
                    this.cboCentreCode.Items.Clear();
                    Reset();
                }
                connect.closeConnection();
            }
            else
            {
                cboCentreCode.Visible = true;
            }
        }
    }
}

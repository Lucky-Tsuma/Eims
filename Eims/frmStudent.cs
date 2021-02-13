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
    public partial class frmStudent : Form
    {
        public String query;
        public String studentCode;
        public int sessionStatus;
        public frmStudent()
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
            if (MessageBox.Show("Are you sure you want to exit?", "Eims Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmStudent std = new frmStudent();
            std.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            cboRegNo.Visible = false;

            gboData.Visible = false;
            gboSearch.Visible = false;
        }

        private void Reset() {
            pboxStudent.Image = null;
            txtRegNo.Text = "";
            txtFName.Text = "";
            txtMName.Text = "";
            txtLName.Text = "";
            rbtnOff.Checked = false;
            rbtnOn.Checked = false;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtPostalAddress.Text = "";
            txtProgramCode.Text = "";
            txtAcademicYCode.Text = "";
            txtYearCode.Text = "";
            txtRegNo.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboRegNo.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (txtRegNo.Text == "" && cboRegNo.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegNo.Focus();

            }
            else if (cboRegNo.Text == "" && cboRegNo.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRegNo.Focus();

            }
            else if (txtFName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();

            }
            else if (txtMName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMName.Focus();

            }
            else if (txtLName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLName.Focus();

            }
            else if (rbtnOff.Checked == false && rbtnOn.Checked == false)
            {
                MessageBox.Show("Please mark the status field!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (txtPostalAddress.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostalAddress.Focus();

            }
            else if (txtProgramCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProgramCode.Focus();
            }
            else if (txtAcademicYCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAcademicYCode.Focus();
            }
            else
            {
                if(rbtnOn.Checked == true) {
                    sessionStatus = 1;
                }else {
                    sessionStatus = 0;
                }
                if (cboRegNo.Visible == true && studentCode != "")
                {
                    query = "UPDATE student SET Reg_No='" + cboRegNo.Text.ToString() + "', F_Name='" + txtFName.Text.ToString() + "', M_Name='" + txtMName.Text.ToString() + "', L_Name='" + txtLName.Text.ToString() + "', Status='" + sessionStatus + "', Phone_No='"+txtPhone+"', Email_Address='"+txtEmail+"', Postal_Address='"+txtPostalAddress+"', Prog_Code='"+txtProgramCode+"', Acad_Code='"+txtAcademicYCode+"', Year_Code='"+txtYearCode+"' WHERE Reg_No= '" + cboRegNo.Text.ToString() + "'";
                }
                else
                {
                    query = "INSERT INTO student(Reg_No, F_Name, M_Name, L_Name, Status, Phone_No, Email_Address, Postal_Address, Prog_Code, Acad_Code, Year_Code) VALUES('" + txtRegNo.Text.ToString() + "', '" + txtFName.Text.ToString() + "','" + txtMName.Text.ToString() + "', '" + txtLName.Text.ToString() + "', '" + sessionStatus + "', '" + txtPhone.Text.ToString() + "', '" + txtEmail.Text.ToString() + "', '" + txtPostalAddress.Text.ToString() + "', '" + txtProgramCode.Text.ToString() + "', '" + txtAcademicYCode.Text.ToString() + "', '" + txtYearCode.Text.ToString() + "')";
                }
                if (connect.openConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    cmd.ExecuteNonQuery();
                    connect.closeConnection();

                    MessageBox.Show("Record successfully saved", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetStudentCode();
                    Reset();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Conn connect = new Conn();
            if (cboRegNo.Visible == true && cboRegNo.Text != "")
            {
                if (connect.openConnection() == true)
                {
                    query = "DELETE FROM student WHERE Reg_No='" + cboRegNo.Text.ToString() + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    cmd.ExecuteNonQuery();
                    connect.closeConnection();

                    MessageBox.Show("Record deleted successfully", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetStudentCode();
                    this.cboRegNo.Items.Clear();
                    Reset();
                }
                connect.closeConnection();
            }
            else
            {
                cboRegNo.Visible = true;
            }
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
            else if (txtSearch.Text == "" && (cboCriteria.Text != "onSession" && cboCriteria.Text != "offSession"))
            {
                MessageBox.Show("Ensure all fields are filled", "Eims Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
            }
            else
            {
                query = "";
                if (cboCriteria.Text == "Reg No")
                {
                    query = "SELECT * FROM student WHERE Reg_No LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Reg_No ASC";
                }
                else if (cboCriteria.Text == "F Name")
                {
                    query = "SELECT * FROM student WHERE F_Name LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY F_Name ASC";
                }
                else if (cboCriteria.Text == "M Name")
                {
                    query = "SELECT * FROM student WHERE M_Name LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY M_Name ASC";
                }
                else if (cboCriteria.Text == "L Name")
                {
                    query = "SELECT * FROM student WHERE L_Name LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY L_Name ASC";
                }
                else if (cboCriteria.Text == "onSession")
                {
                    query = "SELECT * FROM student WHERE status='"+1+"'";
                }
                else if (cboCriteria.Text == "offSession")
                {
                    query = "SELECT * FROM student WHERE status='" +0+ "'";
                }
                else if (cboCriteria.Text == "Phone")
                {
                    query = "SELECT * FROM student WHERE Phone_No LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Phone_No ASC";
                }
                else if (cboCriteria.Text == "Email")
                {
                    query = "SELECT * FROM student WHERE Email_Address LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Email_Address ASC";
                }
                else if (cboCriteria.Text == "Postal Address")
                {
                    query = "SELECT * FROM student WHERE Postal_Address LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Postal_Address ASC";
                }
                else if (cboCriteria.Text == "Program Code")
                {
                    query = "SELECT * FROM student WHERE Prog_Code LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Prog_Code ASC";
                }
                else if (cboCriteria.Text == "Academic Year Code")
                {
                    query = "SELECT * FROM student WHERE Acad_Code LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Acad_Code ASC";
                }
                else if (cboCriteria.Text == "Year Code")
                {
                    query = "SELECT * FROM student WHERE Year_Code LIKE '" + "%" + txtSearch.Text.ToString() + "%" + "' ORDER BY Year_Code ASC";
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
                            if (dataReader["Reg_No"].ToString().Replace(" ", "") != "")
                            {
                                string[] row = new string[] { dataReader["Reg_No"].ToString(), dataReader["F_Name"].ToString(), dataReader["M_Name"].ToString(), dataReader["L_Name"].ToString(), dataReader["Status"].ToString(), dataReader["Phone_No"].ToString(), dataReader["Email_Address"].ToString(), dataReader["Postal_Address"].ToString(), dataReader["Prog_Code"].ToString(), dataReader["Acad_Code"].ToString(), dataReader["Year_Code"].ToString()};
                                dataGridView1.Rows.Add(row);


                            }
                        }
                        gboData.Visible = true;
                        connect.closeConnection();
                    }
                }
            }
        }

        private void GetStudentCode() {
            Conn connect = new Conn();
            if (connect.openConnection() == true) {
                query = "SELECT * FROM student ORDER BY Reg_No ASC";

                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                this.cboRegNo.Items.Clear();
                while (dataReader.Read()) {
                    if (dataReader["Reg_No"].ToString().Replace(" ", "") != "") {
                        this.cboRegNo.Items.Add(dataReader["Reg_No"].ToString());
                    }
                }
                connect.closeConnection();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";

            if (opf.ShowDialog() == DialogResult.OK) {
                pboxStudent.Image = Image.FromFile(opf.FileName);
            }

        }

        private void pboxStudent_Click(object sender, EventArgs e)
        {

        }
    }
}

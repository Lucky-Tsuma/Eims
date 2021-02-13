using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eims
{
    public partial class frmAcademicYear : Form
    {
        public frmAcademicYear()
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAcademicYearCode.Text = "";
            txtAcademicYear.Text = "";
            rbtnOn.Checked = false;
            rbtnOn.Checked = false;
            txtAcademicYearCode.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAcademicYear yr = new frmAcademicYear();
            yr.Visible = true;
            this.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void frmAcademicYear_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAcademicYearCode.Text.ToString() == "" ||  txtAcademicYear.Text.ToString() == "" || rbtnOn.Checked == false &&
                rbtnOff.Checked == false ) {
                MessageBox.Show("Ensure all fields are filled");
            }
                
        }
           
    }
}

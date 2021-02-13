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
    public partial class frmYearOfStudy : Form
    {
        public frmYearOfStudy()
        {
            InitializeComponent();
        }

        private void frmYearOfStudy_Load(object sender, EventArgs e)
        {

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
            frmYearOfStudy yr = new frmYearOfStudy();
            yr.Visible = true;
            this.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtYearCode.Text = "";
            txtYearOfStudy.Text = "";
            txtSemester.Text = "";
            rbtnOn.Checked = false;
            rbtnOff.Checked = false;
            txtYearCode.Focus();
        }
    }
}

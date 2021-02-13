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
    public partial class frmExaminer : Form
    {
        public frmExaminer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            frmExaminer exmnr = new frmExaminer();
            exmnr.Visible = true;
            this.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtExaminerId.Text = "";
            txtExaminerName.Text = "";
            txtExaminerId.Focus();
        }
    }
}

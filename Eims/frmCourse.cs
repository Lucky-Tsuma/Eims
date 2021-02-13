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
    public partial class frmCourse : Form
    {
        public frmCourse()
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
            txtCourseCode.Text = "";
            txtCourseTitle.Text = "";
            txtProgramCode.Text = "";
            txtUnits.Text = "";
            txtCourseCode.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCourse cs = new frmCourse();
            cs.Visible = true;
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCourseCode.Text.ToString() == "" || txtCourseTitle.Text.ToString() == "" ||
                txtProgramCode.Text.ToString() == "" || txtUnits.Text.ToString() == "") {
                    MessageBox.Show("Ensure all fields are filled");
            }                                       
        }
    }
}

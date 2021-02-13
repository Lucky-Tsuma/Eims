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
    public partial class frmExamination : Form
    {
        public frmExamination()
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
            frmExamination ex = new frmExamination();
            ex.Visible = true;
            this.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCat.Text = "";
            txtCourseCode.Text = "";
            txtE_ExaminerCode.Text = "";
            txtE_Semester.Text = "";
            txtExamCode.Text = "";
            txtExaminerCode.Text = "";
            txtExamType.Text = "";
            txtRegNo.Text = "";
            txtSemester.Text = "";
            txtRegNo.Focus();
        }
    }
}

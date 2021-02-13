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
    public partial class dashboard : Form
    {
        private int childFormNumber = 0;

        public dashboard()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Visible = true;
            this.Dispose();
        }


        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaculty fac = new frmFaculty();
            fac.MdiParent = this;
            fac.Width = this.Width;
            fac.Height = this.Height;
            fac.Visible = true;
        }

        private void universityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUniversity uni = new frmUniversity();
            uni.MdiParent = this;
            uni.Width = this.Width;
            uni.Height = this.Height;
            uni.Visible = true;
        }

        private void centreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCentre cntr = new frmCentre();
            cntr.MdiParent = this;
            cntr.Width = this.Width;
            cntr.Height = this.Height;
            cntr.Visible = true;
        }

        private void academicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademicYear ac = new frmAcademicYear();
            ac.MdiParent = this;
            ac.Width = this.Width;
            ac.Height = this.Height;
            ac.Visible = true;
        }

        private void yearOfStudyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYearOfStudy yr = new frmYearOfStudy();
            yr.MdiParent = this;
            yr.Width = this.Width;
            yr.Height = this.Height;
            yr.Visible = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment dep = new frmDepartment();
            dep.MdiParent = this;
            dep.Width = this.Width;
            dep.Height = this.Height;
            dep.Visible = true;
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProgram prog = new frmProgram();
            prog.MdiParent = this;
            prog.Width = this.Width;
            prog.Height = this.Height;
            prog.Visible = true;
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse cos = new frmCourse();
            cos.MdiParent = this;
            cos.Width = this.Width;
            cos.Height = this.Height;
            cos.Visible = true;
        }

        private void examinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExaminer exmr = new frmExaminer();
            exmr.MdiParent = this;
            exmr.Width = this.Width;
            exmr.Height = this.Height;
            exmr.Visible = true;
        }

        private void examinationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExamination exmn = new frmExamination();
            exmn.MdiParent = this;
            exmn.Width = this.Width;
            exmn.Height = this.Height;
            exmn.Visible = true;
        }

        private void stuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent stdn = new frmStudent();
            stdn.MdiParent = this;
            stdn.Width = this.Width;
            stdn.Height = this.Height;
            stdn.Visible = true;
        }

        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser usr = new frmUser();
            usr.MdiParent = this;
            usr.Width = this.Width;
            usr.Height = this.Height;
            usr.Visible = true;
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            frmMain mmain = new frmMain();
            mmain.MdiParent = this;
            mmain.Visible = true;
        }
    }
}

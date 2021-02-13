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
    public partial class frmSpash : Form
    {
        public frmSpash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gboMain.Left = (this.Width - gboMain.Width) / 2;
            gboMain.Top = (this.Height - gboMain.Height) / 2;
        }

        private void gboMain_Enter(object sender, EventArgs e)
        {
            
        }

        private void lblProgress_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100) {
                progressBar1.Value = progressBar1.Value + 10;
                lblProgress.Text = "Progress..." + progressBar1.Value + "%";
                if (progressBar1.Value == 100) {
                    frmLogin lg = new frmLogin();
                    lg.Visible = true;
                    this.Hide();
                }
            }
        }
    }
}

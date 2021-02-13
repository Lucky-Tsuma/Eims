namespace Eims
{
    partial class frmYearOfStudy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboMain = new System.Windows.Forms.GroupBox();
            this.rbtnOff = new System.Windows.Forms.RadioButton();
            this.rbtnOn = new System.Windows.Forms.RadioButton();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtYearOfStudy = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.txtYearCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboMain
            // 
            this.gboMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gboMain.Controls.Add(this.rbtnOff);
            this.gboMain.Controls.Add(this.rbtnOn);
            this.gboMain.Controls.Add(this.btnNew);
            this.gboMain.Controls.Add(this.btnReset);
            this.gboMain.Controls.Add(this.btnEdit);
            this.gboMain.Controls.Add(this.btnQuit);
            this.gboMain.Controls.Add(this.btnDelete);
            this.gboMain.Controls.Add(this.btnSave);
            this.gboMain.Controls.Add(this.txtYearOfStudy);
            this.gboMain.Controls.Add(this.txtSemester);
            this.gboMain.Controls.Add(this.txtYearCode);
            this.gboMain.Controls.Add(this.label4);
            this.gboMain.Controls.Add(this.label3);
            this.gboMain.Controls.Add(this.label2);
            this.gboMain.Controls.Add(this.label1);
            this.gboMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboMain.Location = new System.Drawing.Point(2, 12);
            this.gboMain.Name = "gboMain";
            this.gboMain.Size = new System.Drawing.Size(789, 355);
            this.gboMain.TabIndex = 3;
            this.gboMain.TabStop = false;
            this.gboMain.Text = "Year of Study";
            this.gboMain.Enter += new System.EventHandler(this.gboMain_Enter);
            // 
            // rbtnOff
            // 
            this.rbtnOff.AutoSize = true;
            this.rbtnOff.Location = new System.Drawing.Point(358, 172);
            this.rbtnOff.Name = "rbtnOff";
            this.rbtnOff.Size = new System.Drawing.Size(88, 17);
            this.rbtnOff.TabIndex = 5;
            this.rbtnOff.TabStop = true;
            this.rbtnOff.Text = "Session off";
            this.rbtnOff.UseVisualStyleBackColor = true;
            // 
            // rbtnOn
            // 
            this.rbtnOn.AutoSize = true;
            this.rbtnOn.Location = new System.Drawing.Point(201, 170);
            this.rbtnOn.Name = "rbtnOn";
            this.rbtnOn.Size = new System.Drawing.Size(87, 17);
            this.rbtnOn.TabIndex = 4;
            this.rbtnOn.TabStop = true;
            this.rbtnOn.Text = "Session on";
            this.rbtnOn.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(37, 271);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(158, 271);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(283, 271);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(412, 271);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(612, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(612, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtYearOfStudy
            // 
            this.txtYearOfStudy.Location = new System.Drawing.Point(258, 78);
            this.txtYearOfStudy.Name = "txtYearOfStudy";
            this.txtYearOfStudy.Size = new System.Drawing.Size(229, 20);
            this.txtYearOfStudy.TabIndex = 2;
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(258, 123);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(229, 20);
            this.txtSemester.TabIndex = 3;
            // 
            // txtYearCode
            // 
            this.txtYearCode.Location = new System.Drawing.Point(258, 32);
            this.txtYearCode.Name = "txtYearCode";
            this.txtYearCode.Size = new System.Drawing.Size(229, 20);
            this.txtYearCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year Of Study";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year Code";
            // 
            // frmYearOfStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 448);
            this.Controls.Add(this.gboMain);
            this.Name = "frmYearOfStudy";
            this.Text = "frmYearOfStudy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmYearOfStudy_Load);
            this.gboMain.ResumeLayout(false);
            this.gboMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboMain;
        private System.Windows.Forms.RadioButton rbtnOff;
        private System.Windows.Forms.RadioButton rbtnOn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtYearOfStudy;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.TextBox txtYearCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
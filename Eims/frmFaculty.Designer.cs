namespace Eims
{
    partial class frmFaculty
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
            this.label1 = new System.Windows.Forms.Label();
            this.gboMain = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFacultyCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboFacultyCode = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gboSearch = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdvQuit = new System.Windows.Forms.Button();
            this.btnAdvSearch = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gboData = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Faculty_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboMain.SuspendLayout();
            this.gboSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty Code:";
            // 
            // gboMain
            // 
            this.gboMain.Controls.Add(this.gboSearch);
            this.gboMain.Controls.Add(this.btnSearch);
            this.gboMain.Controls.Add(this.cboFacultyCode);
            this.gboMain.Controls.Add(this.btnDelete);
            this.gboMain.Controls.Add(this.btnSave);
            this.gboMain.Controls.Add(this.btnQuit);
            this.gboMain.Controls.Add(this.btnEdit);
            this.gboMain.Controls.Add(this.btnReset);
            this.gboMain.Controls.Add(this.btnNew);
            this.gboMain.Controls.Add(this.txtFacultyName);
            this.gboMain.Controls.Add(this.txtDescription);
            this.gboMain.Controls.Add(this.txtFacultyCode);
            this.gboMain.Controls.Add(this.label3);
            this.gboMain.Controls.Add(this.label2);
            this.gboMain.Controls.Add(this.label1);
            this.gboMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboMain.Location = new System.Drawing.Point(26, 12);
            this.gboMain.Name = "gboMain";
            this.gboMain.Size = new System.Drawing.Size(566, 253);
            this.gboMain.TabIndex = 1;
            this.gboMain.TabStop = false;
            this.gboMain.Text = "Faculty Details";
            this.gboMain.Enter += new System.EventHandler(this.gboMain_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faculty Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // txtFacultyCode
            // 
            this.txtFacultyCode.Location = new System.Drawing.Point(150, 31);
            this.txtFacultyCode.Name = "txtFacultyCode";
            this.txtFacultyCode.Size = new System.Drawing.Size(251, 21);
            this.txtFacultyCode.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 139);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(251, 21);
            this.txtDescription.TabIndex = 4;
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(150, 85);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(251, 21);
            this.txtFacultyName.TabIndex = 5;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(29, 193);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(124, 193);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(224, 193);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(436, 193);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(436, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(436, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboFacultyCode
            // 
            this.cboFacultyCode.FormattingEnabled = true;
            this.cboFacultyCode.Location = new System.Drawing.Point(150, 30);
            this.cboFacultyCode.Name = "cboFacultyCode";
            this.cboFacultyCode.Size = new System.Drawing.Size(251, 23);
            this.cboFacultyCode.TabIndex = 14;
            this.cboFacultyCode.SelectedIndexChanged += new System.EventHandler(this.cboFacultyCode_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(326, 193);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gboSearch
            // 
            this.gboSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.gboSearch.Controls.Add(this.gboData);
            this.gboSearch.Controls.Add(this.groupBox1);
            this.gboSearch.Controls.Add(this.txtValue);
            this.gboSearch.Controls.Add(this.cboSearch);
            this.gboSearch.Controls.Add(this.label4);
            this.gboSearch.Controls.Add(this.label5);
            this.gboSearch.Location = new System.Drawing.Point(-13, 23);
            this.gboSearch.Name = "gboSearch";
            this.gboSearch.Size = new System.Drawing.Size(593, 206);
            this.gboSearch.TabIndex = 16;
            this.gboSearch.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdvQuit);
            this.groupBox1.Controls.Add(this.btnAdvSearch);
            this.groupBox1.Location = new System.Drawing.Point(91, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnAdvQuit
            // 
            this.btnAdvQuit.Location = new System.Drawing.Point(239, 28);
            this.btnAdvQuit.Name = "btnAdvQuit";
            this.btnAdvQuit.Size = new System.Drawing.Size(75, 23);
            this.btnAdvQuit.TabIndex = 1;
            this.btnAdvQuit.Text = "Quit";
            this.btnAdvQuit.UseVisualStyleBackColor = true;
            this.btnAdvQuit.Click += new System.EventHandler(this.btnAdvQuit_Click);
            // 
            // btnAdvSearch
            // 
            this.btnAdvSearch.Location = new System.Drawing.Point(62, 28);
            this.btnAdvSearch.Name = "btnAdvSearch";
            this.btnAdvSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAdvSearch.TabIndex = 0;
            this.btnAdvSearch.Text = "Search";
            this.btnAdvSearch.UseVisualStyleBackColor = true;
            this.btnAdvSearch.Click += new System.EventHandler(this.btnAdvSearch_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(200, 84);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(333, 21);
            this.txtValue.TabIndex = 3;
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "Faculty Code",
            "Faculty Name"});
            this.cboSearch.Location = new System.Drawing.Point(200, 34);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(333, 23);
            this.cboSearch.TabIndex = 2;
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.cboSearch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Search Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search Criteria:";
            // 
            // gboData
            // 
            this.gboData.BackColor = System.Drawing.SystemColors.Highlight;
            this.gboData.Controls.Add(this.dataGridView1);
            this.gboData.Location = new System.Drawing.Point(22, 14);
            this.gboData.Name = "gboData";
            this.gboData.Size = new System.Drawing.Size(540, 174);
            this.gboData.TabIndex = 5;
            this.gboData.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Faculty_Code,
            this.Faculty_Name,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(6, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // Faculty_Code
            // 
            this.Faculty_Code.HeaderText = "Faculty Code";
            this.Faculty_Code.Name = "Faculty_Code";
            // 
            // Faculty_Name
            // 
            this.Faculty_Name.HeaderText = "Faculty Name";
            this.Faculty_Name.Name = "Faculty_Name";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 321);
            this.Controls.Add(this.gboMain);
            this.Name = "frmFaculty";
            this.Text = "frmFaculty";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFaculty_Load);
            this.gboMain.ResumeLayout(false);
            this.gboMain.PerformLayout();
            this.gboSearch.ResumeLayout(false);
            this.gboSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gboData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboMain;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtFacultyCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cboFacultyCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gboSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdvQuit;
        private System.Windows.Forms.Button btnAdvSearch;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gboData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}
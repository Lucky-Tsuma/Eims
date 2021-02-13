namespace Eims
{
    partial class frmCentre
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
            this.cboCentreCode = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCentreName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtUniversityCode = new System.Windows.Forms.TextBox();
            this.txtCentreCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboSearch = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.advSearch = new System.Windows.Forms.Button();
            this.advQuit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gboData = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Centre_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Centre_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.University_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboMain.SuspendLayout();
            this.gboSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gboMain
            // 
            this.gboMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gboMain.Controls.Add(this.btnSearch);
            this.gboMain.Controls.Add(this.gboSearch);
            this.gboMain.Controls.Add(this.cboCentreCode);
            this.gboMain.Controls.Add(this.btnEdit);
            this.gboMain.Controls.Add(this.btnQuit);
            this.gboMain.Controls.Add(this.btnReset);
            this.gboMain.Controls.Add(this.btnNew);
            this.gboMain.Controls.Add(this.btnDelete);
            this.gboMain.Controls.Add(this.btnSave);
            this.gboMain.Controls.Add(this.txtCentreName);
            this.gboMain.Controls.Add(this.txtLocation);
            this.gboMain.Controls.Add(this.txtUniversityCode);
            this.gboMain.Controls.Add(this.txtCentreCode);
            this.gboMain.Controls.Add(this.label4);
            this.gboMain.Controls.Add(this.label3);
            this.gboMain.Controls.Add(this.label2);
            this.gboMain.Controls.Add(this.label1);
            this.gboMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboMain.Location = new System.Drawing.Point(12, 2);
            this.gboMain.Name = "gboMain";
            this.gboMain.Size = new System.Drawing.Size(768, 465);
            this.gboMain.TabIndex = 0;
            this.gboMain.TabStop = false;
            this.gboMain.Text = "Centre Details";
            this.gboMain.Enter += new System.EventHandler(this.gboMain_Enter);
            // 
            // cboCentreCode
            // 
            this.cboCentreCode.FormattingEnabled = true;
            this.cboCentreCode.Location = new System.Drawing.Point(278, 47);
            this.cboCentreCode.Name = "cboCentreCode";
            this.cboCentreCode.Size = new System.Drawing.Size(214, 21);
            this.cboCentreCode.TabIndex = 11;
            this.cboCentreCode.SelectedIndexChanged += new System.EventHandler(this.cboCentreCode_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(278, 277);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(469, 277);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(169, 277);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(61, 277);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(584, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(584, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCentreName
            // 
            this.txtCentreName.Location = new System.Drawing.Point(278, 92);
            this.txtCentreName.Name = "txtCentreName";
            this.txtCentreName.Size = new System.Drawing.Size(214, 20);
            this.txtCentreName.TabIndex = 2;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(278, 137);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(214, 20);
            this.txtLocation.TabIndex = 3;
            // 
            // txtUniversityCode
            // 
            this.txtUniversityCode.Location = new System.Drawing.Point(278, 186);
            this.txtUniversityCode.Name = "txtUniversityCode";
            this.txtUniversityCode.Size = new System.Drawing.Size(214, 20);
            this.txtUniversityCode.TabIndex = 4;
            // 
            // txtCentreCode
            // 
            this.txtCentreCode.Location = new System.Drawing.Point(278, 47);
            this.txtCentreCode.Name = "txtCentreCode";
            this.txtCentreCode.Size = new System.Drawing.Size(214, 20);
            this.txtCentreCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "University Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Centre Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Centre Code";
            // 
            // gboSearch
            // 
            this.gboSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.gboSearch.Controls.Add(this.gboData);
            this.gboSearch.Controls.Add(this.groupBox1);
            this.gboSearch.Controls.Add(this.txtSearch);
            this.gboSearch.Controls.Add(this.cboCriteria);
            this.gboSearch.Controls.Add(this.label6);
            this.gboSearch.Controls.Add(this.label5);
            this.gboSearch.Location = new System.Drawing.Point(61, 35);
            this.gboSearch.Name = "gboSearch";
            this.gboSearch.Size = new System.Drawing.Size(596, 225);
            this.gboSearch.TabIndex = 12;
            this.gboSearch.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search Criteria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Search Value:";
            // 
            // cboCriteria
            // 
            this.cboCriteria.FormattingEnabled = true;
            this.cboCriteria.Items.AddRange(new object[] {
            "All",
            "Centre Name",
            "Location",
            "University Code"});
            this.cboCriteria.Location = new System.Drawing.Point(228, 28);
            this.cboCriteria.Name = "cboCriteria";
            this.cboCriteria.Size = new System.Drawing.Size(299, 21);
            this.cboCriteria.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(228, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(299, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.advQuit);
            this.groupBox1.Controls.Add(this.advSearch);
            this.groupBox1.Location = new System.Drawing.Point(59, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // advSearch
            // 
            this.advSearch.Location = new System.Drawing.Point(87, 24);
            this.advSearch.Name = "advSearch";
            this.advSearch.Size = new System.Drawing.Size(75, 23);
            this.advSearch.TabIndex = 0;
            this.advSearch.Text = "Search";
            this.advSearch.UseVisualStyleBackColor = true;
            this.advSearch.Click += new System.EventHandler(this.advSearch_Click);
            // 
            // advQuit
            // 
            this.advQuit.Location = new System.Drawing.Point(307, 24);
            this.advQuit.Name = "advQuit";
            this.advQuit.Size = new System.Drawing.Size(75, 23);
            this.advQuit.TabIndex = 1;
            this.advQuit.Text = "Quit";
            this.advQuit.UseVisualStyleBackColor = true;
            this.advQuit.Click += new System.EventHandler(this.advQuit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(375, 277);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gboData
            // 
            this.gboData.Controls.Add(this.dataGridView1);
            this.gboData.Location = new System.Drawing.Point(6, 19);
            this.gboData.Name = "gboData";
            this.gboData.Size = new System.Drawing.Size(584, 184);
            this.gboData.TabIndex = 2;
            this.gboData.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Centre_Code,
            this.Centre_Name,
            this.Location,
            this.University_Code});
            this.dataGridView1.Location = new System.Drawing.Point(6, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // Centre_Code
            // 
            this.Centre_Code.HeaderText = "Centre Code";
            this.Centre_Code.Name = "Centre_Code";
            // 
            // Centre_Name
            // 
            this.Centre_Name.HeaderText = "Centre Name";
            this.Centre_Name.Name = "Centre_Name";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // University_Code
            // 
            this.University_Code.HeaderText = "University Code";
            this.University_Code.Name = "University_Code";
            // 
            // frmCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(785, 509);
            this.Controls.Add(this.gboMain);
            this.Name = "frmCentre";
            this.Text = "frmCentre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCentre_Load);
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

        private System.Windows.Forms.GroupBox gboMain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCentreName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtUniversityCode;
        private System.Windows.Forms.TextBox txtCentreCode;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cboCentreCode;
        private System.Windows.Forms.GroupBox gboSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button advQuit;
        private System.Windows.Forms.Button advSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gboData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Centre_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Centre_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn University_Code;
    }
}
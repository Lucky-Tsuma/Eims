namespace Eims
{
    partial class frmStudent
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
            this.gboData = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Reg_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postal_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Academic_Year_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboSearch = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAdvQuit = new System.Windows.Forms.Button();
            this.btnAdvSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboRegNo = new System.Windows.Forms.ComboBox();
            this.rbtnOff = new System.Windows.Forms.RadioButton();
            this.rbtnOn = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPostalAddress = new System.Windows.Forms.TextBox();
            this.txtAcademicYCode = new System.Windows.Forms.TextBox();
            this.txtYearCode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtProgramCode = new System.Windows.Forms.TextBox();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pboxStudent = new System.Windows.Forms.PictureBox();
            this.gboMain.SuspendLayout();
            this.gboData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gboSearch.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gboMain
            // 
            this.gboMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gboMain.Controls.Add(this.groupBox3);
            this.gboMain.Controls.Add(this.groupBox2);
            this.gboMain.Controls.Add(this.groupBox1);
            this.gboMain.Location = new System.Drawing.Point(2, 12);
            this.gboMain.Name = "gboMain";
            this.gboMain.Size = new System.Drawing.Size(750, 486);
            this.gboMain.TabIndex = 0;
            this.gboMain.TabStop = false;
            this.gboMain.Enter += new System.EventHandler(this.gboMain_Enter);
            // 
            // gboData
            // 
            this.gboData.Controls.Add(this.dataGridView1);
            this.gboData.Location = new System.Drawing.Point(0, 0);
            this.gboData.Name = "gboData";
            this.gboData.Size = new System.Drawing.Size(561, 199);
            this.gboData.TabIndex = 5;
            this.gboData.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reg_No,
            this.F_Name,
            this.M_Name,
            this.L_Name,
            this.Status,
            this.Phone,
            this.Email,
            this.Postal_Address,
            this.Program_Code,
            this.Academic_Year_Code,
            this.Year_Code});
            this.dataGridView1.Location = new System.Drawing.Point(6, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // Reg_No
            // 
            this.Reg_No.HeaderText = "Reg No";
            this.Reg_No.Name = "Reg_No";
            // 
            // F_Name
            // 
            this.F_Name.HeaderText = "F Name";
            this.F_Name.Name = "F_Name";
            // 
            // M_Name
            // 
            this.M_Name.HeaderText = "M Name";
            this.M_Name.Name = "M_Name";
            // 
            // L_Name
            // 
            this.L_Name.HeaderText = "L Name";
            this.L_Name.Name = "L_Name";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Postal_Address
            // 
            this.Postal_Address.HeaderText = "Postal Address";
            this.Postal_Address.Name = "Postal_Address";
            // 
            // Program_Code
            // 
            this.Program_Code.HeaderText = "Program Code";
            this.Program_Code.Name = "Program_Code";
            // 
            // Academic_Year_Code
            // 
            this.Academic_Year_Code.HeaderText = "Academic Year Code";
            this.Academic_Year_Code.Name = "Academic_Year_Code";
            // 
            // Year_Code
            // 
            this.Year_Code.HeaderText = "Year Code";
            this.Year_Code.Name = "Year_Code";
            // 
            // gboSearch
            // 
            this.gboSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.gboSearch.Controls.Add(this.gboData);
            this.gboSearch.Controls.Add(this.groupBox4);
            this.gboSearch.Controls.Add(this.txtSearch);
            this.gboSearch.Controls.Add(this.cboCriteria);
            this.gboSearch.Controls.Add(this.label13);
            this.gboSearch.Controls.Add(this.label12);
            this.gboSearch.Location = new System.Drawing.Point(104, 16);
            this.gboSearch.Name = "gboSearch";
            this.gboSearch.Size = new System.Drawing.Size(561, 215);
            this.gboSearch.TabIndex = 3;
            this.gboSearch.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox4.Controls.Add(this.btnAdvQuit);
            this.groupBox4.Controls.Add(this.btnAdvSearch);
            this.groupBox4.Location = new System.Drawing.Point(82, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(414, 76);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // btnAdvQuit
            // 
            this.btnAdvQuit.Location = new System.Drawing.Point(258, 21);
            this.btnAdvQuit.Name = "btnAdvQuit";
            this.btnAdvQuit.Size = new System.Drawing.Size(75, 23);
            this.btnAdvQuit.TabIndex = 1;
            this.btnAdvQuit.Text = "Quit";
            this.btnAdvQuit.UseVisualStyleBackColor = true;
            this.btnAdvQuit.Click += new System.EventHandler(this.btnAdvQuit_Click);
            // 
            // btnAdvSearch
            // 
            this.btnAdvSearch.Location = new System.Drawing.Point(50, 21);
            this.btnAdvSearch.Name = "btnAdvSearch";
            this.btnAdvSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAdvSearch.TabIndex = 0;
            this.btnAdvSearch.Text = "Search";
            this.btnAdvSearch.UseVisualStyleBackColor = true;
            this.btnAdvSearch.Click += new System.EventHandler(this.btnAdvSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(203, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // cboCriteria
            // 
            this.cboCriteria.FormattingEnabled = true;
            this.cboCriteria.Items.AddRange(new object[] {
            "Firstname",
            "Middlename",
            "Lastname",
            "onSession",
            "offSession",
            "Phone",
            "Email Address",
            "Postal Address",
            "Program Code",
            "Academic Year Code",
            "Year Code"});
            this.cboCriteria.Location = new System.Drawing.Point(203, 24);
            this.cboCriteria.Name = "cboCriteria";
            this.cboCriteria.Size = new System.Drawing.Size(293, 21);
            this.cboCriteria.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Search Value:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Search Criteria:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQuit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(724, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(580, 29);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 20;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(499, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(418, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Searc&h  ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(337, 29);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(256, 29);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(87, 29);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboRegNo);
            this.groupBox2.Controls.Add(this.gboSearch);
            this.groupBox2.Controls.Add(this.rbtnOff);
            this.groupBox2.Controls.Add(this.rbtnOn);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtFName);
            this.groupBox2.Controls.Add(this.txtMName);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtPostalAddress);
            this.groupBox2.Controls.Add(this.txtAcademicYCode);
            this.groupBox2.Controls.Add(this.txtYearCode);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtProgramCode);
            this.groupBox2.Controls.Add(this.txtRegNo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Details";
            // 
            // cboRegNo
            // 
            this.cboRegNo.FormattingEnabled = true;
            this.cboRegNo.Location = new System.Drawing.Point(74, 16);
            this.cboRegNo.Name = "cboRegNo";
            this.cboRegNo.Size = new System.Drawing.Size(203, 21);
            this.cboRegNo.TabIndex = 22;
            // 
            // rbtnOff
            // 
            this.rbtnOff.AutoSize = true;
            this.rbtnOff.Location = new System.Drawing.Point(192, 151);
            this.rbtnOff.Name = "rbtnOff";
            this.rbtnOff.Size = new System.Drawing.Size(74, 17);
            this.rbtnOff.TabIndex = 7;
            this.rbtnOff.TabStop = true;
            this.rbtnOff.Text = "offSession";
            this.rbtnOff.UseVisualStyleBackColor = true;
            // 
            // rbtnOn
            // 
            this.rbtnOn.AutoSize = true;
            this.rbtnOn.Location = new System.Drawing.Point(76, 152);
            this.rbtnOn.Name = "rbtnOn";
            this.rbtnOn.Size = new System.Drawing.Size(74, 17);
            this.rbtnOn.TabIndex = 6;
            this.rbtnOn.TabStop = true;
            this.rbtnOn.Text = "onSession";
            this.rbtnOn.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(361, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Year Code";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(76, 50);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(201, 20);
            this.txtFName.TabIndex = 3;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(76, 82);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(201, 20);
            this.txtMName.TabIndex = 4;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(76, 114);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(201, 20);
            this.txtLName.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(76, 183);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(201, 20);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtPostalAddress
            // 
            this.txtPostalAddress.Location = new System.Drawing.Point(496, 46);
            this.txtPostalAddress.Name = "txtPostalAddress";
            this.txtPostalAddress.Size = new System.Drawing.Size(198, 20);
            this.txtPostalAddress.TabIndex = 10;
            // 
            // txtAcademicYCode
            // 
            this.txtAcademicYCode.Location = new System.Drawing.Point(496, 110);
            this.txtAcademicYCode.Name = "txtAcademicYCode";
            this.txtAcademicYCode.Size = new System.Drawing.Size(198, 20);
            this.txtAcademicYCode.TabIndex = 12;
            // 
            // txtYearCode
            // 
            this.txtYearCode.Location = new System.Drawing.Point(496, 144);
            this.txtYearCode.Name = "txtYearCode";
            this.txtYearCode.Size = new System.Drawing.Size(198, 20);
            this.txtYearCode.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(496, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtProgramCode
            // 
            this.txtProgramCode.Location = new System.Drawing.Point(496, 78);
            this.txtProgramCode.Name = "txtProgramCode";
            this.txtProgramCode.Size = new System.Drawing.Size(198, 20);
            this.txtProgramCode.TabIndex = 11;
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(76, 16);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(201, 20);
            this.txtRegNo.TabIndex = 2;
            this.txtRegNo.TextChanged += new System.EventHandler(this.txtRegNo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(361, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Academic Y Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(361, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Program Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(361, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Postal Adress";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "L Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "M Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "F Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.pboxStudent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(283, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photo";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(64, 108);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pboxStudent
            // 
            this.pboxStudent.Location = new System.Drawing.Point(50, 10);
            this.pboxStudent.Name = "pboxStudent";
            this.pboxStudent.Size = new System.Drawing.Size(102, 92);
            this.pboxStudent.TabIndex = 1;
            this.pboxStudent.TabStop = false;
            this.pboxStudent.Click += new System.EventHandler(this.pboxStudent_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 510);
            this.Controls.Add(this.gboMain);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.gboMain.ResumeLayout(false);
            this.gboData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gboSearch.ResumeLayout(false);
            this.gboSearch.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnOff;
        private System.Windows.Forms.RadioButton rbtnOn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPostalAddress;
        private System.Windows.Forms.TextBox txtAcademicYCode;
        private System.Windows.Forms.TextBox txtYearCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtProgramCode;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pboxStudent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cboRegNo;
        private System.Windows.Forms.GroupBox gboSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAdvQuit;
        private System.Windows.Forms.Button btnAdvSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gboData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reg_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn L_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postal_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Academic_Year_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year_Code;
    }
}
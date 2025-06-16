namespace EmployeeManagement.Screens.Employees
{
    partial class EmployeeInfoForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SaveRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.BranchNameComboBox = new System.Windows.Forms.ComboBox();
            this.ClearPictureBox = new System.Windows.Forms.PictureBox();
            this.GetPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.DateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TcNoTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.Branch = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.TcTextBox = new System.Windows.Forms.Label();
            this.EmploymentDate = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Employee = new System.Windows.Forms.Label();
            this.PhotopictureBox = new System.Windows.Forms.PictureBox();
            this.topPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EmploymentsDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.JobTitleComboBox = new System.Windows.Forms.ComboBox();
            this.StartingSalaryTextBox = new System.Windows.Forms.TextBox();
            this.CurrentSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressGroupBox = new System.Windows.Forms.GroupBox();
            this.DistrictComboBox = new System.Windows.Forms.ComboBox();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.PostCodeTextBox = new System.Windows.Forms.TextBox();
            this.AdressLineTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.EmployeeLeavingCommentsTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeLeavingReasonComboBox = new System.Windows.Forms.ComboBox();
            this.DateLeftDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HasLeftComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotopictureBox)).BeginInit();
            this.topPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.EmploymentsDetailsGroupBox.SuspendLayout();
            this.AddressGroupBox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveRecordToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(18, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(1144, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SaveRecordToolStripMenuItem
            // 
            this.SaveRecordToolStripMenuItem.Name = "SaveRecordToolStripMenuItem";
            this.SaveRecordToolStripMenuItem.Size = new System.Drawing.Size(122, 27);
            this.SaveRecordToolStripMenuItem.Text = "Kaydı Kaydet";
            this.SaveRecordToolStripMenuItem.Click += new System.EventHandler(this.SaveRecordToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(68, 27);
            this.CloseToolStripMenuItem.Text = "Kapat";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.FullNameTextBox);
            this.panel1.Controls.Add(this.BranchNameComboBox);
            this.panel1.Controls.Add(this.ClearPictureBox);
            this.panel1.Controls.Add(this.GetPhotoPictureBox);
            this.panel1.Controls.Add(this.DateOfBirthDateTimePicker);
            this.panel1.Controls.Add(this.GenderComboBox);
            this.panel1.Controls.Add(this.MobileTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TcNoTextBox);
            this.panel1.Controls.Add(this.TelephoneTextBox);
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.EmployeeIDTextBox);
            this.panel1.Controls.Add(this.Branch);
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.TcTextBox);
            this.panel1.Controls.Add(this.EmploymentDate);
            this.panel1.Controls.Add(this.Telephone);
            this.panel1.Controls.Add(this.FullName);
            this.panel1.Controls.Add(this.DateOfBirth);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Employee);
            this.panel1.Controls.Add(this.PhotopictureBox);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(20, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.panel1.Size = new System.Drawing.Size(1104, 312);
            this.panel1.TabIndex = 1;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FullNameTextBox.Location = new System.Drawing.Point(370, 65);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(265, 30);
            this.FullNameTextBox.TabIndex = 25;
            // 
            // BranchNameComboBox
            // 
            this.BranchNameComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.BranchNameComboBox.FormattingEnabled = true;
            this.BranchNameComboBox.Location = new System.Drawing.Point(825, 251);
            this.BranchNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BranchNameComboBox.Name = "BranchNameComboBox";
            this.BranchNameComboBox.Size = new System.Drawing.Size(250, 31);
            this.BranchNameComboBox.TabIndex = 24;
            // 
            // ClearPictureBox
            // 
            this.ClearPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ClearPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearPictureBox.Image = global::EmployeeManagement.Properties.Resources.image__1_;
            this.ClearPictureBox.Location = new System.Drawing.Point(112, 231);
            this.ClearPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearPictureBox.Name = "ClearPictureBox";
            this.ClearPictureBox.Size = new System.Drawing.Size(46, 50);
            this.ClearPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClearPictureBox.TabIndex = 23;
            this.ClearPictureBox.TabStop = false;
            this.ClearPictureBox.Click += new System.EventHandler(this.ClearPictureBox_Click);
            // 
            // GetPhotoPictureBox
            // 
            this.GetPhotoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.GetPhotoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetPhotoPictureBox.Image = global::EmployeeManagement.Properties.Resources.image;
            this.GetPhotoPictureBox.Location = new System.Drawing.Point(52, 231);
            this.GetPhotoPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetPhotoPictureBox.Name = "GetPhotoPictureBox";
            this.GetPhotoPictureBox.Size = new System.Drawing.Size(46, 50);
            this.GetPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GetPhotoPictureBox.TabIndex = 22;
            this.GetPhotoPictureBox.TabStop = false;
            this.GetPhotoPictureBox.Click += new System.EventHandler(this.GetPhotoPictureBox_Click);
            // 
            // DateOfBirthDateTimePicker
            // 
            this.DateOfBirthDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.DateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirthDateTimePicker.Location = new System.Drawing.Point(370, 115);
            this.DateOfBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            this.DateOfBirthDateTimePicker.Size = new System.Drawing.Size(265, 30);
            this.DateOfBirthDateTimePicker.TabIndex = 20;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(825, 198);
            this.GenderComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(250, 31);
            this.GenderComboBox.TabIndex = 19;
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.MobileTextBox.Location = new System.Drawing.Point(825, 135);
            this.MobileTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(250, 30);
            this.MobileTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(670, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cinsiyet :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TcNoTextBox
            // 
            this.TcNoTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TcNoTextBox.Location = new System.Drawing.Point(825, 78);
            this.TcNoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TcNoTextBox.Name = "TcNoTextBox";
            this.TcNoTextBox.Size = new System.Drawing.Size(250, 30);
            this.TcNoTextBox.TabIndex = 15;
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TelephoneTextBox.Location = new System.Drawing.Point(370, 215);
            this.TelephoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(265, 30);
            this.TelephoneTextBox.TabIndex = 14;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.EmailTextBox.Location = new System.Drawing.Point(370, 165);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(265, 30);
            this.EmailTextBox.TabIndex = 13;
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Enabled = false;
            this.EmployeeIDTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(370, 18);
            this.EmployeeIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(100, 30);
            this.EmployeeIDTextBox.TabIndex = 11;
            // 
            // Branch
            // 
            this.Branch.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Branch.ForeColor = System.Drawing.Color.Black;
            this.Branch.Location = new System.Drawing.Point(670, 255);
            this.Branch.Name = "Branch";
            this.Branch.Size = new System.Drawing.Size(145, 31);
            this.Branch.TabIndex = 10;
            this.Branch.Text = "Şube :";
            this.Branch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Gender.ForeColor = System.Drawing.Color.Black;
            this.Gender.Location = new System.Drawing.Point(670, 139);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(145, 31);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Cep Telefon :";
            this.Gender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TcTextBox
            // 
            this.TcTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TcTextBox.ForeColor = System.Drawing.Color.Black;
            this.TcTextBox.Location = new System.Drawing.Point(670, 81);
            this.TcTextBox.Name = "TcTextBox";
            this.TcTextBox.Size = new System.Drawing.Size(145, 31);
            this.TcTextBox.TabIndex = 8;
            this.TcTextBox.Text = "TC Numarası :";
            this.TcTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmploymentDate
            // 
            this.EmploymentDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.EmploymentDate.ForeColor = System.Drawing.Color.Black;
            this.EmploymentDate.Location = new System.Drawing.Point(670, 21);
            this.EmploymentDate.Name = "EmploymentDate";
            this.EmploymentDate.Size = new System.Drawing.Size(145, 31);
            this.EmploymentDate.TabIndex = 7;
            this.EmploymentDate.Text = "Çalışma Tarihi :";
            this.EmploymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Telephone
            // 
            this.Telephone.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Telephone.ForeColor = System.Drawing.Color.Black;
            this.Telephone.Location = new System.Drawing.Point(215, 219);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(145, 31);
            this.Telephone.TabIndex = 6;
            this.Telephone.Text = "Sabit Telefon :";
            this.Telephone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FullName
            // 
            this.FullName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FullName.ForeColor = System.Drawing.Color.Black;
            this.FullName.Location = new System.Drawing.Point(215, 69);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(145, 31);
            this.FullName.TabIndex = 5;
            this.FullName.Text = "Ad Soyad :";
            this.FullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.DateOfBirth.ForeColor = System.Drawing.Color.Black;
            this.DateOfBirth.Location = new System.Drawing.Point(215, 119);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(145, 31);
            this.DateOfBirth.TabIndex = 4;
            this.DateOfBirth.Text = "Doğum Tarihi :";
            this.DateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Email.ForeColor = System.Drawing.Color.Black;
            this.Email.Location = new System.Drawing.Point(215, 169);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(145, 31);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email :";
            this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Employee
            // 
            this.Employee.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Employee.ForeColor = System.Drawing.Color.Black;
            this.Employee.Location = new System.Drawing.Point(215, 21);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(145, 31);
            this.Employee.TabIndex = 2;
            this.Employee.Text = "Çalışan No :";
            this.Employee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PhotopictureBox
            // 
            this.PhotopictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.PhotopictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotopictureBox.Location = new System.Drawing.Point(25, 25);
            this.PhotopictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhotopictureBox.Name = "PhotopictureBox";
            this.PhotopictureBox.Size = new System.Drawing.Size(160, 200);
            this.PhotopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotopictureBox.TabIndex = 1;
            this.PhotopictureBox.TabStop = false;
            // 
            // topPage
            // 
            this.topPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPage.Controls.Add(this.tabPage1);
            this.topPage.Controls.Add(this.tabPage3);
            this.topPage.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.topPage.Location = new System.Drawing.Point(20, 394);
            this.topPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topPage.Name = "topPage";
            this.topPage.Padding = new System.Drawing.Point(20, 5);
            this.topPage.SelectedIndex = 0;
            this.topPage.Size = new System.Drawing.Size(1104, 475);
            this.topPage.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabPage1.Controls.Add(this.EmploymentsDetailsGroupBox);
            this.tabPage1.Controls.Add(this.AddressGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.tabPage1.Size = new System.Drawing.Size(1096, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Çalışan Detayları";
            // 
            // EmploymentsDetailsGroupBox
            // 
            this.EmploymentsDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmploymentsDetailsGroupBox.BackColor = System.Drawing.Color.White;
            this.EmploymentsDetailsGroupBox.Controls.Add(this.JobTitleComboBox);
            this.EmploymentsDetailsGroupBox.Controls.Add(this.StartingSalaryTextBox);
            this.EmploymentsDetailsGroupBox.Controls.Add(this.CurrentSalaryTextBox);
            this.EmploymentsDetailsGroupBox.Controls.Add(this.label8);
            this.EmploymentsDetailsGroupBox.Controls.Add(this.label7);
            this.EmploymentsDetailsGroupBox.Controls.Add(this.label6);
            this.EmploymentsDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.EmploymentsDetailsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.EmploymentsDetailsGroupBox.Location = new System.Drawing.Point(540, 25);
            this.EmploymentsDetailsGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmploymentsDetailsGroupBox.Name = "EmploymentsDetailsGroupBox";
            this.EmploymentsDetailsGroupBox.Padding = new System.Windows.Forms.Padding(15, 19, 15, 19);
            this.EmploymentsDetailsGroupBox.Size = new System.Drawing.Size(543, 275);
            this.EmploymentsDetailsGroupBox.TabIndex = 1;
            this.EmploymentsDetailsGroupBox.TabStop = false;
            this.EmploymentsDetailsGroupBox.Text = "İstihdam Detayları";
            // 
            // JobTitleComboBox
            // 
            this.JobTitleComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JobTitleComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.JobTitleComboBox.FormattingEnabled = true;
            this.JobTitleComboBox.Location = new System.Drawing.Point(180, 60);
            this.JobTitleComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.JobTitleComboBox.Name = "JobTitleComboBox";
            this.JobTitleComboBox.Size = new System.Drawing.Size(340, 31);
            this.JobTitleComboBox.TabIndex = 24;
            // 
            // StartingSalaryTextBox
            // 
            this.StartingSalaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartingSalaryTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.StartingSalaryTextBox.Location = new System.Drawing.Point(180, 165);
            this.StartingSalaryTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartingSalaryTextBox.Name = "StartingSalaryTextBox";
            this.StartingSalaryTextBox.Size = new System.Drawing.Size(340, 30);
            this.StartingSalaryTextBox.TabIndex = 35;
            // 
            // CurrentSalaryTextBox
            // 
            this.CurrentSalaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentSalaryTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.CurrentSalaryTextBox.Location = new System.Drawing.Point(180, 112);
            this.CurrentSalaryTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentSalaryTextBox.Name = "CurrentSalaryTextBox";
            this.CurrentSalaryTextBox.Size = new System.Drawing.Size(340, 30);
            this.CurrentSalaryTextBox.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 31);
            this.label8.TabIndex = 32;
            this.label8.Text = "Güncel Maaş :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 31);
            this.label7.TabIndex = 31;
            this.label7.Text = "Başlangıç Maaşı :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 31);
            this.label6.TabIndex = 30;
            this.label6.Text = "Departman:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddressGroupBox
            // 
            this.AddressGroupBox.BackColor = System.Drawing.Color.White;
            this.AddressGroupBox.Controls.Add(this.DistrictComboBox);
            this.AddressGroupBox.Controls.Add(this.CityComboBox);
            this.AddressGroupBox.Controls.Add(this.PostCodeTextBox);
            this.AddressGroupBox.Controls.Add(this.AdressLineTextBox);
            this.AddressGroupBox.Controls.Add(this.label5);
            this.AddressGroupBox.Controls.Add(this.label4);
            this.AddressGroupBox.Controls.Add(this.label3);
            this.AddressGroupBox.Controls.Add(this.label2);
            this.AddressGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.AddressGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.AddressGroupBox.Location = new System.Drawing.Point(20, 25);
            this.AddressGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressGroupBox.Name = "AddressGroupBox";
            this.AddressGroupBox.Padding = new System.Windows.Forms.Padding(15, 19, 15, 19);
            this.AddressGroupBox.Size = new System.Drawing.Size(500, 275);
            this.AddressGroupBox.TabIndex = 0;
            this.AddressGroupBox.TabStop = false;
            this.AddressGroupBox.Text = "Adres Bilgileri";
            // 
            // DistrictComboBox
            // 
            this.DistrictComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistrictComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.DistrictComboBox.FormattingEnabled = true;
            this.DistrictComboBox.Location = new System.Drawing.Point(140, 158);
            this.DistrictComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DistrictComboBox.Name = "DistrictComboBox";
            this.DistrictComboBox.Size = new System.Drawing.Size(337, 31);
            this.DistrictComboBox.TabIndex = 29;
            // 
            // CityComboBox
            // 
            this.CityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(140, 108);
            this.CityComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(337, 31);
            this.CityComboBox.TabIndex = 22;
            // 
            // PostCodeTextBox
            // 
            this.PostCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.PostCodeTextBox.Location = new System.Drawing.Point(140, 208);
            this.PostCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PostCodeTextBox.Name = "PostCodeTextBox";
            this.PostCodeTextBox.Size = new System.Drawing.Size(337, 30);
            this.PostCodeTextBox.TabIndex = 28;
            // 
            // AdressLineTextBox
            // 
            this.AdressLineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressLineTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.AdressLineTextBox.Location = new System.Drawing.Point(140, 58);
            this.AdressLineTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdressLineTextBox.Name = "AdressLineTextBox";
            this.AdressLineTextBox.Size = new System.Drawing.Size(337, 30);
            this.AdressLineTextBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "Posta Kodu:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 24;
            this.label4.Text = "İlçe :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Şehir :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Adres Satırı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabPage3.Controls.Add(this.EmployeeLeavingCommentsTextBox);
            this.tabPage3.Controls.Add(this.EmployeeLeavingReasonComboBox);
            this.tabPage3.Controls.Add(this.DateLeftDateTimePicker);
            this.tabPage3.Controls.Add(this.HasLeftComboBox);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(20, 25, 20, 25);
            this.tabPage3.Size = new System.Drawing.Size(1096, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Çıkış Bilgileri";
            // 
            // EmployeeLeavingCommentsTextBox
            // 
            this.EmployeeLeavingCommentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeLeavingCommentsTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.EmployeeLeavingCommentsTextBox.Location = new System.Drawing.Point(480, 88);
            this.EmployeeLeavingCommentsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeLeavingCommentsTextBox.Multiline = true;
            this.EmployeeLeavingCommentsTextBox.Name = "EmployeeLeavingCommentsTextBox";
            this.EmployeeLeavingCommentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EmployeeLeavingCommentsTextBox.Size = new System.Drawing.Size(593, 308);
            this.EmployeeLeavingCommentsTextBox.TabIndex = 24;
            // 
            // EmployeeLeavingReasonComboBox
            // 
            this.EmployeeLeavingReasonComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.EmployeeLeavingReasonComboBox.FormattingEnabled = true;
            this.EmployeeLeavingReasonComboBox.Location = new System.Drawing.Point(190, 144);
            this.EmployeeLeavingReasonComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeLeavingReasonComboBox.Name = "EmployeeLeavingReasonComboBox";
            this.EmployeeLeavingReasonComboBox.Size = new System.Drawing.Size(250, 31);
            this.EmployeeLeavingReasonComboBox.TabIndex = 28;
            // 
            // DateLeftDateTimePicker
            // 
            this.DateLeftDateTimePicker.Checked = false;
            this.DateLeftDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.DateLeftDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateLeftDateTimePicker.Location = new System.Drawing.Point(190, 88);
            this.DateLeftDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateLeftDateTimePicker.Name = "DateLeftDateTimePicker";
            this.DateLeftDateTimePicker.ShowCheckBox = true;
            this.DateLeftDateTimePicker.Size = new System.Drawing.Size(250, 30);
            this.DateLeftDateTimePicker.TabIndex = 24;
            // 
            // HasLeftComboBox
            // 
            this.HasLeftComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.HasLeftComboBox.FormattingEnabled = true;
            this.HasLeftComboBox.Location = new System.Drawing.Point(190, 31);
            this.HasLeftComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HasLeftComboBox.Name = "HasLeftComboBox";
            this.HasLeftComboBox.Size = new System.Drawing.Size(250, 31);
            this.HasLeftComboBox.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(476, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 31);
            this.label12.TabIndex = 27;
            this.label12.Text = "Açıklama (İsteğe Bağlı) :";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(25, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 31);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ayrılma Sebebi:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(25, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 31);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ayrılma Tarihi :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(25, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 31);
            this.label9.TabIndex = 24;
            this.label9.Text = "Çalışma Durumu :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmployeeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1144, 894);
            this.Controls.Add(this.topPage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeInfoForm";
            this.Text = "Çalışan Bilgi Formu";
            this.Load += new System.EventHandler(this.EmployeeInfoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotopictureBox)).EndInit();
            this.topPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.EmploymentsDetailsGroupBox.ResumeLayout(false);
            this.EmploymentsDetailsGroupBox.PerformLayout();
            this.AddressGroupBox.ResumeLayout(false);
            this.AddressGroupBox.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SaveRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PhotopictureBox;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label DateOfBirth;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.Label EmploymentDate;
        private System.Windows.Forms.Label TcTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TcNoTextBox;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.Label Branch;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthDateTimePicker;
        private System.Windows.Forms.TabControl topPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox AddressGroupBox;
        private System.Windows.Forms.GroupBox EmploymentsDetailsGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DistrictComboBox;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.TextBox PostCodeTextBox;
        private System.Windows.Forms.TextBox AdressLineTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StartingSalaryTextBox;
        private System.Windows.Forms.TextBox CurrentSalaryTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox GetPhotoPictureBox;
        private System.Windows.Forms.PictureBox ClearPictureBox;
        private System.Windows.Forms.ComboBox JobTitleComboBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmployeeLeavingCommentsTextBox;
        private System.Windows.Forms.ComboBox EmployeeLeavingReasonComboBox;
        private System.Windows.Forms.DateTimePicker DateLeftDateTimePicker;
        private System.Windows.Forms.ComboBox HasLeftComboBox;
        private System.Windows.Forms.ComboBox BranchNameComboBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
    }
}
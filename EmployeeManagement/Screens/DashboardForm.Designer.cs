namespace EmployeeManagement.Screens
{
    partial class DashboardForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewEmployeeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BranchYonetimToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageUsersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.labelWelcomeMessage = new System.Windows.Forms.Label();
            this.labelAppName = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(128, 28);
            this.ExitToolStripMenuItem.Text = "Çıkış";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.HelpToolStripMenuItem.Text = "&Yardım";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click_1);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 27);
            this.AboutToolStripMenuItem.Text = "&Hakkında";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewEmployeeButton,
            this.toolStripSeparator1,
            this.BranchYonetimToolStripButton,
            this.toolStripSeparator2,
            this.ManageUsersToolStripButton,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.toolStrip1.Size = new System.Drawing.Size(1200, 86);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewEmployeeButton
            // 
            this.NewEmployeeButton.AutoSize = false;
            this.NewEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewEmployeeButton.Image = global::EmployeeManagement.Properties.Resources.add__1_;
            this.NewEmployeeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewEmployeeButton.Margin = new System.Windows.Forms.Padding(5);
            this.NewEmployeeButton.Name = "NewEmployeeButton";
            this.NewEmployeeButton.Size = new System.Drawing.Size(130, 64);
            this.NewEmployeeButton.Text = "Yeni Çalışan Ekle";
            this.NewEmployeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewEmployeeButton.Click += new System.EventHandler(this.NewEmployeeButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 74);
            // 
            // BranchYonetimToolStripButton
            // 
            this.BranchYonetimToolStripButton.AutoSize = false;
            this.BranchYonetimToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BranchYonetimToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BranchYonetimToolStripButton.Image = global::EmployeeManagement.Properties.Resources.hierarchy;
            this.BranchYonetimToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BranchYonetimToolStripButton.Margin = new System.Windows.Forms.Padding(5);
            this.BranchYonetimToolStripButton.Name = "BranchYonetimToolStripButton";
            this.BranchYonetimToolStripButton.Size = new System.Drawing.Size(130, 64);
            this.BranchYonetimToolStripButton.Text = "Şube Yönetimi";
            this.BranchYonetimToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BranchYonetimToolStripButton.Click += new System.EventHandler(this.BranchYonetimToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 74);
            // 
            // ManageUsersToolStripButton
            // 
            this.ManageUsersToolStripButton.AutoSize = false;
            this.ManageUsersToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ManageUsersToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ManageUsersToolStripButton.Image = global::EmployeeManagement.Properties.Resources.employee;
            this.ManageUsersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManageUsersToolStripButton.Margin = new System.Windows.Forms.Padding(5);
            this.ManageUsersToolStripButton.Name = "ManageUsersToolStripButton";
            this.ManageUsersToolStripButton.Size = new System.Drawing.Size(130, 64);
            this.ManageUsersToolStripButton.Text = "Çalışan Yönetimi";
            this.ManageUsersToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ManageUsersToolStripButton.Click += new System.EventHandler(this.ManageUsersToolStripButton_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 74);
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.labelWelcomeMessage);
            this.panelWelcome.Controls.Add(this.labelAppName);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWelcome.Location = new System.Drawing.Point(0, 117);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(840, 672);
            this.panelWelcome.TabIndex = 2;
            // 
            // labelWelcomeMessage
            // 
            this.labelWelcomeMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWelcomeMessage.AutoSize = true;
            this.labelWelcomeMessage.Font = new System.Drawing.Font("Segoe UI Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWelcomeMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.labelWelcomeMessage.Location = new System.Drawing.Point(265, 336);
            this.labelWelcomeMessage.Name = "labelWelcomeMessage";
            this.labelWelcomeMessage.Size = new System.Drawing.Size(293, 50);
            this.labelWelcomeMessage.TabIndex = 1;
            this.labelWelcomeMessage.Text = "Tekrar Hoş Geldin";
            this.labelWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAppName
            // 
            this.labelAppName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.labelAppName.Location = new System.Drawing.Point(145, 266);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(531, 62);
            this.labelAppName.TabIndex = 0;
            this.labelAppName.Text = "Çalışan Yönetim Sistemi";
            this.labelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.monthCalendar1);
            this.panelRight.Controls.Add(this.labelTime);
            this.panelRight.Controls.Add(this.labelDate);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(840, 117);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(360, 672);
            this.panelRight.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthCalendar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monthCalendar1.Location = new System.Drawing.Point(55, 180);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.White;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.labelTime.Location = new System.Drawing.Point(9, 30);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(340, 60);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "22:15:45";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.labelDate.Location = new System.Drawing.Point(9, 90);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(340, 30);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "23 Ekim 2023 Cuma";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1200, 789);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardForm";
            this.Text = "Ana Panel - Çalışan Yönetim Sistemi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewEmployeeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BranchYonetimToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ManageUsersToolStripButton;
        // --- YENİ KONTROLLER ---
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label labelWelcomeMessage;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer timer1;
    }
}
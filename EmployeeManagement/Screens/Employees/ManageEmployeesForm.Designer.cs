namespace EmployeeManagement.Screens.Employees
{
    partial class ManageEmployeesForm
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
            this.EmployeedataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelTopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.LabelTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeedataGridView
            // 
            this.EmployeedataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EmployeedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeedataGridView.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EmployeedataGridView.Location = new System.Drawing.Point(37, 135);
            this.EmployeedataGridView.Name = "EmployeedataGridView";
            this.EmployeedataGridView.RowHeadersWidth = 51;
            this.EmployeedataGridView.RowTemplate.Height = 24;
            this.EmployeedataGridView.Size = new System.Drawing.Size(849, 511);
            this.EmployeedataGridView.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewEmployeeToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddNewEmployeeToolStripMenuItem
            // 
            this.AddNewEmployeeToolStripMenuItem.Name = "AddNewEmployeeToolStripMenuItem";
            this.AddNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(113, 27);
            this.AddNewEmployeeToolStripMenuItem.Text = "Çalışan Ekle";
            this.AddNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.AddNewEmployeeToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(68, 27);
            this.CloseToolStripMenuItem.Text = "Kapat";
            // 
            // LabelTopPanel
            // 
            this.LabelTopPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.LabelTopPanel.Controls.Add(this.label1);
            this.LabelTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTopPanel.Location = new System.Drawing.Point(0, 31);
            this.LabelTopPanel.Name = "LabelTopPanel";
            this.LabelTopPanel.Size = new System.Drawing.Size(929, 63);
            this.LabelTopPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(306, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışan Yönetim Ekranı";
            // 
            // ManageEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 687);
            this.Controls.Add(this.LabelTopPanel);
            this.Controls.Add(this.EmployeedataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageEmployeesForm";
            this.Text = "Çalışan Yönetim Ekranı";
            this.Load += new System.EventHandler(this.ManageEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LabelTopPanel.ResumeLayout(false);
            this.LabelTopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.DataGridView EmployeedataGridView;
        private System.Windows.Forms.Panel LabelTopPanel;
        private System.Windows.Forms.Label label1;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.EmployeedataGridView.AllowUserToAddRows = false;
            this.EmployeedataGridView.AllowUserToDeleteRows = false;
            this.EmployeedataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeedataGridView.BackgroundColor = System.Drawing.Color.White;
            this.EmployeedataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeedataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeedataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeedataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeedataGridView.ColumnHeadersHeight = 40;
            this.EmployeedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeedataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeedataGridView.EnableHeadersVisualStyles = false;
            this.EmployeedataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.EmployeedataGridView.Location = new System.Drawing.Point(20, 144);
            this.EmployeedataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeedataGridView.Name = "EmployeedataGridView";
            this.EmployeedataGridView.ReadOnly = true;
            this.EmployeedataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeedataGridView.RowHeadersVisible = false;
            this.EmployeedataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.EmployeedataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeedataGridView.RowTemplate.Height = 35;
            this.EmployeedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeedataGridView.Size = new System.Drawing.Size(935, 690);
            this.EmployeedataGridView.TabIndex = 1;
            this.EmployeedataGridView.DoubleClick += new System.EventHandler(this.EmployeedataGridView_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewEmployeeToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 94);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(18, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(975, 39);
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
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // LabelTopPanel
            // 
            this.LabelTopPanel.BackColor = System.Drawing.Color.White;
            this.LabelTopPanel.Controls.Add(this.label1);
            this.LabelTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTopPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelTopPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelTopPanel.Name = "LabelTopPanel";
            this.LabelTopPanel.Size = new System.Drawing.Size(975, 94);
            this.LabelTopPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(975, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışan Yönetim Ekranı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManageEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(975, 859);
            this.Controls.Add(this.EmployeedataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LabelTopPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageEmployeesForm";
            this.Text = "Çalışan Yönetimi";
            this.Load += new System.EventHandler(this.ManageEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LabelTopPanel.ResumeLayout(false);
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
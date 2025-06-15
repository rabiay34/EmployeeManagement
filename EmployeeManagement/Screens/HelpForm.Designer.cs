namespace EmployeeManagement.Screens
{
    partial class HelpForm
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
            this.panelTopHeader = new System.Windows.Forms.Panel();
            this.labelTopHeader = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.richTextBoxHelpContent = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelTopHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopHeader
            // 
            this.panelTopHeader.BackColor = System.Drawing.Color.White;
            this.panelTopHeader.Controls.Add(this.labelTopHeader);
            this.panelTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopHeader.Location = new System.Drawing.Point(0, 0);
            this.panelTopHeader.Name = "panelTopHeader";
            this.panelTopHeader.Size = new System.Drawing.Size(800, 75);
            this.panelTopHeader.TabIndex = 0;
            // 
            // labelTopHeader
            // 
            this.labelTopHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTopHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTopHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.labelTopHeader.Location = new System.Drawing.Point(0, 0);
            this.labelTopHeader.Name = "labelTopHeader";
            this.labelTopHeader.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelTopHeader.Size = new System.Drawing.Size(800, 75);
            this.labelTopHeader.TabIndex = 0;
            this.labelTopHeader.Text = "Yardım ve Destek";
            this.labelTopHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.richTextBoxHelpContent);
            this.panelContent.Location = new System.Drawing.Point(20, 95);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(3);
            this.panelContent.Size = new System.Drawing.Size(760, 425);
            this.panelContent.TabIndex = 1;
            // 
            // richTextBoxHelpContent
            // 
            this.richTextBoxHelpContent.BackColor = System.Drawing.Color.White;
            this.richTextBoxHelpContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxHelpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxHelpContent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxHelpContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxHelpContent.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxHelpContent.Name = "richTextBoxHelpContent";
            this.richTextBoxHelpContent.ReadOnly = true;
            this.richTextBoxHelpContent.Size = new System.Drawing.Size(754, 419);
            this.richTextBoxHelpContent.TabIndex = 0;
            this.richTextBoxHelpContent.Text = ""; // Yardım metni kod tarafından eklenecek
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(660, 540);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(120, 40);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Kapat";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 600); // Boyut artırıldı
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTopHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yardım";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.panelTopHeader.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopHeader;
        private System.Windows.Forms.Label labelTopHeader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.RichTextBox richTextBoxHelpContent;
        private System.Windows.Forms.Button buttonClose;
    }
}
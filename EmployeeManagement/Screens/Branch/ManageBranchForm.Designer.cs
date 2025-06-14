namespace EmployeeManagement.Screens.Departments
{
    partial class ManageBranchForm
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
            // DataGridView için modern stil nesneleri oluşturuluyor
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.BranchesDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NewBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelTopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BranchesDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.LabelTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BranchesDataGridView
            // 
            this.BranchesDataGridView.AllowUserToAddRows = false;
            this.BranchesDataGridView.AllowUserToDeleteRows = false;
            // Modern görünüm için Anchor ayarı, form boyutu değiştikçe DataGridView'in de büyümesini/küçülmesini sağlar.
            this.BranchesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BranchesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; // Sütunları otomatik doldurur
            this.BranchesDataGridView.BackgroundColor = System.Drawing.Color.White; // Arka planı temiz beyaz yapar
            this.BranchesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None; // Kenarlıkları kaldırır
            this.BranchesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal; // Sadece yatay çizgiler
            this.BranchesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None; // Başlık kenarlığını kaldırır

            // Başlık Stili (Header)
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BranchesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BranchesDataGridView.ColumnHeadersHeight = 40; // Başlık yüksekliğini artırır
            this.BranchesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Varsayılan Hücre Stili
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BranchesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;

            this.BranchesDataGridView.EnableHeadersVisualStyles = false; // Özel başlık stilini etkinleştirir
            this.BranchesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240))))); // Izgara rengini yumuşatır
            this.BranchesDataGridView.Location = new System.Drawing.Point(20, 115); // Yerleşim ve padding ayarı
            this.BranchesDataGridView.Name = "BranchesDataGridView";
            this.BranchesDataGridView.ReadOnly = true;
            this.BranchesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None; // Satır başlığı kenarlığını kaldırır
            this.BranchesDataGridView.RowHeadersVisible = false; // Satır başlığını gizler (genelde gereksizdir)

            // Alternatif Satır Stili (Zebra desen)
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.BranchesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;

            this.BranchesDataGridView.RowTemplate.Height = 35; // Satır yüksekliğini artırarak ferahlık sağlar
            this.BranchesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; // Tüm satırı seçer
            this.BranchesDataGridView.Size = new System.Drawing.Size(889, 559);
            this.BranchesDataGridView.TabIndex = 1;
            this.BranchesDataGridView.DoubleClick += new System.EventHandler(this.BranchesDataGridView_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White; // Arka planı beyaz yapar
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBranchToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 75); // Başlık panelinin altına alıyoruz
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(18, 5, 0, 5); // İç boşluk ekler
            this.menuStrip1.Size = new System.Drawing.Size(929, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NewBranchToolStripMenuItem
            // 
            // Öneri: Bu menü öğelerine ikon ekleyerek görsel zenginlik katabilirsiniz.
            // this.NewBranchToolStripMenuItem.Image = Properties.Resources.add_icon;
            this.NewBranchToolStripMenuItem.Name = "NewBranchToolStripMenuItem";
            this.NewBranchToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.NewBranchToolStripMenuItem.Text = "Yeni Şube Ekle";
            this.NewBranchToolStripMenuItem.Click += new System.EventHandler(this.NewBranchToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            // Öneri: Bu menü öğelerine ikon ekleyerek görsel zenginlik katabilirsiniz.
            // this.CloseToolStripMenuItem.Image = Properties.Resources.close_icon;
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.CloseToolStripMenuItem.Text = "Kapat";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // LabelTopPanel
            // 
            this.LabelTopPanel.BackColor = System.Drawing.Color.White; // Arka planı temiz beyaz yapar
            this.LabelTopPanel.Controls.Add(this.label1);
            this.LabelTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTopPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelTopPanel.Name = "LabelTopPanel";
            this.LabelTopPanel.Size = new System.Drawing.Size(929, 75); // Yüksekliği artırıyoruz
            this.LabelTopPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill; // Paneli tamamen doldurur
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85))))); // Metin rengini yumuşatır
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0); // Soldan boşluk bırakır
            this.label1.Size = new System.Drawing.Size(929, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şube Yönetim Ekranı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // Metni sola yaslar
            // 
            // ManageBranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252))))); // Formun genel arkaplan rengi
            this.ClientSize = new System.Drawing.Size(929, 694);
            // Kontrollerin eklenme sırası görsel katmanlamayı etkiler
            this.Controls.Add(this.BranchesDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LabelTopPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageBranchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Formu ekranın ortasında açar
            this.Text = "Şube Yönetimi";
            this.Load += new System.EventHandler(this.ManageBranchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BranchesDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LabelTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NewBranchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.DataGridView BranchesDataGridView;
        private System.Windows.Forms.Panel LabelTopPanel;
        private System.Windows.Forms.Label label1;
    }
}
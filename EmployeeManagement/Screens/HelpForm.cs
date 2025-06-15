using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagement.Screens
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            // Yardım metinlerini buraya ekleyin
            LoadHelpContent();
        }

        private void LoadHelpContent()
        {
            // Başlık fontu
            Font titleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            // Normal metin fontu
            Font bodyFont = new Font("Segoe UI", 10, FontStyle.Regular);

            // Metin kutusunu temizle
            richTextBoxHelpContent.Clear();

            // Başlık ekle
            AppendText("Çalışan Yönetimi\n", titleFont, Color.FromArgb(51, 65, 85));
            // Paragraf ekle
            AppendText("Yeni bir çalışan eklemek için ana paneldeki 'Yeni Çalışan Ekle' butonunu kullanabilirsiniz. Mevcut bir çalışanın bilgilerini düzenlemek için ise 'Çalışan Yönetimi' ekranından ilgili çalışana çift tıklayınız.\n\n", bodyFont, Color.FromArgb(64, 64, 64));

            // Başka bir başlık ekle
            AppendText("Şube Yönetimi\n", titleFont, Color.FromArgb(51, 65, 85));
            // Başka bir paragraf ekle
            AppendText("Şubeleri listelemek, yeni şube eklemek veya mevcut şubeleri düzenlemek için ana paneldeki 'Şube Yönetimi' butonunu kullanın.\n\n", bodyFont, Color.FromArgb(64, 64, 64));

            // İletişim bilgisi
            AppendText("Daha fazla yardım için:\n", titleFont, Color.FromArgb(51, 65, 85));
            AppendText("destek@nextwave.com", bodyFont, Color.Blue);
        }

        // RichTextBox'a formatlı metin eklemek için yardımcı bir metod
        private void AppendText(string text, Font font, Color color)
        {
            richTextBoxHelpContent.SelectionStart = richTextBoxHelpContent.TextLength;
            richTextBoxHelpContent.SelectionLength = 0;

            richTextBoxHelpContent.SelectionFont = font;
            richTextBoxHelpContent.SelectionColor = color;
            richTextBoxHelpContent.AppendText(text);
            richTextBoxHelpContent.SelectionColor = richTextBoxHelpContent.ForeColor;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
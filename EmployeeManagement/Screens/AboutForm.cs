using System;
using System.Reflection; // Assembly bilgilerini çekmek için
using System.Windows.Forms;

namespace EmployeeManagement.Screens
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            LoadAppInfo(); // Form oluşturulurken bilgileri yükle
        }

        private void LoadAppInfo()
        {
            // Uygulama adını ve açıklamasını sabit bırakabilir veya Assembly'den alabilirsiniz.
            // labelAppName.Text = Assembly.GetExecutingAssembly().GetName().Name;

            // Versiyon numarasını dinamik olarak al
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            labelVersion.Text = $"Versiyon {version.Major}.{version.Minor}.{version.Build}";

            // Telif hakkı bilgisini dinamik olarak ayarla
            labelCopyright.Text = $"© {DateTime.Now.Year} Nextwave. Tüm hakları saklıdır.";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
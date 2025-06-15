using EmployeeManagement.Screens.Departments;
using EmployeeManagement.Screens.Employees;
using EmployeeManagement.Screens.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement.Screens
{
    public partial class DashboardForm : FormTemplate
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Saati "HH:mm:ss" formatında göster
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");

            // Tarihi uzun formatta (örn: "23 Ekim 2023 Pazartesi") göster
            // CultureInfo ile Türkçe karakterlerin doğru gösterilmesini sağlıyoruz
            labelDate.Text = DateTime.Now.ToString("dd MMMM yyyy, dddd", new CultureInfo("tr-TR"));
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dosyaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {

            ShowEmployeeInfoScreen(0, false);
        }

        private void ShowEmployeeInfoScreen(int employeeId, bool isUpdate)
        {
            EmployeeInfoForm eif = new EmployeeInfoForm();
            eif.EmployeeId = employeeId;
            eif.IsUpdate = isUpdate;
            eif.ShowDialog();
        }

        private void BranchYonetimToolStripButton_Click(object sender, EventArgs e)
        {
            ManageBranchForm mbf = new ManageBranchForm();
            mbf.ShowDialog();
        }
        private void ManageUsersToolStripButton_Click_1(object sender, EventArgs e)
        {
            ManageEmployeesForm mef = new ManageEmployeesForm();
            mef.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HelpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AboutForm ab = new AboutForm();
            ab.ShowDialog();
        }
    }
}

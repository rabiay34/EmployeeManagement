using EmployeeManagement.Screens.Departments;
using EmployeeManagement.Screens.Employees;
using EmployeeManagement.Screens.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void BranchYonetimToolStripButton_Click(object sender, EventArgs e)
        {
            ManageBranchForm mbf = new ManageBranchForm();
            mbf.ShowDialog();
        }

        private void ManageUsersToolStripButton_Click(object sender, EventArgs e)
        {
            ManageEmployeesForm mef = new ManageEmployeesForm();
            mef.ShowDialog();
        }
    }
}

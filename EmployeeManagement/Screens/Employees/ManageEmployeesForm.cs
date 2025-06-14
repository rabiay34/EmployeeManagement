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

namespace EmployeeManagement.Screens.Employees
{
    public partial class ManageEmployeesForm : FormTemplate
    {
        public ManageEmployeesForm()
        {
            InitializeComponent();
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {

        }

        private void AddNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowEmployeeInfoScreen(0, false);
        }

        private void ShowEmployeeInfoScreen(int employeeId, bool isUpdate)
        {
            EmployeeInfoForm eif = new EmployeeInfoForm();
            eif.EmployeeId = employeeId;
            eif.IsUpdate = IsUpdate;
            eif.ShowDialog();
        }
    }
}

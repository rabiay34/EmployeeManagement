using EmployeeManagement.Screens.Templates;
using EmployeeManagement.Utilities.Lists;
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
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            ListData.LoadDataIntoDataGridView(EmployeedataGridView, "usp_EmployeesGetEmployees");
        }

        private void AddNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void EmployeedataGridView_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = EmployeedataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            int employeeId=Convert.ToInt32(EmployeedataGridView.Rows[rowIndex].Cells["EmployeeId"].Value);
            ShowEmployeeInfoScreen(employeeId, true);
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

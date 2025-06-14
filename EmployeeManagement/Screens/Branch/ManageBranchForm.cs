using EmployeeManagement.Screens.Templates;
using EmployeeManagement.Utilities.Lists;
using System;
using System.Windows.Forms;

namespace EmployeeManagement.Screens.Departments
{
    public partial class ManageBranchForm : FormTemplate
    {
        public ManageBranchForm()
        {
            InitializeComponent();
        }

        private void NewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showBranchInfoScreen(0, false);

        }

        private void showBranchInfoScreen(int branchId, bool isUpdate)
        {
            BranchInfoForm bif = new BranchInfoForm();

            bif.BranchId = branchId;
            bif.IsUpdate = isUpdate;
            bif.ShowDialog();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageBranchForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            ListData.LoadDataIntoDataGridView(BranchesDataGridView, "usp_BranchesGetAllBranches");
         
        }

        private void BranchesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = BranchesDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int branchId = Convert.ToInt32(BranchesDataGridView.Rows[rowIndex].Cells["BranchId"].Value);

            ShowBranchInfoScreen(branchId, true);
        }

        private void ShowBranchInfoScreen(int branchId, bool v)
        {
            BranchInfoForm bif = new BranchInfoForm();

            bif.BranchId = branchId;
            bif.IsUpdate = v;
            bif.ShowDialog();
        }

        private void TopPanelLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

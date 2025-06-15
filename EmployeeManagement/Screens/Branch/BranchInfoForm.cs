using DBFramework;
using DBFramework.Windows;
using EmployeeManagement.Models.Branches;
using EmployeeManagement.Models.Users;
using EmployeeManagement.Screens.Templates;
using EmployeeManagement.Utilities;
using EmployeeManagement.Utilities.Lists;
using System;
using System.Data;
using System.Windows.Forms;

namespace EmployeeManagement.Screens.Departments
{
    public partial class BranchInfoForm : FormTemplate
    {
        public int BranchId { get; set; }
        public BranchInfoForm()
        {
            InitializeComponent();
        }

        private void LabelTopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (IsFormValidated())
            {
                if (this.IsUpdate)
                {
                    SaveOrUpdateRecord("usp_BranchesUpdateBranchDetails");

                    DBMessageBox.ShowSuccessMessage("Kayıt Başarıyla Güncellendi!");


                }
                else
                {
                    SaveOrUpdateRecord("usp_BranchesAddNewBranch");

                    DBMessageBox.ShowSuccessMessage("Kayıt Başarılı!");

                }

                this.Close();
            }
        }

        private void SaveOrUpdateRecord(string storedProceName)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord(storedProceName, GetObject());
        }

        private Branch GetObject()
        {
            Branch branch = new Branch();
            branch.BranchId = (this.IsUpdate) ? this.BranchId : 0;
            branch.BranchName = BranchNameTextBox.Text;
            branch.EmailAddress = EmailAddressTextBox.Text;
            branch.Telephone = TelephoneTextBox.Text;
            branch.AddressLine = AddressLinetextBox.Text;
            branch.CityId = Convert.ToInt32(CityNameComboBox.SelectedValue);
            branch.DistrictId = Convert.ToInt32(DistrictComboBox.SelectedValue);
            branch.PostCode = PostCodeTextBox.Text;
            branch.CreatedBy = LoggedInUser.UserName;

            return branch;
        }

        private bool IsFormValidated()
        {
            if (BranchNameTextBox.Text.Trim() == string.Empty)
            {

                DBMessageBox.ShowErrorMessage("Şube zorunlu!");

                BranchNameTextBox.Focus();
                return false;

            }
            if (EmailAddressTextBox.Text.Trim() == string.Empty)
            {
                DBMessageBox.ShowErrorMessage("Eamil zorunlu!");

                EmailAddressTextBox.Focus();
                return false;

            }

            return true;
        }

        private void BranchTextBox_TextChanged(object sender, EventArgs e)
        {
            TopPanelLabel.Text = BranchNameTextBox.Text;
        }

        private void BranchInfoForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();
            LoadDataAndBindToControlIfUpdate();

        }

        private void LoadDataIntoComboBoxes()
        {
            ListData.LoadDataIntoComboBox(CityNameComboBox, new DbParameter { Parameter = "@ListTypesId", Value = "1" });
            ListData.LoadDataIntoComboBox(DistrictComboBox, new DbParameter { Parameter = "@ListTypesId", Value = "2" });

        }
        private void LoadDataAndBindToControlIfUpdate()
        {
           if (this.IsUpdate)
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                DataTable dtBranch = db.GetDataList("usp_BranchesGetBranchDetailByBranchId", new DbParameter { Parameter = "@BranchId", Value = this.BranchId.ToString() });
                DataRow row = dtBranch.Rows[0];

                BranchNameTextBox.Text = row["BranchName"].ToString();
                EmailAddressTextBox.Text = row["EmailAddress"].ToString();
                TelephoneTextBox.Text = row["Telephone"].ToString();
                AddressLinetextBox.Text = row["AddressLine"].ToString();
                CityNameComboBox.SelectedValue = row["CityId"];
                DistrictComboBox.SelectedValue = row["DistrictId"];
                PostCodeTextBox.Text = row["PostCode"].ToString();
            }
        }

    }
}

using DBFramework;
using DBFramework.Windows;
using EmployeeManagement.Models.Employees;
using EmployeeManagement.Models.Users;
using EmployeeManagement.Screens.Templates;
using EmployeeManagement.Utilities;
using EmployeeManagement.Utilities.Lists;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeManagement.Screens.Employees
{
    public partial class EmployeeInfoForm : FormTemplate
    {
        public EmployeeInfoForm()
        {
            InitializeComponent();
        }
        public int EmployeeId { get; set; }
        private void EmployeeInfoForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();
            if (this.IsUpdate)
            {
                //update code here write
                LoadDataAndBindIntoControls();
            }
            else
            {
                GenerateEmployeeId();

            }
        }

        private void LoadDataAndBindIntoControls()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            DataTable dtEmployee = db.GetDataList(
                "usp_EmployeeGetEmployeeDetailsById",
                new DbParameter { Parameter = "@EmployeeId", Value = this.EmployeeId.ToString() }
            );

                DataRow row = dtEmployee.Rows[0];
                EmployeeIDTextBox.Text = row["EmployeeId"].ToString();
                FullNameTextBox.Text = row["FullName"].ToString();
                DateLeftDateTimePicker.Value = Convert.ToDateTime(row["DateOfBirth"]);
                TcNoTextBox.Text = row["NICNumber"].ToString();
                EmailTextBox.Text = row["EmailAddress"].ToString();
                MobileTextBox.Text = row["Mobile"].ToString();
                TelephoneTextBox.Text = row["Telephone"].ToString();
                GenderComboBox.SelectedValue = row["GenderId"];
                DateLeftDateTimePicker.Value = Convert.ToDateTime(row["EmploymentDate"]);
                BranchNameComboBox.SelectedValue = row["BranchId"];
                PhotopictureBox.Image = (row["Photo"] is DBNull) ? null : ImageManipualtions.PutPhoto((byte[])row["Photo"]);
                AdressLineTextBox.Text = row["AddressLine"].ToString();
                CityComboBox.SelectedValue = row["CityId"];
                DistrictComboBox.SelectedValue = row["DistrictId"];
                PostCodeTextBox.Text = row["PostCode"].ToString();
                JobTitleComboBox.SelectedValue = row["JobTitleId"];
                CurrentSalaryTextBox.Text = row["CurrentSalary"].ToString();
                StartingSalaryTextBox.Text = row["StartingSalary"].ToString();
                HasLeftComboBox.Text = (Convert.ToBoolean(row["HasLeft"]) == true) ? "Evet" : "Hayır";
                DateLeftDateTimePicker.Value = Convert.ToDateTime(row["DateLeft"]);
                EmployeeLeavingReasonComboBox.SelectedValue = row["ReasonLeftId"];

        }

        private void LoadDataIntoComboBoxes()
        {
            ListData.LoadDataIntoComboBox(CityComboBox, new DbParameter { Parameter = "@ListTypesId", Value = "1" });
            ListData.LoadDataIntoComboBox(DistrictComboBox, new DbParameter { Parameter = "@ListTypesId", Value = "2" });
            ListData.LoadDataIntoComboBox(GenderComboBox, new DbParameter { Parameter = "@ListTypesId", Value = "3" });
            ListData.LoadDataIntoComboBox(JobTitleComboBox, new DbParameter { Parameter = "@ListTypesId", Value = "4" });
            ListData.LoadDataIntoComboBox(HasLeftComboBox, new DbParameter { Parameter = "@ListTypesId", Value = "5" });
            ListData.LoadDataIntoComboBox(EmployeeLeavingReasonComboBox, new DbParameter { Parameter = "@ListTypesId", Value = "6" });
            ListData.LoadDataIntoComboBox(BranchNameComboBox, "usp_BranchesGetAllBranchNames");
        }

        private void GenerateEmployeeId()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());

            EmployeeIDTextBox.Text = db.GetScalarValue("usp_EmployeesGenerateNewEmployeeId").ToString();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhotopictureBox_DoubleClick(object sender, EventArgs e)
        {
            GetPhoto();
        }

        private void GetPhoto()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Logo";
            ofd.Filter = "Logo File (*.png;*.jpd;*.bmp;*.gif)|*.png;*.jpd;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PhotopictureBox.Image = new Bitmap(ofd.FileName);
            }
        }

        private void GetPhotoPictureBox_Click(object sender, EventArgs e)
        {
            GetPhoto();
        }

        private void ClearPictureBox_Click(object sender, EventArgs e)
        {
            PhotopictureBox.Image = null;
        }

        private void SaveRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (IsFormValidated())
            {
                if (this.IsUpdate)
                {
                    //updaate
                    SaveOrUpdateRecord("Usp_EmployeesUpdateEmployeeDetails");

                    DBMessageBox.ShowSuccessMessage("Kayıt Başarıyla Güncellendi!");


                }
                else
                {
                    //insert
                    SaveOrUpdateRecord("Usp_EmployeesAddNewEmployee");

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

        private Employee GetObject()
        {
            Employee employee = new Employee();
            employee.EmployeeId = Convert.ToInt32(EmployeeIDTextBox.Text);
            employee.FullName = FullNameTextBox.Text.Trim();
            employee.DateOfBirth = DateOfBirthDateTimePicker.Value.Date;
            employee.NICNumber = TcNoTextBox.Text.Trim();

            employee.AddressLine = AdressLineTextBox.Text.Trim();
            employee.EmailAddress = EmailTextBox.Text.Trim();
            employee.Mobile = MobileTextBox.Text.Trim();
            employee.Telephone = TelephoneTextBox.Text.Trim();
            employee.EmploymentDate = DateLeftDateTimePicker.Value.Date;

            employee.GenderId = (GenderComboBox.SelectedIndex == -1) ? 0: Convert.ToInt32(GenderComboBox.SelectedValue);
            employee.BranchId = (BranchNameComboBox.SelectedIndex == -1) ? 0:Convert.ToInt32(BranchNameComboBox.SelectedValue);
            employee.Photo = (PhotopictureBox.Image == null) ? null : ImageManipualtions.GetPhoto(PhotopictureBox);
            employee.CityId = (CityComboBox.SelectedIndex == -1) ? 0: Convert.ToInt32(CityComboBox.SelectedValue);
            employee.DistrictId = (DistrictComboBox.SelectedIndex == -1) ? 0 :Convert.ToInt32(DistrictComboBox.SelectedValue);
            employee.PostCode = PostCodeTextBox.Text.Trim();

            employee.JobTitleId = (JobTitleComboBox.SelectedIndex == -1) ? 0: Convert.ToInt32(JobTitleComboBox.SelectedValue);
            employee.CurrentSalary = Convert.ToDecimal(CurrentSalaryTextBox.Text.Trim());
            employee.StartingSalary = Convert.ToDecimal(StartingSalaryTextBox.Text.Trim());
            employee.HasLeft = (HasLeftComboBox.Text == "Evet") ? true :false;
            employee.DateLeft = DateLeftDateTimePicker.Value.Date;
            employee.ReasonLeftId = (EmployeeLeavingReasonComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(EmployeeLeavingReasonComboBox.SelectedValue);
            employee.Comments = EmployeeLeavingCommentsTextBox.Text.Trim();
            employee.CreatedBy = LoggedInUser.UserName;
            return employee;
        }

        private bool IsFormValidated()
        {

            if (FullNameTextBox.Text.Trim() == string.Empty)
            {

                DBMessageBox.ShowErrorMessage("Ad-Soyad zorunlu!");

                FullNameTextBox.Focus();
                return false;

            }
            if (TcTextBox.Text.Trim() == string.Empty)
            {
                DBMessageBox.ShowErrorMessage("Hesap Numarası zorunlu!");

                TcTextBox.Focus();
                return false;

            }
            if (MobileTextBox.Text.Trim() == string.Empty && TelephoneTextBox.Text.Trim() == string.Empty)
            {
                DBMessageBox.ShowErrorMessage("Cep / Sabit telefon zorunlu!");

                MobileTextBox.Focus();
                return false;

            }
            if (!string.IsNullOrWhiteSpace(MobileTextBox.Text.Trim()) && !MobileTextBox.Text.Trim().StartsWith("05"))
            {
                DBMessageBox.ShowErrorMessage("Cep telefonu '05' ile başlamalıdır!");
                MobileTextBox.Focus();
                return false;
            }

            if (GenderComboBox.SelectedIndex == -1)
            {
                DBMessageBox.ShowErrorMessage("Cinsiyet zorunlu!");

                // GenderComboBox.Focus();
                return false;

            }
            string email = EmailTextBox.Text.Trim();

            if (email == string.Empty)
            {
                DBMessageBox.ShowErrorMessage("Email zorunlu!");
                EmailTextBox.Focus();
                return false;
            }

            if (!email.Contains("@"))
            {
                DBMessageBox.ShowErrorMessage("Geçerli bir email adresi giriniz! '@' işareti eksik.");
                EmailTextBox.Focus();
                return false;
            }

            if (CityComboBox.SelectedIndex == -1)
            {
                DBMessageBox.ShowErrorMessage("Şehir zorunlu!");
                // GenderComboBox.Focus();
                return false;

            }
            if (DistrictComboBox.SelectedIndex == -1)
            {
                DBMessageBox.ShowErrorMessage("Cinsiyet zorunlu!");
                // GenderComboBox.Focus();
                return false;

            }
            if (PostCodeTextBox.Text.Trim() == string.Empty)
            {
                DBMessageBox.ShowErrorMessage("Posta Kodu zorunlu!");

                PostCodeTextBox.Focus();
                return false;

            }
            string postCode = PostCodeTextBox.Text.Trim();

            if (postCode.Length != 5)
            {
                DBMessageBox.ShowErrorMessage("Posta Kodu 5 karakterli olmalıdır!");
                PostCodeTextBox.Focus();
                return false;
            }

            if (JobTitleComboBox.SelectedIndex == -1)
            {
                DBMessageBox.ShowErrorMessage("Departman seçmek zorunlu!");
                // GenderComboBox.Focus();
                return false;

            }
            if (CurrentSalaryTextBox.Text.Trim() == string.Empty)
            {
                DBMessageBox.ShowErrorMessage("Güncel maaş bilgisi gerekli!");

                CurrentSalaryTextBox.Focus();
                return false;
            }
            else
            {
                if (Convert.ToDecimal(CurrentSalaryTextBox.Text.Trim()) <1)
                {

                    DBMessageBox.ShowErrorMessage("Güncel maaş bilgisi 1'den büyük olmalı!");
                    CurrentSalaryTextBox.Focus();
                    return false;
                }
            }

            if (StartingSalaryTextBox.Text.Trim() == string.Empty)
            {
                DBMessageBox.ShowErrorMessage("Başlangıç maaş bilgisi gerekli!");

                StartingSalaryTextBox.Focus();
                return false;
            }
            else
            {
                if (Convert.ToDecimal(CurrentSalaryTextBox.Text.Trim()) < 1)
                {

                    DBMessageBox.ShowErrorMessage("Başlangıç maaş bilgisi 1'den büyük olmalı!");
                    StartingSalaryTextBox.Focus();
                    return false;
                }
            }
            return true;
        }

       
    }
}

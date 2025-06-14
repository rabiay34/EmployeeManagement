using DBFramework;
using EmployeeManagement.Models.Users;
using EmployeeManagement.Screens.Templates;
using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace EmployeeManagement.Screens
{
    public partial class LoginForm : FormTemplate
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                bool isLoginInfoCorrect = Convert .ToBoolean ( db.GetScalarValue ("usp_UsersCheckLoginDetails", GetParameters())); 

                if (isLoginInfoCorrect)
                {
                    GetLoggedInUserSetting();
                    this.Hide();
                    DashboardForm dashboardForm = new DashboardForm();
                    dashboardForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void GetLoggedInUserSetting()
        {
            LoggedInUser.UserName = UserNameTextBox.Text;
        }

        private DbParameter[] GetParameters()
        {
            List<DbParameter> parameters = new List<DbParameter>();
            DbParameter dbparam1 = new DbParameter();
            dbparam1.Parameter = "@UserName";
            dbparam1.Value = UserNameTextBox.Text;
            parameters.Add(dbparam1);

            DbParameter dbparam2 = new DbParameter();
            dbparam2.Parameter = "@Password";
            dbparam2.Value = PasswordTextBox.Text;
            parameters.Add(dbparam2);

            return parameters.ToArray();
        }

        private bool IsFormValid()
        {
            if (UserNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Kullanıcı ismi girmelisiniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTextBox.Clear();
                PasswordTextBox.Clear();
                return false;
            }

            if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Şifre girmeniz gerekmektedir!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTextBox.Clear();
                PasswordTextBox.Clear();
                return false;
            }
            return true;
        }
    }
}


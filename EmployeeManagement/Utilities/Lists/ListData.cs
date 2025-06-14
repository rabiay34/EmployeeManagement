using DBFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace EmployeeManagement.Utilities.Lists
{
    public class ListData
    {
        public static void LoadDataIntoDataGridView(DataGridView dgv,string storedproceName)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            dgv.DataSource = db.GetDataList(storedproceName);

            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static void LoadDataIntoComboBox(ComboBox cb, DbParameter par)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            cb.DataSource = db.GetDataList("usp_ListTypesDataGetDataByListTypeId", par);
            cb.DisplayMember = "Description";
            cb.ValueMember = "Id";
            cb.SelectedIndex = -1;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void LoadDataIntoComboBox(ComboBox cb,string storedProcName, DbParameter par)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            cb.DataSource = db.GetDataList(storedProcName, par);
            cb.DisplayMember = "Description";
            cb.ValueMember = "Id";
            cb.SelectedIndex = -1;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void LoadDataIntoComboBox(ComboBox cb, string storedProcName)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            cb.DataSource = db.GetDataList(storedProcName);
            cb.DisplayMember = "Description";
            cb.ValueMember = "Id";
            cb.SelectedIndex = -1;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void LoadDataIntoComboBox(ComboBox cb, string storedProcName, DbParameter[] pars)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            cb.DataSource = db.GetDataList(storedProcName, pars);
            cb.DisplayMember = "Description";
            cb.ValueMember = "Id";
            cb.SelectedIndex = -1;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;


        }
    }
}

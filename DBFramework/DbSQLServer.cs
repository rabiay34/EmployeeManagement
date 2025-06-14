using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Reflection;

namespace DBFramework
{
    public class DbSQLServer
    {
        private string _connectionString;

        public DbSQLServer(string connectionString)
        {
            _connectionString = connectionString;
        }


        // DataTable dataset
        public DataTable GetDataList(string storedProceName)
        {
            DataTable dtData = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtData.Load(reader);
                }
            }
            return dtData;
        }

        public DataTable GetDataList(string storedProceName, DbParameter parameter)
        {
            DataTable dtData = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtData.Load(reader);
                }
            }
            return dtData;
        }

        // DataTable dataset
        public DataTable GetDataList(string storedProceName, DbParameter[] parameters )
        {
            DataTable dtData = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Parameter, param.Value);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtData.Load(reader);
                }
            }
            return dtData;
        }


        public object GetScalarValue(string storedProceName,DbParameter parameter)
        {
            object value = null;
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName,con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue(parameter .Parameter, parameter .Value);
                    value = cmd.ExecuteScalar();
                }
            }
            return value;
        }


        //For Employee ID

        public object GetScalarValue(string storedProceName)
        {
            object value = null;
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();

                    value = cmd.ExecuteScalar();
                }
            }

            return value;
        }

        public object GetScalarValue(string storedProceName, DbParameter[] parameters)
        {
            object value = null;
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    foreach( var param in parameters)
                    {
                         cmd.Parameters.AddWithValue(param.Parameter, param.Value);
                    }
                  
                    value = cmd.ExecuteScalar();
                }
            }
            return value;
        }

        //Save&Update Method

        public void SaveOrUpdateRecord(string storedProceName, object obj)
        {

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    //Parameters
                    Type type = obj.GetType();
                    BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
                    PropertyInfo[] properties = type.GetProperties(flags);
                    foreach (var property in properties)
                    {
                       // cmd.Parameters.AddWithValue("@username", BranchName.text);
                        cmd.Parameters.AddWithValue("@" + property.Name, property.GetValue(obj, null));
                    }

                    cmd.ExecuteNonQuery();

                }
            }
        }

    }
}

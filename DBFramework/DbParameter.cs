using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DBFramework
{
    public class DbParameter
    {
       public string Parameter { get; set; }
       public string Value { get; set; }

    }
}
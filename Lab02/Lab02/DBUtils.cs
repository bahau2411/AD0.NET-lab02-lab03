using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class DBUtils
    {
        public static SqlConnection
                GetDBConnection(string datasource, string database, string username, string password)
        {
            string connection = @"Data Source=" + datasource +
                                ";Initial Catalog=" + database +
                                ";Persist Security Info = True" +
                                ";User ID=" + username +
                                ";Password=" + password;

            SqlConnection conn = new SqlConnection(connection);
            return conn;
        }
    }
}

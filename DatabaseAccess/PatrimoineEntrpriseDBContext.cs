using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public class PatrimoineEntrpriseDBContext
    {
        public static SqlConnection GetDBConnection()
        {
            //
            // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
            //
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);

            return conn;
        }
    }
}

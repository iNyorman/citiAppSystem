using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem
{
    public class DbConnection
    {

        public static IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["citiAppSystem.Properties.Settings.citiAppDatabaseConnectionString"].ConnectionString);
            }
        }
    }
}

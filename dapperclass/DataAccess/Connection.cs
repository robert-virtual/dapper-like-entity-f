using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace dapperclass.DataAccess
{
    public class Connection
    {
        protected static SqlConnection ConnectDB() => new SqlConnection(ConfigurationManager.ConnectionStrings["Amazondb"].ConnectionString); 
    }
}

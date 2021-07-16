using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaRindoLite.DBConnector
{
    class MsSqlConnector : IConnector
    {
        SqlConnection IConnector.GetConnection()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=L00PSS;Initial Catalog=RindoSoft;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}

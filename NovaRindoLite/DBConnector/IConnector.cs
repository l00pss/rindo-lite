using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;



namespace NovaRindoLite.DBConnector
{
    interface IConnector
    {
        SqlConnection GetConnection();
    }
}

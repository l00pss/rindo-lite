using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using NovaRindoLite.Utilities.SqlCommands;
using DevExpress.XtraGrid;

namespace NovaRindoLite.Business.abstracts
{
    public interface IDataServer
    {
        void ListingData(DataTable dataTable, SqlDataAdapter sqlDataAdapter, String commands, GridControl gridControl);
    }
}

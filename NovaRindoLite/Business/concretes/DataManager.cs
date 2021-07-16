using NovaRindoLite.Business.abstracts;
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
namespace NovaRindoLite.Business.concretes
{
    class DataManager:IDataServer
    {

        private DBConnector.IConnector connector;
        void IDataServer.ListingData(DataTable dataTable, SqlDataAdapter sqlDataAdapter, string commands, GridControl gridControl)
        {
            
            connector = new DBConnector.MsSqlConnector();
            dataTable = new DataTable();
            sqlDataAdapter = new SqlDataAdapter(commands, connector.GetConnection());
            sqlDataAdapter.Fill(dataTable);
            gridControl.DataSource = dataTable;
            connector.GetConnection().Close();
        }
    }
}

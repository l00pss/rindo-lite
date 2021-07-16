using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using NovaRindoLite.Utilities.SqlCommands;
using NovaRindoLite.Business.abstracts;
using NovaRindoLite.Business.concretes;

namespace NovaRindoLite.Modules
{
    public partial class Products : Form
    {

        private DataTable dataTable;
        private SqlDataAdapter sqlDataAdapter;
        private IDataServer dataServer;


        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            dataServer = new DataManager();
            dataServer.ListingData(dataTable,sqlDataAdapter,ListCommands.PRODUCT,gridControlProduct);
            panelSetting.Visible = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(panelSetting.Visible == false)
            {
                panelSetting.Visible = true;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panelSetting.Visible = false;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            dataServer = new DataManager();
            dataServer.ListingData(dataTable, sqlDataAdapter, ListCommands.PRODUCT, gridControlProduct);
        }

        
    }
}

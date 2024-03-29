﻿using System;
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
using NovaRindoLite.Utilities.SqlCommands;
using NovaRindoLite.Utilities.SqlCommands.abstracts;
using NovaRindoLite.Utilities.SqlCommands.concretes;

namespace NovaRindoLite.Modules
{
    public partial class Products : Form
    {

        private DataTable dataTable;
        private SqlDataAdapter sqlDataAdapter;
        private IDataServer dataServer;
        private ICommands commands;


        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            commands = new Utilities.SqlCommands.concretes.Products();
            
            dataServer = new DataManager();
            dataServer.ListingData(dataTable,sqlDataAdapter,commands.,gridControlProduct);
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
            aProduct = new Utilities.SqlCommands.concretes.Products();
            dataServer = new DataManager();
            dataServer.ListingData(dataTable, sqlDataAdapter, aProduct.PRODUCT, gridControlProduct);
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            panelSetting.Visible = true;
        }

        private void panelSetting_Paint(object sender, PaintEventArgs e)
        { 
           if (lockID.Checked == true)
            {
                txt_ID.Enabled = false;
            }
        }

        private void lockID_CheckedChanged(object sender, EventArgs e)
        {
            if (lockID.Checked == true)
            {
                txt_ID.Enabled = false;
            }
            else
            {
                txt_ID.Enabled = true;
            }
        }

        private void gridControlProduct_Click(object sender, EventArgs e)
        {

        }
    }
}

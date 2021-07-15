using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaRindoLite
{
    public partial class Form1 : Form
    {
        private Modules.Home homeForm;
        private Modules.Products productsForm;
        private Modules.Stock stockForm;
        private Modules.Base.Expenses expensesForm;
        private Modules.Base.Invoices invoicesForm;
        private Modules.Base.Report reportForm;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homeForm = new Modules.Home();
            homeForm.MdiParent = this;
            homeForm.Show();
        }

        private void btn_home_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (homeForm == null)
            {
                homeForm = new Modules.Home();
                homeForm.MdiParent = this;
                homeForm.Show();
            }
        }

        private void btn_stock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stockForm == null)
            {
                stockForm = new Modules.Stock();
                stockForm.MdiParent = this;
                stockForm.Show();
            }
        }

        private void btn_products_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (productsForm == null)
            {
                productsForm = new Modules.Products();
                productsForm.MdiParent = this;
                productsForm.Show();
            }
        }

        private void btn_invoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (invoicesForm == null)
            {
                invoicesForm = new Modules.Base.Invoices();
                invoicesForm.MdiParent = this;
                invoicesForm.Show();
            }
        }

        private void btn_expenses_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (expensesForm == null)
            {
                expensesForm = new Modules.Base.Expenses();
                expensesForm.MdiParent = this;
                expensesForm.Show();
            }
        }

        private void btn_reports_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (reportForm == null)
            {
                reportForm = new Modules.Base.Report();
                reportForm.MdiParent = this;
                reportForm.Show();
            }
        }
    }
}

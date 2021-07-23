using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaRindoLite.Utilities.SqlCommands.concretes
{
    class Customer:abstracts.ACustomer
    {
        const string Customers = "Select * From TBL_CUSTOMER";
        public static string CUSTOMER { get { return Customers; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaRindoLite.Utilities.SqlCommands.concretes
{
    public class Products:abstracts.AProduct
    {
        const string Product = "Select * From TBL_PRODUCT_ENTITY";
        public static string PRODUCT { get { return Product; } }
    }
}

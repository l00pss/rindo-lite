using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaRindoLite.Utilities.SqlCommands.concretes
{
    class CategoryName:abstracts.ACategoryName
    {
        const string categoryName = "Select * From TBL_CATEGORY_NAME";
        public static string CATEGORY_NAME { get { return categoryName; } }
    }
}

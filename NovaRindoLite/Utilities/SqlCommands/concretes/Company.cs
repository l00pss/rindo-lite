using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaRindoLite.Utilities.SqlCommands.concretes
{
    class Company:abstracts.ACompany
    {
        const string Companys = "Select * From TBL_COMPANY";
        public static string COMPANY { get { return Companys; } }
    }
}

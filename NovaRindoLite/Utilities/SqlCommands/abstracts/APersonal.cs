using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaRindoLite.Utilities.SqlCommands.abstracts
{
    public abstract class APersonal
    {
        const string Personal = "Select * From TBL_PERSONAL";
        public static string PERSONAL { get { return Personal; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaRindoLite.Utilities.SqlCommands.concretes
{
    class Bank:abstracts.ABank
    {
        const string Banks = "Select * From TBL_BANKS";
        public static string BANKS { get { return Banks; } }
    }
}
